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
        public GestionPersonnel(bddpersonnels bdd)
        {
            InitializeComponent();

            foreach(Service s in bdd.ListServices())
            {
                ListeService.Items.Add(s.Intitule);
            }

            foreach(Fonction f in bdd.ListeFonction())
            {
                ListeFonction.Items.Add(f.Intitule);
            }

        }
    }
}
