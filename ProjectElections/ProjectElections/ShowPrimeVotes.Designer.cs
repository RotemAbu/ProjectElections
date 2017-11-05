namespace ProjectElections
{
    partial class ShowPrimeVotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPrimeVotes));
            this.projectDBDataSet = new ProjectElections.ProjectDBDataSet();
            this.partyMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.party_MembersTableAdapter = new ProjectElections.ProjectDBDataSetTableAdapters.Party_MembersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyMembersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet1 = new ProjectElections.ProjectDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.listBoxRes = new System.Windows.Forms.ListBox();
            this.listBoxVotes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMembersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyMembersBindingSource
            // 
            this.partyMembersBindingSource.DataMember = "Party_Members";
            this.partyMembersBindingSource.DataSource = this.projectDBDataSet;
            // 
            // party_MembersTableAdapter
            // 
            this.party_MembersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberCodeDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.listPlaceDataGridViewTextBoxColumn,
            this.modeDataGridViewCheckBoxColumn,
            this.ColumnVotes});
            this.dataGridView1.DataSource = this.partyMembersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // memberCodeDataGridViewTextBoxColumn
            // 
            this.memberCodeDataGridViewTextBoxColumn.DataPropertyName = "memberCode";
            this.memberCodeDataGridViewTextBoxColumn.HeaderText = "memberCode";
            this.memberCodeDataGridViewTextBoxColumn.Name = "memberCodeDataGridViewTextBoxColumn";
            this.memberCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "partyName";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "partyName";
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            this.partyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listPlaceDataGridViewTextBoxColumn
            // 
            this.listPlaceDataGridViewTextBoxColumn.DataPropertyName = "listPlace";
            this.listPlaceDataGridViewTextBoxColumn.HeaderText = "listPlace";
            this.listPlaceDataGridViewTextBoxColumn.Name = "listPlaceDataGridViewTextBoxColumn";
            this.listPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.listPlaceDataGridViewTextBoxColumn.Visible = false;
            // 
            // modeDataGridViewCheckBoxColumn
            // 
            this.modeDataGridViewCheckBoxColumn.DataPropertyName = "mode";
            this.modeDataGridViewCheckBoxColumn.HeaderText = "mode";
            this.modeDataGridViewCheckBoxColumn.Name = "modeDataGridViewCheckBoxColumn";
            this.modeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.modeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ColumnVotes
            // 
            this.ColumnVotes.DataPropertyName = "listPlace";
            this.ColumnVotes.HeaderText = "Total Votes";
            this.ColumnVotes.Name = "ColumnVotes";
            this.ColumnVotes.ReadOnly = true;
            // 
            // partyMembersBindingSource1
            // 
            this.partyMembersBindingSource1.DataMember = "Party_Members";
            this.partyMembersBindingSource1.DataSource = this.projectDBDataSet1;
            // 
            // projectDBDataSet1
            // 
            this.projectDBDataSet1.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prime Minister Votes:";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(195, 346);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(94, 47);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // listBoxRes
            // 
            this.listBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxRes.FormattingEnabled = true;
            this.listBoxRes.ItemHeight = 16;
            this.listBoxRes.Location = new System.Drawing.Point(34, 57);
            this.listBoxRes.Name = "listBoxRes";
            this.listBoxRes.Size = new System.Drawing.Size(233, 276);
            this.listBoxRes.TabIndex = 128;
            // 
            // listBoxVotes
            // 
            this.listBoxVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxVotes.FormattingEnabled = true;
            this.listBoxVotes.ItemHeight = 16;
            this.listBoxVotes.Location = new System.Drawing.Point(263, 57);
            this.listBoxVotes.Name = "listBoxVotes";
            this.listBoxVotes.Size = new System.Drawing.Size(233, 276);
            this.listBoxVotes.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 130;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 131;
            this.label3.Text = "Number Of Votes:";
            // 
            // ShowPrimeVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(522, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxVotes);
            this.Controls.Add(this.listBoxRes);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPrimeVotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPrimeVotes";
            this.Load += new System.EventHandler(this.ShowPrimeVotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMembersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource partyMembersBindingSource;
        private ProjectDBDataSetTableAdapters.Party_MembersTableAdapter party_MembersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDBDataSet projectDBDataSet1;
        private System.Windows.Forms.BindingSource partyMembersBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVotes;
        private System.Windows.Forms.ListBox listBoxRes;
        private System.Windows.Forms.ListBox listBoxVotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}