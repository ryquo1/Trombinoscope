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
    /// Logique d'interaction pour ListePersonnel.xaml
    /// </summary>
    public partial class ListePersonnel : Window
    {
        bddpersonnels bddPersonnel;
        public ListePersonnel(bddpersonnels bdd)
        {
            bddPersonnel = bdd;
            InitializeComponent();
            dataList.DataContext = bdd.AllListePersonnel();
        }


        private void BoxNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mot = BoxNom.Text;
            dataList.DataContext = bddPersonnel.FilterPersonneNom(mot);
        }

        private void BoxPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mot = BoxPrenom.Text;
            dataList.DataContext = bddPersonnel.FilterPersonnePrenom(mot);
        }


        private void BoxService_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mot = BoxService.Text;
            dataList.DataContext = bddPersonnel.FilterService(mot);
        }

        private void BoxFonction_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mot = BoxFonction.Text;
            dataList.DataContext = bddPersonnel.FilterFonction(mot);
        }
    }
}
