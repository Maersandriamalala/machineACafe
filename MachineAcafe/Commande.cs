//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MachineAcafe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        public int Id { get; set; }
        public int Sucre { get; set; }
        public bool IsWithMug { get; set; }
        public System.DateTime DateCommande { get; set; }
        public int UtilisateurID { get; set; }
        public int TypeBoissonID { get; set; }
    
        public virtual TypeBoisson TypeBoisson { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
