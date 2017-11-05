namespace ProjectElections
{
    partial class SearchInvaildAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInvaildAccess));
            this.labe = new System.Windows.Forms.Label();
            this.butt = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.comBox1 = new System.Windows.Forms.ComboBox();
            this.butt8 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(2, 9);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(233, 38);
            this.labe.TabIndex = 80;
            this.labe.Text = "1. Press the button below to get kalpies\r\n with invaild access";
            // 
            // butt
            // 
            this.butt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butt.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt.Location = new System.Drawing.Point(44, 63);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(175, 73);
            this.butt.TabIndex = 81;
            this.butt.Text = "Show kalpies\r\n with invalid access ";
            this.butt.UseVisualStyleBackColor = false;
            this.butt.Click += new System.EventHandler(this.butt_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(29, 179);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(238, 19);
            this.lab.TabIndex = 82;
            this.lab.Text = "2. Choose kalpi code from the list below ";
            // 
            // comBox1
            // 
            this.comBox1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox1.FormattingEnabled = true;
            this.comBox1.Location = new System.Drawing.Point(68, 215);
            this.comBox1.Name = "comBox1";
            this.comBox1.Size = new System.Drawing.Size(116, 27);
            this.comBox1.TabIndex = 83;
            // 
            // butt8
            // 
            this.butt8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butt8.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt8.Location = new System.Drawing.Point(210, 255);
            this.butt8.Name = "butt8";
            this.butt8.Size = new System.Drawing.Size(96, 48);
            this.butt8.TabIndex = 85;
            this.butt8.Text = "Save";
            this.butt8.UseVisualStyleBackColor = false;
            this.butt8.Click += new System.EventHandler(this.butt8_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(312, 255);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 47);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // SearchInvaildAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(421, 315);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.butt8);
            this.Controls.Add(this.comBox1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.labe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchInvaildAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchInvaildAccess";
            this.Load += new System.EventHandler(this.SearchInvaildAccess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Button butt;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.ComboBox comBox1;
        private System.Windows.Forms.Button butt8;
        private System.Windows.Forms.Button button23;
    }
}