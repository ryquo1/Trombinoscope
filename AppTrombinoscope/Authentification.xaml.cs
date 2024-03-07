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
    /// Logique d'interaction pour Authentification.xaml
    /// </summary>
    public partial class Authentification : Window
    {
        public Authentification()
        {
            
            InitializeComponent();
            UserTextField.Text = Properties.Settings.Default.Login;
        }

        private void BtAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtConnexino_Click(object sender, RoutedEventArgs e)
        {
            String nom = UserTextField.Text;
            String DefaultLogin = Properties.Settings.Default.Login;
            String mdp = PasswordTextField.Password;
            String defaultMdp = Properties.Settings.Default.MotDePasseAppli;

            if (nom == DefaultLogin && mdp == defaultMdp)
            {
                this.Close();
                ((MainWindow)Application.Current.MainWindow).ListePersonnelItemMenu.IsEnabled = true;
                ((MainWindow)Application.Current.MainWindow).GestionFonctionItemMenu.IsEnabled = true;
                ((MainWindow)Application.Current.MainWindow).GestionPersonnelItemMenu.IsEnabled = true;
                ((MainWindow)Application.Current.MainWindow).GestionServiceItemMenu.IsEnabled = true;
                ((MainWindow)Application.Current.MainWindow).GestionnaireItemMenu.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Les identifiant ne sont pas bon");
                UserTextField.Text = "";
                PasswordTextField.Password = "";
            }
        }
    }
}
