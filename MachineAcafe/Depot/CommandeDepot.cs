using MachineAcafe.Services.DepotServices;
using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.Depot
{
    public class CommandeDepot : IDepotCommande
    {
        public bool sendOrder(int IdBoisson, string identifiantPersonne, bool mug, int SugarRange)
        {
            using (var db = new MachineCafeEntities())
            {
                try
                {
                    Commande cmd = new Commande();
                    cmd.IsWithMug = mug;
                    cmd.TypeBoissonID = IdBoisson;
                    cmd.Sucre = SugarRange;
                    cmd.DateCommande = DateTime.Now;
                    Utilisateur user = db.Utilisateur.Where(x => x.Identifiant == identifiantPersonne).FirstOrDefault();
                    if (user == null)
                    {
                        user = db.Utilisateur.Where(x => x.Identifiant == "Anonyme").FirstOrDefault();
                    }
                    cmd.Utilisateur = user;
                    db.Commande.Add(cmd);
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    return false;
                }

                return true;
            }

        }

        public Commande getHistory(int IdUtilisateur)
        {
          
            using (var db = new MachineCafeEntities())
            {
              return  db.Commande.Include("Utilisateur").Include("TypeBoisson").Where(c => c.Utilisateur.Id == IdUtilisateur) .OrderByDescending(c=>c.DateCommande).FirstOrDefault();
            }

           
        }
    }
}