using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using DllbddPersonnels;
using BddpersonnelContext;
using System.IO;
using System.Drawing;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour GestionService.xaml
    /// </summary>
    public partial class GestionPersonnel : Window
    {
        BitmapImage imageBit;
        byte[] images;

        private bddpersonnels bddpersonnels;
        public GestionPersonnel(bddpersonnels bdd)
        {
            InitializeComponent();

            bddpersonnels = bdd;
            ListeService.DataContext = bdd.ListeServices();
            ListeFonction.DataContext = bdd.ListeFonctions();
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            string prenom = PrenomTb.Text;
            string nom = NomTb.Text;
            int service = ListeService.SelectedIndex;
            int fonction = ListeFonction.SelectedIndex;
            string telephone = TelephoneTb.Text;
            byte[] image = images;

            try
            {
                bddpersonnels.InsertPersonnel(prenom, nom, service, fonction, telephone, image);

            }
            catch
            {
                MessageBox.Show("l'insetion n'a pas marcher");
            }

            this.Close();

        }

        private void ImageBt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string ur = open.FileName;
            Uri url = new Uri(ur);
            imageBit = new BitmapImage(url);
            Image.Source = imageBit;

            System.Drawing.Image image = System.Drawing.Image.FromFile(ur);

            images = ImageToByteArray(image);
        }


        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


        private Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            // BitmapImage bitmapImage = new BitmapImage(new Uri("../Images/test.png", UriKind.Relative));

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
               Bitmap bitmap = new Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }
    }
}
