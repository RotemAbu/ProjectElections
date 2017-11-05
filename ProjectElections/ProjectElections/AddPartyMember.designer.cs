namespace ProjectElections
{
    partial class AddPartyMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartyMember));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.educasion = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expirence = new System.Windows.Forms.RichTextBox();
            this.brithDate = new System.Windows.Forms.DateTimePicker();
            this.listpalce = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameParty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codePartyMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.brithDate);
            this.groupBox1.Controls.Add(this.listpalce);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameParty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.codePartyMember);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(901, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Party Member";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(778, 263);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 47);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.educasion);
            this.groupBox3.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 230);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Education";
            // 
            // educasion
            // 
            this.educasion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.educasion.Location = new System.Drawing.Point(3, 23);
            this.educasion.Name = "educasion";
            this.educasion.Size = new System.Drawing.Size(278, 204);
            this.educasion.TabIndex = 1;
            this.educasion.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expirence);
            this.groupBox2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(311, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 230);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experience";
            // 
            // expirence
            // 
            this.expirence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expirence.Location = new System.Drawing.Point(3, 23);
            this.expirence.Name = "expirence";
            this.expirence.Size = new System.Drawing.Size(278, 204);
            this.expirence.TabIndex = 0;
            this.expirence.Text = "";
            // 
            // brithDate
            // 
            this.brithDate.CustomFormat = "dd-MM-yyyy";
            this.brithDate.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brithDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.brithDate.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.brithDate.Location = new System.Drawing.Point(757, 164);
            this.brithDate.Name = "brithDate";
            this.brithDate.Size = new System.Drawing.Size(144, 27);
            this.brithDate.TabIndex = 17;
            this.brithDate.ValueChanged += new System.EventHandler(this.brithDate_ValueChanged);
            // 
            // listpalce
            // 
            this.listpalce.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listpalce.Location = new System.Drawing.Point(757, 209);
            this.listpalce.Name = "listpalce";
            this.listpalce.Size = new System.Drawing.Size(144, 27);
            this.listpalce.TabIndex = 12;
            this.listpalce.TextChanged += new System.EventHandler(this.listpalce_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(610, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date Of Birth";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(757, 122);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(144, 27);
            this.lastName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(757, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(144, 27);
            this.name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // nameParty
            // 
            this.nameParty.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameParty.Location = new System.Drawing.Point(757, 60);
            this.nameParty.Name = "nameParty";
            this.nameParty.Size = new System.Drawing.Size(144, 27);
            this.nameParty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party Name";
            // 
            // codePartyMember
            // 
            this.codePartyMember.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePartyMember.Location = new System.Drawing.Point(757, 29);
            this.codePartyMember.Name = "codePartyMember";
            this.codePartyMember.Size = new System.Drawing.Size(144, 27);
            this.codePartyMember.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Party Member";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(655, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPartyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(925, 382);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPartyMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Party Member";
            this.Load += new System.EventHandler(this.AddPartyMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameParty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codePartyMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox listpalce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox educasion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox expirence;
        private System.Windows.Forms.DateTimePicker brithDate;
        private System.Windows.Forms.Button button23;


    }
}