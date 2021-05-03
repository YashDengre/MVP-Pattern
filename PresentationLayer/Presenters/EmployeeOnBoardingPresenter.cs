using PresentationLayer.Views;
using ServiceLayer.Services.EmployeeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    public class EmployeeOnBoardingPresenter
    {
        private IEmployeeOnboardingView _employeeOnboardingView;

        private IEmployeeServices _employeeServices;

        public EmployeeOnBoardingPresenter(IEmployeeOnboardingView employeeOnboardingView, IEmployeeServices employeeServices)
        {
            _employeeOnboardingView = employeeOnboardingView;
            _employeeServices = employeeServices;
            SubscribeToEventsSetup();
        }

        private void SubscribeToEventsSetup()
        {
        }

        public void OnEmployeeOnBaordingViewLoadEventRaised()
        {

        }
    }
}
