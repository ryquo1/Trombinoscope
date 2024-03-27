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

            ListeFonction.DataContext = bdd.ListeFonctions();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string intitule = NomFonctionText.Text;
            NomFonctionText.Text = "";

            if (!intitule.Equals(""))
            {
                bddPersonnels.InsertFonction(intitule);
                updateList(bddPersonnels);
                ((MainWindow)Application.Current.MainWindow).AllUpdate();
            }
        }


        private void updateList(bddpersonnels bdd)
        {
            ListeFonction.DataContext = bdd.ListeFonctions();
        }

        private void SupprimerContextMenu_Click(object sender, RoutedEventArgs e)
        {
            Fonction fonction = (Fonction)ListeFonction.SelectedItem;
            bddPersonnels.DeleteFonction(fonction);
            updateList(bddPersonnels);
        }

        private void modifierContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ALED");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
