using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.ViewModels
{
    public class TypeBoissonViewModel
    {
        public TypeBoissonViewModel()
        {
           
        }

        public int Id { get; set; }
        public string libelle { get; set; }
        public string description { get; set; }

    }
}