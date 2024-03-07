using System;
using System.Collections.Generic;
using System.IO;
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
            bdd = new BddpersonnelDataContext("User Id=" + user + ";Password=" + password + ";Host=" + host + ";Port=" + port + ";Database=bddpersonnels;Persist Security Info=True");
        }

        public void TestBDD()
        {
            try
            {
                bdd.DatabaseExists();
            }
            catch
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

        public void InsertPersonnel(string prenom, string nom, int service, int fonction, string telephone)
        {
            Personnel personne = new Personnel
            {
                Prenom = prenom,
                Nom = nom,
                IdService = service + 1,
                IdFonction = fonction + 1,
                Telephone = telephone,
                Photo = null
            };

            try
            {
                bdd.Personnels.InsertOnSubmit(personne);
                bdd.SubmitChanges();
            }
            catch
            {
                throw;
            }
        }
        public void InsertService(string intutile)
        {
            Service service = new Service
            {
                Intitule = intutile
            };

            try
            {
                bdd.Services.InsertOnSubmit(service);
                bdd.SubmitChanges();
            }
            catch
            {
                throw;
            }
        }
        
        public void InsertFonction(string intutile)
        {
            Fonction fonction = new Fonction
            {
                Intitule = intutile
            };

            try
            {
                bdd.Fonctions.InsertOnSubmit(fonction);
                bdd.SubmitChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
