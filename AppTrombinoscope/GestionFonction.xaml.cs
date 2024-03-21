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
using BddpersonnelContext;
using DllbddPersonnels;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour GestionService.xaml
    /// </summary>
    public partial class GestionFonction : Window
    {
        bddpersonnels bddPersonnels;

        public GestionFonction(bddpersonnels bdd)
        {
            InitializeComponent();
            bddPersonnels = bdd;

            foreach (Fonction f in bdd.ListeFonction())
            {
                ListeFonction.Items.Add(new MyItem { Name = f.Intitule });
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string intitule = NomFonctionText.Text;
            NomFonctionText.Text = "";

            if (!intitule.Equals(""))
            {
                bddPersonnels.InsertFonction(intitule);
                updateList(bddPersonnels);
            }
        }


        private void updateList(bddpersonnels bdd)
        {
            ListeFonction.Items.Clear();
            foreach (Fonction f in bdd.ListeFonction())
            {
                ListeFonction.Items.Add(new MyItem { Name = f.Intitule });
            }
        }

        private void SupprimerContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ALED");
        }

        private void modifierContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ALED");
        }

    }
}
