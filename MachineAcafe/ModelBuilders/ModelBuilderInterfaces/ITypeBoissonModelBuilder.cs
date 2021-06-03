using MachineAcafe.Services;
using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.ModelBuilders.ModelBuilderInterfaces
{
    public interface ITypeBoissonModelBuilder 
    {
        List<TypeBoissonViewModel> getAll();
    }
}