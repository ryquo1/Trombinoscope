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
        public ListePersonnel(bddpersonnels bdd)
        {
            InitializeComponent();

            foreach (Personnel p in bdd.ListePersonnel())
            {
                dataList.Items.Add(new MyItem { ID = p.Id.ToString(), Name = p.Nom, Prenom = p.Prenom, Photo = null, Service = p.Service.Intitule, Fonction = p.Fonction.Intitule, Téléphone = p.Telephone });
            }
        }

    }
}
