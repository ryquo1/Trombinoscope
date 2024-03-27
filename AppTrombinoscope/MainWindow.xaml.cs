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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BddpersonnelContext;
using DllbddPersonnels;

namespace AppTrombinoscope
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bddpersonnels bdd;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ParametreBDDItemMenu_Click(object sender, RoutedEventArgs e)
        {
            ParamètreBDD paramètreBDD = new ParamètreBDD();
            paramètreBDD.ShowDialog();
        }

        private void ConnexionBDDItemMenu_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                 bdd = new bddpersonnels(
                    Properties.Settings.Default.AdresseIP, 
                    Properties.Settings.Default.Port, 
                    Properties.Settings.Default.Utilisateur, 
                    Properties.Settings.Default.MotDePasse);

                this.Title = "Trombinoscope Connecter";

                ServiceView.DataContext = bdd.ListeServices();

                FonctionView.DataContext = bdd.ListeFonctions();

                MembresView.DataContext = bdd.ListePersonnel();

                ((MainWindow)Application.Current.MainWindow).ListePersonnelItemMenu.IsEnabled = true;
            }
            catch
            {
                this.Title = "Trombinoscope non Connecter";
                MessageBox.Show("Vous avez une erreur de connexion");
            }


        }
        private void GestionnaireItemMenu_Click(object sender, RoutedEventArgs e)
        {
            Authentification authentification = new Authentification();
            authentification.ShowDialog();
        }

        private void ListePersonnelItemMenu_Click(object sender, RoutedEventArgs e)
        {
            ListePersonnel listePersonnel = new ListePersonnel(bdd);
            listePersonnel.ShowDialog();
        }

        private void GestionPersonnelItemMenu_Click(object sender, RoutedEventArgs e)
        {
            GestionPersonnel gestionPersonnel = new GestionPersonnel(bdd);
            gestionPersonnel.ShowDialog();
        }

        private void GestionFonctionItemMenu_Click(object sender, RoutedEventArgs e)
        {
            GestionFonction gestionFonction = new GestionFonction(bdd);
            gestionFonction.ShowDialog();
        }

        private void GestionServiceItemMenu_Click(object sender, RoutedEventArgs e)
        {
            GestionService gestionService = new GestionService(bdd);
            gestionService.ShowDialog();
        }
        

        public void AllUpdate()
        {
            MembresView.DataContext = bdd.ListePersonnel();
            FonctionView.DataContext = bdd.ListeFonctions();
            ServiceView.DataContext = bdd.ListeServices();
        }
    }
}
