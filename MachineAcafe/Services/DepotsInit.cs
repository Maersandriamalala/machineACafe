using MachineAcafe.Services.DepotServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.Services
{
    public class DepotsInit : IDepots
    {
        public IDepotTypeBoisson TypeBoisson { get; }
        public IDepotUtilisateur Utilisateur { get; }
        public IDepotCommande Commande { get; }
        public DepotsInit()
        {
            TypeBoisson = new Depot.TypeBoissonDepot();
            Utilisateur = new Depot.UtilisateurDepot();
            Commande = new Depot.CommandeDepot();
        }

    }
}