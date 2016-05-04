namespace dcoffice
{
    partial class boomireport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boomireport));
            this.landconversionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conversionDataSet2 = new dcoffice.conversionDataSet2();
            this.landnotificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.landdenotifDataSet2 = new dcoffice.landdenotifDataSet2();
            this.denotificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denotiDataSet2 = new dcoffice.denotiDataSet2();
            this.landallocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.landallocationDataSet2 = new dcoffice.landallocationDataSet2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.landconversionTableAdapter = new dcoffice.conversionDataSet2TableAdapters.landconversionTableAdapter();
            this.landnotificationTableAdapter = new dcoffice.landdenotifDataSet2TableAdapters.landnotificationTableAdapter();
            this.denotificationTableAdapter = new dcoffice.denotiDataSet2TableAdapters.denotificationTableAdapter();
            this.landallocationTableAdapter = new dcoffice.landallocationDataSet2TableAdapters.landallocationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.landconversionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landnotificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landdenotifDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denotificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denotiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landallocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landallocationDataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // landconversionBindingSource
            // 
            this.landconversionBindingSource.DataMember = "landconversion";
            this.landconversionBindingSource.DataSource = this.conversionDataSet2;
            // 
            // conversionDataSet2
            // 
            this.conversionDataSet2.DataSetName = "conversionDataSet2";
            this.conversionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // landnotificationBindingSource
            // 
            this.landnotificationBindingSource.DataMember = "landnotification";
            this.landnotificationBindingSource.DataSource = this.landdenotifDataSet2;
            // 
            // landdenotifDataSet2
            // 
            this.landdenotifDataSet2.DataSetName = "landdenotifDataSet2";
            this.landdenotifDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // denotificationBindingSource
            // 
            this.denotificationBindingSource.DataMember = "denotification";
            this.denotificationBindingSource.DataSource = this.denotiDataSet2;
            // 
            // denotiDataSet2
            // 
            this.denotiDataSet2.DataSetName = "denotiDataSet2";
            this.denotiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // landallocationBindingSource
            // 
            this.landallocationBindingSource.DataMember = "landallocation";
            this.landallocationBindingSource.DataSource = this.landallocationDataSet2;
            // 
            // landallocationDataSet2
            // 
            this.landallocationDataSet2.DataSetName = "landallocationDataSet2";
            this.landallocationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1332, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1324, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Land Conversion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "conversionDataSet2_landconversion";
            reportDataSource1.Value = this.landconversionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dcoffice.landconvertionreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1318, 631);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 80;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1324, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Land Notification";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "landdenotifDataSet2_landnotification";
            reportDataSource2.Value = this.landnotificationBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "dcoffice.landnotificationreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1315, 630);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.ZoomPercent = 80;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1324, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Land Denotification";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "denotiDataSet2_denotification";
            reportDataSource3.Value = this.denotificationBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "dcoffice.landdenotoficationreport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1315, 630);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.ZoomPercent = 80;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1324, 663);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Land Allocation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "landallocationDataSet2_landallocation";
            reportDataSource4.Value = this.landallocationBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "dcoffice.landallocationreport.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(1312, 629);
            this.reportViewer4.TabIndex = 0;
            this.reportViewer4.ZoomPercent = 80;
            // 
            // landconversionTableAdapter
            // 
            this.landconversionTableAdapter.ClearBeforeFill = true;
            // 
            // landnotificationTableAdapter
            // 
            this.landnotificationTableAdapter.ClearBeforeFill = true;
            // 
            // denotificationTableAdapter
            // 
            this.denotificationTableAdapter.ClearBeforeFill = true;
            // 
            // landallocationTableAdapter
            // 
            this.landallocationTableAdapter.ClearBeforeFill = true;
            // 
            // boomireport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1316, 652);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "boomireport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Automation of District Commissioner Office";
            this.Load += new System.EventHandler(this.boomireport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.landconversionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landnotificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landdenotifDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denotificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denotiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landallocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landallocationDataSet2)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource landconversionBindingSource;
        private conversionDataSet2 conversionDataSet2;
        private dcoffice.conversionDataSet2TableAdapters.landconversionTableAdapter landconversionTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource landnotificationBindingSource;
        private landdenotifDataSet2 landdenotifDataSet2;
        private dcoffice.landdenotifDataSet2TableAdapters.landnotificationTableAdapter landnotificationTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource denotificationBindingSource;
        private denotiDataSet2 denotiDataSet2;
        private dcoffice.denotiDataSet2TableAdapters.denotificationTableAdapter denotificationTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource landallocationBindingSource;
        private landallocationDataSet2 landallocationDataSet2;
        private dcoffice.landallocationDataSet2TableAdapters.landallocationTableAdapter landallocationTableAdapter;
    }
}