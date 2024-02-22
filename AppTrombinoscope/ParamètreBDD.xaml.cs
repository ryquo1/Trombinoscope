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

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour ParamètreBDD.xaml
    /// </summary>
    public partial class ParamètreBDD : Window
    {
        public ParamètreBDD()
        {
            InitializeComponent();
            AdresseIPTB.Text = Properties.Settings.Default.AdresseIP;
            PortTB.Text = Properties.Settings.Default.Port;
            UtilisateurTB.Text = Properties.Settings.Default.Utilisateur;
            MotDePasseTB.Text = Properties.Settings.Default.MotDePasse;
        }

        private void AnnulerBT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EnregistrerBT_Click(object sender, RoutedEventArgs e)
        {
            String adresseIPTB = AdresseIPTB.Text;
            Properties.Settings.Default.AdresseIP = adresseIPTB;

            String portTB = PortTB.Text;
            Properties.Settings.Default.Port = portTB;

            String utilisateurTB = UtilisateurTB.Text;
            Properties.Settings.Default.Utilisateur = utilisateurTB;

            String motDePasseTB = MotDePasseTB.Text;
            Properties.Settings.Default.MotDePasse = motDePasseTB;

            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
