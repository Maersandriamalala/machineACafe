using MachineAcafe.ModelBuilders.ModelBuilderInterfaces;
using MachineAcafe.Services;
using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineAcafe.ModelBuilders
{
    public class CommandeModelBuilder : IcommandeModelBuilder
    {
        private IDepots _IServices { get; }

        public CommandeModelBuilder(IDepots depotFatory)
        {
            _IServices = depotFatory;
        }
        public bool sendOrder(int IdBoisson, string identifiantPersonne, bool mug, int SugarRange)
        {
            return _IServices.Commande.sendOrder(IdBoisson, identifiantPersonne, mug, SugarRange);
        }

        public CommandeViewModel getHistory(int IdUtilisateur)
        {
            CommandeViewModel commandeViewModel = new CommandeViewModel();
            Commande cmd = _IServices.Commande.getHistory(IdUtilisateur);
            commandeViewModel.NomUtilisateur = cmd.Utilisateur.Nom;
            commandeViewModel.PrenomUtilisateur = cmd.Utilisateur.Prenom;
            commandeViewModel.IdBoisson = cmd.TypeBoisson.Id;
            commandeViewModel.WithMug = cmd.IsWithMug;
            commandeViewModel.Sugar = cmd.Sucre;
            return commandeViewModel;
        }
    }
}