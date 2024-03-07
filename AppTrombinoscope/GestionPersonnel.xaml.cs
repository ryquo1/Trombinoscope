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
using DllbddPersonnels;
using BddpersonnelContext;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour GestionService.xaml
    /// </summary>
    public partial class GestionPersonnel : Window
    {

        private bddpersonnels bddpersonnels;
        public GestionPersonnel(bddpersonnels bdd)
        {
            InitializeComponent();

            bddpersonnels = bdd;
            foreach (Service s in bddpersonnels.ListServices())
            {
                ListeService.Items.Add(s.Intitule);
            }

            foreach(Fonction f in bddpersonnels.ListeFonction())
            {
                ListeFonction.Items.Add(f.Intitule);
            }
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            string prenom = PrenomTb.Text;
            string nom = NomTb.Text;
            int service = ListeService.SelectedIndex;
            int fonction = ListeFonction.SelectedIndex;
            string telephone = TelephoneTb.Text;

            try
            {
                bddpersonnels.InsertPersonnel(prenom, nom, service, fonction, telephone);

            }
            catch
            {
                MessageBox.Show("Bouh");
            }

            this.Close();

        }
    }
}
