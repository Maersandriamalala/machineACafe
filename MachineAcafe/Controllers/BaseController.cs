using MachineAcafe.ModelBuilders.ModelBuilderInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachineAcafe.Controllers
{
    public class BaseController
    {
        public readonly new  ITypeBoissonModelBuilder _typeBoissonModelBuilder;

        public BaseController(ITypeBoissonModelBuilder typeBoissonModelBuilder)
        {
            _typeBoissonModelBuilder = typeBoissonModelBuilder;
        }
        public ITypeBoissonModelBuilder returnBuilder()
        {
            return _typeBoissonModelBuilder;
        }
        public BaseController()
        {
           
        }
    }
}