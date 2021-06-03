using MachineAcafe.Services;
using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.ModelBuilders.ModelBuilderInterfaces
{
    public interface IcommandeModelBuilder
    {
     
        bool sendOrder(int IdBoisson, string identifiantPersonne, bool mug, int SugarRange);

        CommandeViewModel getHistory(int IdUtilisateur);

    }
}