namespace dcoffice
{
    partial class endowmentreports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aenDataSet2 = new dcoffice.aenDataSet2();
            this.endowmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endowmentTableAdapter = new dcoffice.aenDataSet2TableAdapters.endowmentTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gDataSet2 = new dcoffice.gDataSet2();
            this.grants1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grants1TableAdapter = new dcoffice.gDataSet2TableAdapters.grants1TableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endowmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grants1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1332, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1324, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Endownment detials";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1324, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grant details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "aenDataSet2_endowment";
            reportDataSource1.Value = this.endowmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dcoffice.endownmentreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1290, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // aenDataSet2
            // 
            this.aenDataSet2.DataSetName = "aenDataSet2";
            this.aenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // endowmentBindingSource
            // 
            this.endowmentBindingSource.DataMember = "endowment";
            this.endowmentBindingSource.DataSource = this.aenDataSet2;
            // 
            // endowmentTableAdapter
            // 
            this.endowmentTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "gDataSet2_grants1";
            reportDataSource2.Value = this.grants1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "dcoffice.grantsreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1298, 250);
            this.reportViewer2.TabIndex = 0;
            // 
            // gDataSet2
            // 
            this.gDataSet2.DataSetName = "gDataSet2";
            this.gDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grants1BindingSource
            // 
            this.grants1BindingSource.DataMember = "grants1";
            this.grants1BindingSource.DataSource = this.gDataSet2;
            // 
            // grants1TableAdapter
            // 
            this.grants1TableAdapter.ClearBeforeFill = true;
            // 
            // endowmentreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 642);
            this.Controls.Add(this.tabControl1);
            this.Name = "endowmentreports";
            this.Text = "endowmentreports";
            this.Load += new System.EventHandler(this.endowmentreports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endowmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grants1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource endowmentBindingSource;
        private aenDataSet2 aenDataSet2;
        private dcoffice.aenDataSet2TableAdapters.endowmentTableAdapter endowmentTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource grants1BindingSource;
        private gDataSet2 gDataSet2;
        private dcoffice.gDataSet2TableAdapters.grants1TableAdapter grants1TableAdapter;
    }
}