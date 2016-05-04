namespace dcoffice
{
    partial class budgetreport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(budgetreport));
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget1DataSet2 = new dcoffice.budget1DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.budgetTableAdapter = new dcoffice.budget1DataSet2TableAdapters.budgetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "budget";
            this.budgetBindingSource.DataSource = this.budget1DataSet2;
            // 
            // budget1DataSet2
            // 
            this.budget1DataSet2.DataSetName = "budget1DataSet2";
            this.budget1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "budget1DataSet2_budget";
            reportDataSource1.Value = this.budgetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dcoffice.budgetreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1304, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // budgetreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 642);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "budgetreport";
            this.Text = "Automation of District Commissioner Office";
            this.Load += new System.EventHandler(this.budgetreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private budget1DataSet2 budget1DataSet2;
        private dcoffice.budget1DataSet2TableAdapters.budgetTableAdapter budgetTableAdapter;
    }
}