
namespace PresentationLayer.Views.UserControls
{
    partial class EmployeeListViewUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empListGridView
            // 
            this.empListGridView.ColumnHeadersHeight = 29;
            this.empListGridView.Location = new System.Drawing.Point(0, 0);
            this.empListGridView.Name = "empListGridView";
            this.empListGridView.RowHeadersWidth = 51;
            this.empListGridView.RowTemplate.Height = 24;
            this.empListGridView.Size = new System.Drawing.Size(597, 375);
            this.empListGridView.TabIndex = 0;
            // 
            // EmployeeListViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.empListGridView);
            this.Name = "EmployeeListViewUC";
            this.Size = new System.Drawing.Size(600, 378);
            this.Load += new System.EventHandler(this.EmployeeListViewUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empListGridView;
    }
}
