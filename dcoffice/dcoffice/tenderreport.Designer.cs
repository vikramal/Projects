namespace dcoffice
{
    partial class tenderreport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tenderreport));
            this.tenderpublishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenderpublish1DataSet2 = new dcoffice.tenderpublish1DataSet2();
            this.tenderapplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenapplyautoDataSet2 = new dcoffice.tenapplyautoDataSet2();
            this.tenderrejectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenderrejDataSet2 = new dcoffice.tenderrejDataSet2();
            this.tenderapprovalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenderapprovalautoDataSet2 = new dcoffice.tenderapprovalautoDataSet2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tenderpublishTableAdapter = new dcoffice.tenderpublish1DataSet2TableAdapters.tenderpublishTableAdapter();
            this.tenderapplyTableAdapter = new dcoffice.tenapplyautoDataSet2TableAdapters.tenderapplyTableAdapter();
            this.tenderrejectTableAdapter = new dcoffice.tenderrejDataSet2TableAdapters.tenderrejectTableAdapter();
            this.tenderapprovalTableAdapter = new dcoffice.tenderapprovalautoDataSet2TableAdapters.tenderapprovalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tenderpublishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderpublish1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderapplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenapplyautoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderrejectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderrejDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderapprovalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderapprovalautoDataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenderpublishBindingSource
            // 
            this.tenderpublishBindingSource.DataMember = "tenderpublish";
            this.tenderpublishBindingSource.DataSource = this.tenderpublish1DataSet2;
            // 
            // tenderpublish1DataSet2
            // 
            this.tenderpublish1DataSet2.DataSetName = "tenderpublish1DataSet2";
            this.tenderpublish1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenderapplyBindingSource
            // 
            this.tenderapplyBindingSource.DataMember = "tenderapply";
            this.tenderapplyBindingSource.DataSource = this.tenapplyautoDataSet2;
            // 
            // tenapplyautoDataSet2
            // 
            this.tenapplyautoDataSet2.DataSetName = "tenapplyautoDataSet2";
            this.tenapplyautoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenderrejectBindingSource
            // 
            this.tenderrejectBindingSource.DataMember = "tenderreject";
            this.tenderrejectBindingSource.DataSource = this.tenderrejDataSet2;
            // 
            // tenderrejDataSet2
            // 
            this.tenderrejDataSet2.DataSetName = "tenderrejDataSet2";
            this.tenderrejDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenderapprovalBindingSource
            // 
            this.tenderapprovalBindingSource.DataMember = "tenderapproval";
            this.tenderapprovalBindingSource.DataSource = this.tenderapprovalautoDataSet2;
            // 
            // tenderapprovalautoDataSet2
            // 
            this.tenderapprovalautoDataSet2.DataSetName = "tenderapprovalautoDataSet2";
            this.tenderapprovalautoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1322, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1314, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tender Publish";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tenderpublish1DataSet2_tenderpublish";
            reportDataSource1.Value = this.tenderpublishBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dcoffice.tenderpublishreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1308, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tender Apply";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "tenapplyautoDataSet2_tenderapply";
            reportDataSource2.Value = this.tenderapplyBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "dcoffice.tenderapplyreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(963, 226);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(972, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tender Reject";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "tenderrejDataSet2_tenderreject";
            reportDataSource3.Value = this.tenderrejectBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "dcoffice.tenderrejectreport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(966, 250);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(972, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tender Approval";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "tenderapprovalautoDataSet2_tenderapproval";
            reportDataSource4.Value = this.tenderapprovalBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "dcoffice.tenderapprovalreport.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(966, 250);
            this.reportViewer4.TabIndex = 0;
            // 
            // tenderpublishTableAdapter
            // 
            this.tenderpublishTableAdapter.ClearBeforeFill = true;
            // 
            // tenderapplyTableAdapter
            // 
            this.tenderapplyTableAdapter.ClearBeforeFill = true;
            // 
            // tenderrejectTableAdapter
            // 
            this.tenderrejectTableAdapter.ClearBeforeFill = true;
            // 
            // tenderapprovalTableAdapter
            // 
            this.tenderapprovalTableAdapter.ClearBeforeFill = true;
            // 
            // tenderreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1316, 652);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tenderreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automation of District Commissinor Office";
            this.Load += new System.EventHandler(this.tenderreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenderpublishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderpublish1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderapplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenapplyautoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderrejectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderrejDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderapprovalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderapprovalautoDataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource tenderpublishBindingSource;
        private tenderpublish1DataSet2 tenderpublish1DataSet2;
        private dcoffice.tenderpublish1DataSet2TableAdapters.tenderpublishTableAdapter tenderpublishTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource tenderapplyBindingSource;
        private tenapplyautoDataSet2 tenapplyautoDataSet2;
        private dcoffice.tenapplyautoDataSet2TableAdapters.tenderapplyTableAdapter tenderapplyTableAdapter;
        private System.Windows.Forms.BindingSource tenderrejectBindingSource;
        private tenderrejDataSet2 tenderrejDataSet2;
        private dcoffice.tenderrejDataSet2TableAdapters.tenderrejectTableAdapter tenderrejectTableAdapter;
        private System.Windows.Forms.BindingSource tenderapprovalBindingSource;
        private tenderapprovalautoDataSet2 tenderapprovalautoDataSet2;
        private dcoffice.tenderapprovalautoDataSet2TableAdapters.tenderapprovalTableAdapter tenderapprovalTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
    }
}