namespace ProjectElections
{
    partial class PercentageVotersReportByArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentageVotersReportByArea));
            this.labelId = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(21, 20);
            this.labelId.Name = "labelId";
            this.labelId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelId.Size = new System.Drawing.Size(257, 19);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "The percentages of voters in your area are:";
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(73, 61);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(142, 27);
            this.textBox.TabIndex = 26;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(188, 95);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(90, 33);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // PercentageVotersReportByArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(300, 139);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PercentageVotersReportByArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PercentageVotersReportByArea";
            this.Load += new System.EventHandler(this.PercentageVotersReportByArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button23;
    }
}