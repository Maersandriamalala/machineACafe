using AutoMapper;
using MachineAcafe.ModelBuilders.ModelBuilderInterfaces;
using MachineAcafe.Services;
using MachineAcafe.ViewModels;

using System.Linq;


namespace MachineAcafe.ModelBuilders
{
    public class UtilisateurModelBuilder : IUtilisateurModelBuilder
    {
        private IDepots _IServices { get; }
      
        public UtilisateurModelBuilder(IDepots depotFatory)
        {
            _IServices = depotFatory;
        }
        public UtilisateurViewModel getUtilisateurByIdentifiant(string identifiant)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Utilisateur, UtilisateurViewModel>();
            });
            IMapper iMapper = config.CreateMapper();

            return iMapper.Map<Utilisateur, UtilisateurViewModel> ( _IServices.Utilisateur.getUtilisateurByIdentifiant(identifiant));
        }
    }
}