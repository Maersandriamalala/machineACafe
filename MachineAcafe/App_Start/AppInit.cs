using MachineAcafe.ModelBuilders;
using MachineAcafe.ModelBuilders.ModelBuilderInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace MachineAcafe.App_Start
{
    public class AppInit
    {
        public static void Init()
        {
            InitDependencyResolution();
        }
        private static void InitDependencyResolution()
        {
           

        }
    }
}