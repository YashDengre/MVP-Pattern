using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Common
{
    public static class FormHelper
    {
        static public void SetDialogAppearance(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.BackColor = System.Drawing.Color.White;
            form.Icon = PresentationLayer.Properties.Resources.MVPDemo768Main;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
        }

        static public void SetFormAppearance(Form form)
        {
            SetDialogAppearance(form);
            form.MinimizeBox = true;
        }
    }
}
