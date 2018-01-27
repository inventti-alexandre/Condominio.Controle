[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Condominio.Controle.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Condominio.Controle.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Condominio.Controle.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Application.App;
    using Application.Interfaces;
    using Domain.Interfaces.Services;
    using Domain.Services;
    using Domain.Interfaces.Repositories;
    using Infra.Data.Repositories;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {

            ////////////// APPLICATION SERVICES  //////////////////////////////////////////////////
            kernel.Bind(typeof(IRepositoryAppService<>)).To(typeof(RepositoryAppService<>));
            kernel.Bind<IApartamentoAppService>().To<ApartamentoAppService>();
            kernel.Bind<IBlocoAppService>().To<BlocoAppService>();
            kernel.Bind<IMarcaAppService>().To<MarcaAppService>();
            kernel.Bind<IModeloAppService>().To<ModeloAppService>();
            kernel.Bind<IProprietarioAppService>().To<ProprietarioAppService>();
            kernel.Bind<IUsuarioAppService>().To<UsuarioAppService>();
            kernel.Bind<IVeiculoAppService>().To<VeiculoAppService>();

            ////////////// SERVICES  //////////////////////////////////////////////////
            kernel.Bind(typeof(IRepositoryService<>)).To(typeof(RepositoryService<>));
            kernel.Bind<IApartamentoService>().To<ApartamentoService>();
            kernel.Bind<IBlocoService>().To<BlocoService>();
            kernel.Bind<IMarcaService>().To<MarcaService>();
            kernel.Bind<IModeloService>().To<ModeloService>();
            kernel.Bind<IProprietarioService>().To<ProprietarioService>();
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<IVeiculoService>().To<VeiculoService>();

            ////////////// REPOSITORIES  //////////////////////////////////////////////////
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IApartamentoRepository>().To<ApartamentoRepository>();
            kernel.Bind<IBlocoRepository>().To<BlocoRepository>();
            kernel.Bind<IMarcaRepository>().To<MarcaRepository>();
            kernel.Bind<IModeloRepository>().To<ModeloRepository>();
            kernel.Bind<IProprietarioRepository>().To<ProprietarioRepository>();
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
            kernel.Bind<IVeiculoRepository>().To<VeiculoRepository>();

        }
    }
}
