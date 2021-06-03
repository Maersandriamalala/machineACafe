using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.Services.DepotServices
{
    public interface IDepotUtilisateur
    {
        Utilisateur getUtilisateurByIdentifiant(string identifiant);
    }
}