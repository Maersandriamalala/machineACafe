using MachineAcafe.ModelBuilders;
using MachineAcafe.ModelBuilders.ModelBuilderInterfaces;
using MachineAcafe.Services;
using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace MachineAcafe.Controllers
{
    public class HomeController : Controller
    {
        private ITypeBoissonModelBuilder _typeBoissonModelBuilder;
        private IUtilisateurModelBuilder _utilisateurModelBuilder;

        private IcommandeModelBuilder _commandeModelBuilder;


        public HomeController(ITypeBoissonModelBuilder typeBoissonModelBuilder, IUtilisateurModelBuilder utilisateurModelBuilder, IcommandeModelBuilder commandeModelBuilder)
        {
            _typeBoissonModelBuilder = typeBoissonModelBuilder;
            _utilisateurModelBuilder = utilisateurModelBuilder;
            _commandeModelBuilder = commandeModelBuilder;
        }
        public ActionResult Index()
        {
            
         
            AcceuilViewModel acceuilViewModel = new AcceuilViewModel();
            List<TypeBoissonViewModel> typeBoissons = _typeBoissonModelBuilder.getAll();
            acceuilViewModel.TypeBoissonViewModels = typeBoissons;
            acceuilViewModel.commandeViewModel=TempData["Choice"]!=null?(CommandeViewModel)TempData["Choice"]:null;
            return View(acceuilViewModel);
        }

        [HttpPost]
        public ActionResult GetOrder(string identifiantPersonne, int SugarRange, int IdBoisson = 0, bool mug = false)
        {

            var utilisateur = _utilisateurModelBuilder.getUtilisateurByIdentifiant(identifiantPersonne);
           //Get choice
            if(utilisateur!=null && IdBoisson == 0)
            {
                TempData["Choice"] = _commandeModelBuilder.getHistory(utilisateur.Id);
                return RedirectToAction("Index");

            }
            if (IdBoisson == 0)
            {

                TempData["Error"] = "Veuillez selectionner une boisson!";
                return RedirectToAction("Index");
            }

            _commandeModelBuilder.sendOrder(IdBoisson, identifiantPersonne, mug, SugarRange);
            TempData["Success"] = "Merci et au revoir :)";
            return RedirectToAction("Index");
        }

      
    }
}