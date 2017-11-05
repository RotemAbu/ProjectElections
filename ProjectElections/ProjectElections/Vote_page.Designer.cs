namespace ProjectElections
{
    partial class Vote_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vote_page));
            this.prime_ministers_lv = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gfdfgdsfg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parties_lv = new System.Windows.Forms.ListView();
            this.Party_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pm_vote_button = new System.Windows.Forms.Button();
            this.party_vote_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prime_ministers_lv
            // 
            this.prime_ministers_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.gfdfgdsfg});
            this.prime_ministers_lv.Location = new System.Drawing.Point(55, 61);
            this.prime_ministers_lv.Name = "prime_ministers_lv";
            this.prime_ministers_lv.Size = new System.Drawing.Size(259, 159);
            this.prime_ministers_lv.TabIndex = 0;
            this.prime_ministers_lv.UseCompatibleStateImageBehavior = false;
            this.prime_ministers_lv.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 67;
            // 
            // gfdfgdsfg
            // 
            this.gfdfgdsfg.Text = "Name";
            this.gfdfgdsfg.Width = 188;
            // 
            // parties_lv
            // 
            this.parties_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Party_name});
            this.parties_lv.Location = new System.Drawing.Point(396, 61);
            this.parties_lv.Name = "parties_lv";
            this.parties_lv.Size = new System.Drawing.Size(259, 159);
            this.parties_lv.TabIndex = 1;
            this.parties_lv.UseCompatibleStateImageBehavior = false;
            this.parties_lv.View = System.Windows.Forms.View.Details;
            // 
            // Party_name
            // 
            this.Party_name.Text = "Party name";
            this.Party_name.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prime Minister";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party";
            // 
            // pm_vote_button
            // 
            this.pm_vote_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pm_vote_button.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm_vote_button.Location = new System.Drawing.Point(97, 242);
            this.pm_vote_button.Name = "pm_vote_button";
            this.pm_vote_button.Size = new System.Drawing.Size(173, 37);
            this.pm_vote_button.TabIndex = 4;
            this.pm_vote_button.Text = "vote Prime Minister";
            this.pm_vote_button.UseVisualStyleBackColor = false;
            this.pm_vote_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // party_vote_button
            // 
            this.party_vote_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.party_vote_button.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_vote_button.Location = new System.Drawing.Point(451, 242);
            this.party_vote_button.Name = "party_vote_button";
            this.party_vote_button.Size = new System.Drawing.Size(159, 37);
            this.party_vote_button.TabIndex = 5;
            this.party_vote_button.Text = "vote Party";
            this.party_vote_button.UseVisualStyleBackColor = false;
            this.party_vote_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "white note";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(310, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "save vote";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(586, 294);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 47);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // Vote_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(698, 353);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.party_vote_button);
            this.Controls.Add(this.pm_vote_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parties_lv);
            this.Controls.Add(this.prime_ministers_lv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vote_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prime_ministers_lv;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader gfdfgdsfg;
        private System.Windows.Forms.ListView parties_lv;
        public System.Windows.Forms.ColumnHeader Party_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pm_vote_button;
        private System.Windows.Forms.Button party_vote_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button23;
    }
}