using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;

namespace DllbddPersonnels
{
    public class bddpersonnels
    {
        private BddpersonnelDataContext bdd;

        public bddpersonnels(string host, string port, string user, string password)
        {
            bdd = new BddpersonnelDataContext("User Id="+user+";Password="+password+";Host="+host+";Port="+port+";Database=bddpersonnels;Persist Security Info=True");
        }

        public void TestBDD()
        {
            try
            {
                bdd.DatabaseExists();
            } catch
            {
                throw;
            }
        } 

        public List<BddpersonnelContext.Service> ListServices()
        {
            try
            {
                return bdd.Services.ToList();
            }
            catch
            {
                throw;
            }
        }


        public List<BddpersonnelContext.Fonction> ListeFonction()
        {
            try
            {
                return bdd.Fonctions.ToList();
            }
            catch
            {
                throw;
            }
        }


        public List<BddpersonnelContext.Personnel> ListePersonnel()
        {
            try
            {
                return bdd.Personnels.ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
