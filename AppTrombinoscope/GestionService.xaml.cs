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
        bddpersonnels bddpersonnels;
        public GestionService(bddpersonnels bdd)
        {
            bddpersonnels = bdd;
            InitializeComponent();

            foreach (Service s in bdd.ListServices())
            {
                ListeService.Items.Add(s.Intitule);
            }
        }

        private void AjouterBt_Click(object sender, RoutedEventArgs e)
        {
            string intitule = ServiceAddNameTb.Text;
            ServiceAddNameTb.Text = "";

            bddpersonnels.InsertService(intitule);
        }
    }
}
