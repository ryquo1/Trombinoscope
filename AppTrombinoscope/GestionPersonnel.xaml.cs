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
        private bddpersonnels bdd;
        public GestionPersonnel()
        {
            InitializeComponent();
            bdd = new bddpersonnels(
                    Properties.Settings.Default.AdresseIP,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.MotDePasse);

            foreach (Personnel p in bdd.ListePersonnel())
            {
                ListePersonnel.Items.Add(p.Nom);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
