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
    public partial class GestionService : Window
    {
        bddpersonnels bddPersonnels;
        public GestionService(bddpersonnels bdd)
        {
            bddPersonnels = bdd;
            InitializeComponent();
            ListeService.DataContext = bdd.ListeServices();

        }

        private void AjouterBt_Click(object sender, RoutedEventArgs e)
        {
            string intitule = ServiceAddNameTb.Text;
            ServiceAddNameTb.Text = "";

            if (!intitule.Equals(""))
            {
                bddPersonnels.InsertService(intitule);
                updateList(bddPersonnels);
            }
            
        }

        private void updateList(bddpersonnels bdd)
        {
            ListeService.DataContext = bdd.ListeServices();
        }

        private void SupprimerContextMenu_Click(object sender, RoutedEventArgs e)
        {
            Service service = (Service)ListeService.SelectedItem;
            bddPersonnels.DeleteService(service);
            updateList(bddPersonnels);
        }

        private void modifierContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ALED");
        }

        private void QuitterBt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
