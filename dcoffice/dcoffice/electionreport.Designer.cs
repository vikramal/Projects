namespace dcoffice
{
    partial class electionreport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.electiondetailssaveDataSet2 = new dcoffice.electiondetailssaveDataSet2();
            this.electiondetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electiondetailsTableAdapter = new dcoffice.electiondetailssaveDataSet2TableAdapters.electiondetailsTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nominationautogenDataSet2 = new dcoffice.nominationautogenDataSet2();
            this.nominationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominationTableAdapter = new dcoffice.nominationautogenDataSet2TableAdapters.nominationTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rejectionDataSet2 = new dcoffice.rejectionDataSet2();
            this.rejectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rejectionTableAdapter = new dcoffice.rejectionDataSet2TableAdapters.rejectionTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electiondetailssaveDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electiondetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationautogenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1303, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Election details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1303, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nomination";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1303, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rejection";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1303, 221);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Declaration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "electiondetailssaveDataSet2_electiondetails";
            reportDataSource1.Value = this.electiondetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dcoffice.electiondetailsreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1269, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // electiondetailssaveDataSet2
            // 
            this.electiondetailssaveDataSet2.DataSetName = "electiondetailssaveDataSet2";
            this.electiondetailssaveDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // electiondetailsBindingSource
            // 
            this.electiondetailsBindingSource.DataMember = "electiondetails";
            this.electiondetailsBindingSource.DataSource = this.electiondetailssaveDataSet2;
            // 
            // electiondetailsTableAdapter
            // 
            this.electiondetailsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "nominationautogenDataSet2_nomination";
            reportDataSource2.Value = this.nominationBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "dcoffice.nominationreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(861, 250);
            this.reportViewer2.TabIndex = 0;
            // 
            // nominationautogenDataSet2
            // 
            this.nominationautogenDataSet2.DataSetName = "nominationautogenDataSet2";
            this.nominationautogenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominationBindingSource
            // 
            this.nominationBindingSource.DataMember = "nomination";
            this.nominationBindingSource.DataSource = this.nominationautogenDataSet2;
            // 
            // nominationTableAdapter
            // 
            this.nominationTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "rejectionDataSet2_rejection";
            reportDataSource3.Value = this.rejectionBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "dcoffice.rejectionreport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(904, 250);
            this.reportViewer3.TabIndex = 0;
            // 
            // rejectionDataSet2
            // 
            this.rejectionDataSet2.DataSetName = "rejectionDataSet2";
            this.rejectionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rejectionBindingSource
            // 
            this.rejectionBindingSource.DataMember = "rejection";
            this.rejectionBindingSource.DataSource = this.rejectionDataSet2;
            // 
            // rejectionTableAdapter
            // 
            this.rejectionTableAdapter.ClearBeforeFill = true;
            // 
            // electionreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 642);
            this.Controls.Add(this.tabControl1);
            this.Name = "electionreport";
            this.Text = "electionreport";
            this.Load += new System.EventHandler(this.electionreport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.electiondetailssaveDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electiondetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationautogenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource electiondetailsBindingSource;
        private electiondetailssaveDataSet2 electiondetailssaveDataSet2;
        private dcoffice.electiondetailssaveDataSet2TableAdapters.electiondetailsTableAdapter electiondetailsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource nominationBindingSource;
        private nominationautogenDataSet2 nominationautogenDataSet2;
        private dcoffice.nominationautogenDataSet2TableAdapters.nominationTableAdapter nominationTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource rejectionBindingSource;
        private rejectionDataSet2 rejectionDataSet2;
        private dcoffice.rejectionDataSet2TableAdapters.rejectionTableAdapter rejectionTableAdapter;
    }
}