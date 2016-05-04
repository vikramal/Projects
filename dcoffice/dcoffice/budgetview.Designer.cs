namespace dcoffice
{
    partial class budgetview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(budgetview));
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.budgetDataSet2 = new dcoffice.budgetDataSet2();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter = new dcoffice.budgetDataSet2TableAdapters.budgetTableAdapter();
            this.budgetdocnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taluknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panchayatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget1DataSet2 = new dcoffice.budget1DataSet2();
            this.budgetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter1 = new dcoffice.budget1DataSet2TableAdapters.budgetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(798, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 32);
            this.button7.TabIndex = 52;
            this.button7.Text = "Show all";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(624, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 32);
            this.button8.TabIndex = 51;
            this.button8.Text = "Show";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.budgetBindingSource;
            this.comboBox4.DisplayMember = "budgetdocnum";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(414, 24);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Select Notification Document NO.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetdocnumDataGridViewTextBoxColumn,
            this.taluknameDataGridViewTextBoxColumn,
            this.panchayatDataGridViewTextBoxColumn,
            this.totalbudgetDataGridViewTextBoxColumn,
            this.budgetyearDataGridViewTextBoxColumn,
            this.approvaldateDataGridViewTextBoxColumn,
            this.approvedbyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.budgetBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1257, 339);
            this.dataGridView1.TabIndex = 53;
            // 
            // budgetDataSet2
            // 
            this.budgetDataSet2.DataSetName = "budgetDataSet2";
            this.budgetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "budget";
            this.budgetBindingSource.DataSource = this.budgetDataSet2;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // budgetdocnumDataGridViewTextBoxColumn
            // 
            this.budgetdocnumDataGridViewTextBoxColumn.DataPropertyName = "budgetdocnum";
            this.budgetdocnumDataGridViewTextBoxColumn.HeaderText = "budgetdocnum";
            this.budgetdocnumDataGridViewTextBoxColumn.Name = "budgetdocnumDataGridViewTextBoxColumn";
            // 
            // taluknameDataGridViewTextBoxColumn
            // 
            this.taluknameDataGridViewTextBoxColumn.DataPropertyName = "talukname";
            this.taluknameDataGridViewTextBoxColumn.HeaderText = "talukname";
            this.taluknameDataGridViewTextBoxColumn.Name = "taluknameDataGridViewTextBoxColumn";
            // 
            // panchayatDataGridViewTextBoxColumn
            // 
            this.panchayatDataGridViewTextBoxColumn.DataPropertyName = "panchayat";
            this.panchayatDataGridViewTextBoxColumn.HeaderText = "panchayat";
            this.panchayatDataGridViewTextBoxColumn.Name = "panchayatDataGridViewTextBoxColumn";
            // 
            // totalbudgetDataGridViewTextBoxColumn
            // 
            this.totalbudgetDataGridViewTextBoxColumn.DataPropertyName = "totalbudget";
            this.totalbudgetDataGridViewTextBoxColumn.HeaderText = "totalbudget";
            this.totalbudgetDataGridViewTextBoxColumn.Name = "totalbudgetDataGridViewTextBoxColumn";
            // 
            // budgetyearDataGridViewTextBoxColumn
            // 
            this.budgetyearDataGridViewTextBoxColumn.DataPropertyName = "budgetyear";
            this.budgetyearDataGridViewTextBoxColumn.HeaderText = "budgetyear";
            this.budgetyearDataGridViewTextBoxColumn.Name = "budgetyearDataGridViewTextBoxColumn";
            // 
            // approvaldateDataGridViewTextBoxColumn
            // 
            this.approvaldateDataGridViewTextBoxColumn.DataPropertyName = "approvaldate";
            this.approvaldateDataGridViewTextBoxColumn.HeaderText = "approvaldate";
            this.approvaldateDataGridViewTextBoxColumn.Name = "approvaldateDataGridViewTextBoxColumn";
            // 
            // approvedbyDataGridViewTextBoxColumn
            // 
            this.approvedbyDataGridViewTextBoxColumn.DataPropertyName = "approvedby";
            this.approvedbyDataGridViewTextBoxColumn.HeaderText = "approvedby";
            this.approvedbyDataGridViewTextBoxColumn.Name = "approvedbyDataGridViewTextBoxColumn";
            // 
            // budget1DataSet2
            // 
            this.budget1DataSet2.DataSetName = "budget1DataSet2";
            this.budget1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource2
            // 
            this.budgetBindingSource2.DataMember = "budget";
            this.budgetBindingSource2.DataSource = this.budget1DataSet2;
            // 
            // budgetTableAdapter1
            // 
            this.budgetTableAdapter1.ClearBeforeFill = true;
            // 
            // budgetview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Name = "budgetview";
            this.Text = "budgetview";
            this.Load += new System.EventHandler(this.budgetview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private budgetDataSet2 budgetDataSet2;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private dcoffice.budgetDataSet2TableAdapters.budgetTableAdapter budgetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetdocnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taluknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn panchayatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedbyDataGridViewTextBoxColumn;
        private budget1DataSet2 budget1DataSet2;
        private System.Windows.Forms.BindingSource budgetBindingSource2;
        private dcoffice.budget1DataSet2TableAdapters.budgetTableAdapter budgetTableAdapter1;

    }
}