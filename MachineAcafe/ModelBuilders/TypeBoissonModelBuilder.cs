using AutoMapper;
using MachineAcafe.ModelBuilders.ModelBuilderInterfaces;
using MachineAcafe.Services;
using MachineAcafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace MachineAcafe.ModelBuilders
{
    public class TypeBoissonModelBuilder : ITypeBoissonModelBuilder
    {
        private IDepots _IServices { get;  }
        [InjectionConstructor]
        public TypeBoissonModelBuilder(IDepots depotFatory) 
        {
            _IServices = depotFatory;
        }

        public List<TypeBoissonViewModel> getAll()
        {
       
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<TypeBoisson, TypeBoissonViewModel>();
                });
                IMapper iMapper = config.CreateMapper();
                return iMapper.Map<List<TypeBoisson>,List<TypeBoissonViewModel>>(_IServices.TypeBoisson.getAll());
      

        
        }
    }
}