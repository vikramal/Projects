namespace dcoffice
{
    partial class panchayatreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panchayatreport));
            this.roadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.road1DataSet2 = new dcoffice.road1DataSet2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.roadTableAdapter = new dcoffice.road1DataSet2TableAdapters.roadTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hospautoDataSet2 = new dcoffice.hospautoDataSet2();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter = new dcoffice.hospautoDataSet2TableAdapters.hospitalTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.agri1DataSet2 = new dcoffice.agri1DataSet2();
            this.agricultureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agricultureTableAdapter = new dcoffice.agri1DataSet2TableAdapters.agricultureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1DataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospautoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agri1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agricultureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roadBindingSource
            // 
            this.roadBindingSource.DataMember = "road";
            this.roadBindingSource.DataSource = this.road1DataSet2;
            // 
            // road1DataSet2
            // 
            this.road1DataSet2.DataSetName = "road1DataSet2";
            this.road1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1314, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Village";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Taluk";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(901, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "District";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(901, 438);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Road";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "road1DataSet2_road";
            reportDataSource1.Value = this.roadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dcoffice.roadreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(901, 438);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hospital";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer3);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1306, 663);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Agriculture";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // roadTableAdapter
            // 
            this.roadTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "hospautoDataSet2_hospital";
            reportDataSource2.Value = this.hospitalBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "dcoffice.hospitalreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(873, 372);
            this.reportViewer2.TabIndex = 0;
            // 
            // hospautoDataSet2
            // 
            this.hospautoDataSet2.DataSetName = "hospautoDataSet2";
            this.hospautoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "hospital";
            this.hospitalBindingSource.DataSource = this.hospautoDataSet2;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "agri1DataSet2_agriculture";
            reportDataSource3.Value = this.agricultureBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "dcoffice.agriculturereport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1320, 620);
            this.reportViewer3.TabIndex = 0;
            // 
            // agri1DataSet2
            // 
            this.agri1DataSet2.DataSetName = "agri1DataSet2";
            this.agri1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agricultureBindingSource
            // 
            this.agricultureBindingSource.DataMember = "agriculture";
            this.agricultureBindingSource.DataSource = this.agri1DataSet2;
            // 
            // agricultureTableAdapter
            // 
            this.agricultureTableAdapter.ClearBeforeFill = true;
            // 
            // panchayatreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1316, 638);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "panchayatreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automation of District Commissioner Office";
            this.Load += new System.EventHandler(this.panchayatreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1DataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospautoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agri1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agricultureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource roadBindingSource;
        private road1DataSet2 road1DataSet2;
        private dcoffice.road1DataSet2TableAdapters.roadTableAdapter roadTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private hospautoDataSet2 hospautoDataSet2;
        private dcoffice.hospautoDataSet2TableAdapters.hospitalTableAdapter hospitalTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource agricultureBindingSource;
        private agri1DataSet2 agri1DataSet2;
        private dcoffice.agri1DataSet2TableAdapters.agricultureTableAdapter agricultureTableAdapter;
    }
}