using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Riganti.CMS.BL.Facades;
using Riganti.Utils.Infrastructure.AutoMapper;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFrameworkCore;
using Riganti.Utils.Infrastructure.Services.Facades;
using Rigatni.CMS.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Riganti.CMS.BL.Installers
{
    public class DataAccessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                Component.For<Func<DbContext>>()
                    .Instance(() => new CmsDbContext())
                    .LifestyleSingleton(),

                Component.For<IUnitOfWorkProvider>()
                    .ImplementedBy<EntityFrameworkUnitOfWorkProvider>()
                    .LifestyleSingleton(),

                Component.For(typeof(IRepository<,>))
                    .ImplementedBy(typeof(EntityFrameworkRepository<,>))
                    .IsFallback()
                    .LifestyleTransient(),

                Component.For(typeof(IEntityDTOMapper<,>))
                    .ImplementedBy(typeof(EntityDTOMapper<,>))
                    .LifestyleSingleton(),
                Component.For<IDateTimeProvider>()
                    .ImplementedBy<LocalDateTimeProvider>()
                    .LifestyleTransient(),

                Classes.FromAssemblyContaining<AppFacadeBase>()
                    .BasedOn<AppFacadeBase>()
                    .LifestyleTransient(),

                 Classes.FromAssemblyContaining<AppFacadeBase>()
                    .BasedOn(typeof(AppCrudFacadeBase<,,,,>))
                    .LifestyleTransient(),

                 Classes.FromAssemblyContaining<AppFacadeBase>()
                    .BasedOn(typeof(IQuery<,>))
                    .LifestyleTransient(),

                 Classes.FromAssemblyContaining<AppFacadeBase>()
                    .BasedOn(typeof(IQuery<>))
                    .LifestyleTransient(),
                Classes.FromAssemblyContaining<AppFacadeBase>()
                    .BasedOn(typeof(AppCrudFacadeBase<,,,>))
                    .LifestyleTransient()



                );
        }
    }
}
