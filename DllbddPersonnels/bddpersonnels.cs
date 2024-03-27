using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        public ObservableCollection<BddpersonnelContext.Service> ListeServices()
        {
            ObservableCollection<BddpersonnelContext.Service> collection = new ObservableCollection<Service>();
            try
            {
                foreach (BddpersonnelContext.Service s in bdd.Services.ToList())
                {
                    collection.Add(s);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }


        public ObservableCollection<BddpersonnelContext.Fonction> ListeFonctions()
        {
            ObservableCollection<BddpersonnelContext.Fonction> collection = new ObservableCollection<Fonction>();
            try
            {
                foreach (BddpersonnelContext.Fonction f in bdd.Fonctions.ToList())
                {
                    collection.Add(f);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }


        public ObservableCollection<BddpersonnelContext.Personnel> ListePersonnel()
        {
            ObservableCollection<BddpersonnelContext.Personnel> collection = new ObservableCollection<Personnel>();
            try
            {
                foreach (BddpersonnelContext.Personnel p in bdd.Personnels.ToList())
                {
                    collection.Add(p);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }


        public ObservableCollection<dynamic> AllListePersonnel()
        {

            try
            {
                ObservableCollection<dynamic> collection = new ObservableCollection<dynamic>();
                var requete = from personnel in bdd.Personnels
                              join fonction in bdd.Fonctions on personnel.IdFonction equals fonction.Id
                              join service in bdd.Services on personnel.IdService equals service.Id
                              select new { personnel.Id, personnel.Nom, personnel.Prenom, personnel.Photo, IntituleService = service.Intitule, IntituleFonction = fonction.Intitule, personnel.Telephone };

                foreach (var re in requete)
                {
                    collection.Add(re);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }


        public ObservableCollection<dynamic> FilterPersonneNom(string text)
        {
            try
            {
                ObservableCollection<dynamic> collection = new ObservableCollection<dynamic>();
                var requete = from personnel in bdd.Personnels
                              join fonction in bdd.Fonctions on personnel.IdFonction equals fonction.Id
                              join service in bdd.Services on personnel.IdService equals service.Id
                              where (personnel.Nom.StartsWith(text))
                              select new { personnel.Id, personnel.Nom, personnel.Prenom, personnel.Photo, IntituleService = service.Intitule, IntituleFonction = fonction.Intitule, personnel.Telephone };

                foreach (var re in requete)
                {
                    collection.Add(re);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }

        public ObservableCollection<dynamic> FilterPersonnePrenom(string text)
        {
            try
            {
                ObservableCollection<dynamic> collection = new ObservableCollection<dynamic>();
                var requete = from personnel in bdd.Personnels
                              join fonction in bdd.Fonctions on personnel.IdFonction equals fonction.Id
                              join service in bdd.Services on personnel.IdService equals service.Id
                              where (personnel.Prenom.StartsWith(text))
                              select new { personnel.Id, personnel.Nom, personnel.Prenom, personnel.Photo, IntituleService = service.Intitule, IntituleFonction = fonction.Intitule, personnel.Telephone };

                foreach (var re in requete)
                {
                    collection.Add(re);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }

        public ObservableCollection<dynamic> FilterService(string text)
        {
            try
            {
                ObservableCollection<dynamic> collection = new ObservableCollection<dynamic>();
                var requete = from personnel in bdd.Personnels
                              join fonction in bdd.Fonctions on personnel.IdFonction equals fonction.Id
                              join service in bdd.Services on personnel.IdService equals service.Id
                              where (personnel.Service.Intitule.StartsWith(text))
                              select new { personnel.Id, personnel.Nom, personnel.Prenom, personnel.Photo, IntituleService = service.Intitule, IntituleFonction = fonction.Intitule, personnel.Telephone };

                foreach (var re in requete)
                {
                    collection.Add(re);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }

        public ObservableCollection<dynamic> FilterFonction(string text)
        {
            try
            {
                ObservableCollection<dynamic> collection = new ObservableCollection<dynamic>();
                var requete = from personnel in bdd.Personnels
                              join fonction in bdd.Fonctions on personnel.IdFonction equals fonction.Id
                              join service in bdd.Services on personnel.IdService equals service.Id
                              where (personnel.Fonction.Intitule.StartsWith(text))
                              select new { personnel.Id, personnel.Nom, personnel.Prenom, personnel.Photo, IntituleService = service.Intitule, IntituleFonction = fonction.Intitule, personnel.Telephone };

                foreach (var re in requete)
                {
                    collection.Add(re);
                }
                return collection;
            }
            catch
            {
                throw;
            }
        }


        public void InsertPersonnel(string prenom, string nom, int service, int fonction, string telephone, byte[] photo)
        {
            Personnel personne = new Personnel
            {
                Prenom = prenom,
                Nom = nom,
                IdService = service + 1,
                IdFonction = fonction + 1,
                Telephone = telephone,
                Photo = photo,
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


        public void DeleteFonction(Fonction fonction)
        {
            bdd.Fonctions.DeleteOnSubmit(fonction);
            bdd.SubmitChanges();
        }


        public void DeleteService(Service service)
        {
            bdd.Services.DeleteOnSubmit(service);
            bdd.SubmitChanges();
        }

    }
}
