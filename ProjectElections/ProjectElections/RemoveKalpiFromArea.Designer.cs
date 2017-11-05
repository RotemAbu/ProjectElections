namespace ProjectElections
{
    partial class RemoveKalpiFromArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveKalpiFromArea));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kalpiCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalpiNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votersAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxVotersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kalpiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionsProjectDataSet = new ProjectElections.ElectionsProjectDataSet();
            this.kalpiTableAdapter = new ProjectElections.ElectionsProjectDataSetTableAdapters.KalpiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalpiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionsProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalpiCodeDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn,
            this.kalpiNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.votersAmountDataGridViewTextBoxColumn,
            this.maxVotersDataGridViewTextBoxColumn,
            this.modeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kalpiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // kalpiCodeDataGridViewTextBoxColumn
            // 
            this.kalpiCodeDataGridViewTextBoxColumn.DataPropertyName = "kalpiCode";
            this.kalpiCodeDataGridViewTextBoxColumn.HeaderText = "kalpiCode";
            this.kalpiCodeDataGridViewTextBoxColumn.Name = "kalpiCodeDataGridViewTextBoxColumn";
            this.kalpiCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "managerID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "managerID";
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            this.managerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalpiNameDataGridViewTextBoxColumn
            // 
            this.kalpiNameDataGridViewTextBoxColumn.DataPropertyName = "kalpiName";
            this.kalpiNameDataGridViewTextBoxColumn.HeaderText = "kalpiName";
            this.kalpiNameDataGridViewTextBoxColumn.Name = "kalpiNameDataGridViewTextBoxColumn";
            this.kalpiNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // votersAmountDataGridViewTextBoxColumn
            // 
            this.votersAmountDataGridViewTextBoxColumn.DataPropertyName = "votersAmount";
            this.votersAmountDataGridViewTextBoxColumn.HeaderText = "votersAmount";
            this.votersAmountDataGridViewTextBoxColumn.Name = "votersAmountDataGridViewTextBoxColumn";
            this.votersAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxVotersDataGridViewTextBoxColumn
            // 
            this.maxVotersDataGridViewTextBoxColumn.DataPropertyName = "maxVoters";
            this.maxVotersDataGridViewTextBoxColumn.HeaderText = "maxVoters";
            this.maxVotersDataGridViewTextBoxColumn.Name = "maxVotersDataGridViewTextBoxColumn";
            this.maxVotersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeDataGridViewCheckBoxColumn
            // 
            this.modeDataGridViewCheckBoxColumn.DataPropertyName = "mode";
            this.modeDataGridViewCheckBoxColumn.HeaderText = "mode";
            this.modeDataGridViewCheckBoxColumn.Name = "modeDataGridViewCheckBoxColumn";
            this.modeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kalpiBindingSource
            // 
            this.kalpiBindingSource.DataMember = "Kalpi";
            this.kalpiBindingSource.DataSource = this.electionsProjectDataSet;
            // 
            // electionsProjectDataSet
            // 
            this.electionsProjectDataSet.DataSetName = "ElectionsProjectDataSet";
            this.electionsProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalpiTableAdapter
            // 
            this.kalpiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose line and press the button to delete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(624, 276);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 47);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // RemoveKalpiFromArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(809, 354);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveKalpiFromArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveKalpiFromArea";
            this.Load += new System.EventHandler(this.RemoveKalpiFromArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalpiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionsProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ElectionsProjectDataSet electionsProjectDataSet;
        private System.Windows.Forms.BindingSource kalpiBindingSource;
        private ElectionsProjectDataSetTableAdapters.KalpiTableAdapter kalpiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalpiCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalpiNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votersAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxVotersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button23;
    }
}