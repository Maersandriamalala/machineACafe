using MachineAcafe.Services.DepotServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.Depot
{
    public class UtilisateurDepot : IDepotUtilisateur
    {
        public Utilisateur getUtilisateurByIdentifiant(string identifiant)
        {
            using (var db = new MachineCafeEntities())
            {
                return db.Utilisateur.Where(u=>u.Identifiant==identifiant).FirstOrDefault();
            }
        }
    }
}