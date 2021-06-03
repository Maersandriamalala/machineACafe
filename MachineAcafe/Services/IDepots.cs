using MachineAcafe.Services.DepotServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineAcafe.Services
{
    public interface IDepots
    {
        IDepotTypeBoisson TypeBoisson { get; }
        IDepotUtilisateur Utilisateur { get; }
        IDepotCommande Commande { get; }
    }
}
