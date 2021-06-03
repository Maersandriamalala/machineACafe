using MachineAcafe.Services.DepotServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.Depot
{
    public class TypeBoissonDepot : IDepotTypeBoisson
    {
        public List<TypeBoisson> getAll()
        {

            using (var db = new MachineCafeEntities())
            {
                return db.TypeBoisson.ToList();
            }
              
        }
    }
}