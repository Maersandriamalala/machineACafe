using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineAcafe.ModelBuilders.ModelBuilderInterfaces
{
    public interface IUtilisateurModelBuilder
    {

         UtilisateurViewModel getUtilisateurByIdentifiant(string identifiant);
    }
}
