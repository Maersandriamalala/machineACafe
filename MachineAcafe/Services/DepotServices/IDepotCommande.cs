using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineAcafe.Services.DepotServices
{
    public interface IDepotCommande
    {
       bool sendOrder(int IdBoisson, string identifiantPersonne, bool mug, int SugarRange);
       Commande getHistory(int IdUtilisateur);
    }
}
