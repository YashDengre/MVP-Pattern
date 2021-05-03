using CommonComponents;
using PresentationLayer.Common;
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
    public partial class HelpAboutView : Form, IHelpAboutView
    {
        public event EventHandler HelpAboutViewLoadEventRaised;

        public HelpAboutView()
        {
            InitializeComponent();
        }

        public void SetAboutValues(string windowTitle,
                                  string productName,
                                  string version,
                                  string copyright,
                                  string companyName,
                                  string description)
        {
            this.Text = windowTitle;
            this.productLabel.Text = productName;
            this.versionLabel.Text = version;
            this.copyrightLabel.Text = copyright;
            this.companyLabel.Text = companyName;
            this.descriptionLabel.Text = description;
        }

        private void HelpAbouView_Load(object sender, EventArgs e)
        {
            FormHelper.SetDialogAppearance(this);

            EventHelpers.RaiseEvent(this, HelpAboutViewLoadEventRaised, e);
        }

        public void ShowHelpAboutView()
        {
            this.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
