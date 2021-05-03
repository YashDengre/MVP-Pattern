using DomainLayer.Models.Department;
using InfrastructureLayer.DataAccess.Repositories.Specific.Department;
using InfrastructureLayer.DataAccess.Repositories.Specific.Employee;
using PresentationLayer.Presenters;
using PresentationLayer.Presenters.UserControls;
using PresentationLayer.Views;
using PresentationLayer.Views.UserControls;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.DepartmentServices;
using ServiceLayer.Services.EmployeeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            IUnityContainer UnityC;
            string _connectionString = "Data Source=" +
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\MVPAppiDemo-UnitTest\MVPDemo.sqlite;Version = 3;";

            UnityC = new UnityContainer()
                .RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IErrorMessageView, ErrorMessageView>(new ContainerControlledLifetimeManager())
                .RegisterType<IHelpAboutPresenter, HelpAboutPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IHelpAboutView, HelpAboutView>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
          .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
          //.RegisterType<INewsViewUC, NewsViewUC>(new ContainerControlledLifetimeManager())
          //.RegisterType<INewsPresenter, NewsPresenter>(new ContainerControlledLifetimeManager())
          //.RegisterType<IPlantListViewUC, PlantListViewUC>(new ContainerControlledLifetimeManager())
          //.RegisterType<IPlantListPresenter, PlantListPresenter>(new ContainerControlledLifetimeManager())
          //.RegisterType<IPlantServices, PlantServces>(new ContainerControlledLifetimeManager())
          //.RegisterType<IPlantRepository, PlantRepository>(new InjectionConstructor(_connectionString))
          .RegisterType<IDepartmentListViewUC, DepartmentListViewUC>(new ContainerControlledLifetimeManager())
          .RegisterType<IDepartmentListPresenter, DepartmentListPresenter>(new ContainerControlledLifetimeManager())
          .RegisterType<IEmployeeListViewUC, EmployeeListViewUC>(new ContainerControlledLifetimeManager())
          .RegisterType<IEmployeeListPresenter, EmployeeListPresenter>(new ContainerControlledLifetimeManager())
          //.RegisterType<IDepartmentListDeleteView, DepartmentListDeleteView>(new ContainerControlledLifetimeManager())
          //.RegisterType<IAccessTypeEventArgs, AccessTypeEventArgs>(new ContainerControlledLifetimeManager())
          .RegisterType<IDepartmentModel, DepartmentModel>(new ContainerControlledLifetimeManager())
          //.RegisterType<IDepartmentDetailPresenter, DepartmentDetailPresenter>(new ContainerControlledLifetimeManager())
          //.RegisterType<IDepartmentDetailViewUC, DepartmentDetailViewUC>(new ContainerControlledLifetimeManager())
          .RegisterType<IErrorMessageView, ErrorMessageView>(new ContainerControlledLifetimeManager())
          .RegisterType<IDepartmentRepository, DepartmentRepository>(new InjectionConstructor(_connectionString))
          .RegisterType<IEmployeeRepository, EmployeeRepository>(new InjectionConstructor(_connectionString))
          .RegisterType<IDepartmentService, DepartmentServices>(new ContainerControlledLifetimeManager())
          .RegisterType<IEmployeeServices, EmployeeServices>(new ContainerControlledLifetimeManager())
          .RegisterType<IModelDataAnnotationCheck, ModelDataAnnotationCheck>(new ContainerControlledLifetimeManager());
            //.RegisterType<IErrorMessageView, ErrorMessageView>(new ContainerControlledLifetimeManager())
            //BasePresenter : IBasePresenter

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter mainPresenter = UnityC.Resolve<MainPresenter>();
            IMainView mainView = mainPresenter.GetMainView();

            //Application.Run(new MainView());
            Application.Run((MainView)mainView);

        }
    }
}
