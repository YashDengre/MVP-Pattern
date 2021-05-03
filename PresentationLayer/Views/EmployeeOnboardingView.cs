using CommonComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class EmployeeOnboardingView : Form, IEmployeeOnboardingView
    {
        public event EventHandler EmployeeOnBoardingViewLoadEventRaised;
        public EmployeeOnboardingView()
        {
            InitializeComponent();
        }

        private void EmployeeOnboardingView_Load(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, EmployeeOnBoardingViewLoadEventRaised, e);
        }
    }
}
