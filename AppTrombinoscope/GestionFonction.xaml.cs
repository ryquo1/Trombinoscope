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
        private bddpersonnels bdd;
        public GestionFonction()
        {
            InitializeComponent();
            bdd = new bddpersonnels(
                    Properties.Settings.Default.AdresseIP,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.MotDePasse);

            foreach (Fonction f in bdd.ListeFonction())
            {
                ListeFonction.Items.Add(f.Intitule);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
