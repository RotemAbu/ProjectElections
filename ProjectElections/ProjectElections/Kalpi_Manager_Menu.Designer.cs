namespace ProjectElections
{
    partial class Kalpi_Manager_Menu
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
            this.add_voter = new System.Windows.Forms.Button();
            this.remove_voter = new System.Windows.Forms.Button();
            this.add_accomp = new System.Windows.Forms.Button();
            this.identify_voter = new System.Windows.Forms.Button();
            this.block_voter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_voter
            // 
            this.add_voter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_voter.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_voter.Location = new System.Drawing.Point(23, 12);
            this.add_voter.Name = "add_voter";
            this.add_voter.Size = new System.Drawing.Size(98, 56);
            this.add_voter.TabIndex = 0;
            this.add_voter.Text = "Add Voter to Kalpi";
            this.add_voter.UseVisualStyleBackColor = false;
            this.add_voter.Click += new System.EventHandler(this.add_voter_Click);
            // 
            // remove_voter
            // 
            this.remove_voter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.remove_voter.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_voter.Location = new System.Drawing.Point(127, 12);
            this.remove_voter.Name = "remove_voter";
            this.remove_voter.Size = new System.Drawing.Size(106, 56);
            this.remove_voter.TabIndex = 1;
            this.remove_voter.Text = "Remove Voter from Kalpi";
            this.remove_voter.UseVisualStyleBackColor = false;
            this.remove_voter.Click += new System.EventHandler(this.remove_voter_Click);
            // 
            // add_accomp
            // 
            this.add_accomp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_accomp.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_accomp.Location = new System.Drawing.Point(239, 12);
            this.add_accomp.Name = "add_accomp";
            this.add_accomp.Size = new System.Drawing.Size(130, 56);
            this.add_accomp.TabIndex = 2;
            this.add_accomp.Text = "Add Accompanier to Voter";
            this.add_accomp.UseVisualStyleBackColor = false;
            this.add_accomp.Click += new System.EventHandler(this.add_accomp_Click);
            // 
            // identify_voter
            // 
            this.identify_voter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.identify_voter.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identify_voter.Location = new System.Drawing.Point(23, 74);
            this.identify_voter.Name = "identify_voter";
            this.identify_voter.Size = new System.Drawing.Size(98, 56);
            this.identify_voter.TabIndex = 3;
            this.identify_voter.Text = "Identify Voter";
            this.identify_voter.UseVisualStyleBackColor = false;
            this.identify_voter.Click += new System.EventHandler(this.identify_voter_Click);
            // 
            // block_voter
            // 
            this.block_voter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.block_voter.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_voter.Location = new System.Drawing.Point(127, 74);
            this.block_voter.Name = "block_voter";
            this.block_voter.Size = new System.Drawing.Size(106, 56);
            this.block_voter.TabIndex = 4;
            this.block_voter.Text = "Block Voter";
            this.block_voter.UseVisualStyleBackColor = false;
            this.block_voter.Click += new System.EventHandler(this.block_voter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(127, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Un Block Voter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Kalpi_Manager_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectElections.Properties.Resources.בחירות_2015;
            this.ClientSize = new System.Drawing.Size(631, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.block_voter);
            this.Controls.Add(this.identify_voter);
            this.Controls.Add(this.add_accomp);
            this.Controls.Add(this.remove_voter);
            this.Controls.Add(this.add_voter);
            this.Name = "Kalpi_Manager_Menu";
            this.Text = "Kalpi_Manager_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_voter;
        private System.Windows.Forms.Button remove_voter;
        private System.Windows.Forms.Button add_accomp;
        private System.Windows.Forms.Button identify_voter;
        private System.Windows.Forms.Button block_voter;
        private System.Windows.Forms.Button button1;
    }
}