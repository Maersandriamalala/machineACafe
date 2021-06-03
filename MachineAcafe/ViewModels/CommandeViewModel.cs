using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.ViewModels
{
    public class CommandeViewModel
    {

    
        public string NomUtilisateur { get; set; }
        public  string PrenomUtilisateur { get; set; }
        public  bool WithMug { get; set; }
        public  int Sugar { get; set; }
        public int IdBoisson { get; set; }
    }
}