namespace ProjectElections
{
    partial class WatchKalpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchKalpi));
            this.checkBoxIsOpen = new System.Windows.Forms.CheckBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxKalpi = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelKalpi = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxIsOpen
            // 
            this.checkBoxIsOpen.AutoSize = true;
            this.checkBoxIsOpen.Enabled = false;
            this.checkBoxIsOpen.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsOpen.Location = new System.Drawing.Point(63, 111);
            this.checkBoxIsOpen.Name = "checkBoxIsOpen";
            this.checkBoxIsOpen.Size = new System.Drawing.Size(70, 23);
            this.checkBoxIsOpen.TabIndex = 13;
            this.checkBoxIsOpen.Text = "Is Open";
            this.checkBoxIsOpen.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(69, 40);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 27);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textBoxKalpi
            // 
            this.textBoxKalpi.Enabled = false;
            this.textBoxKalpi.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKalpi.Location = new System.Drawing.Point(69, 72);
            this.textBoxKalpi.Name = "textBoxKalpi";
            this.textBoxKalpi.Size = new System.Drawing.Size(100, 27);
            this.textBoxKalpi.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Enabled = false;
            this.textBoxCity.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(69, 9);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 27);
            this.textBoxCity.TabIndex = 10;
            // 
            // labelKalpi
            // 
            this.labelKalpi.AutoSize = true;
            this.labelKalpi.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKalpi.Location = new System.Drawing.Point(14, 75);
            this.labelKalpi.Name = "labelKalpi";
            this.labelKalpi.Size = new System.Drawing.Size(42, 19);
            this.labelKalpi.TabIndex = 9;
            this.labelKalpi.Text = "Kalpi:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(12, 44);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 19);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(12, 14);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 19);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City:";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button23.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(63, 140);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(84, 37);
            this.button23.TabIndex = 127;
            this.button23.Text = "Exit";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // WatchKalpi
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(210, 186);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.checkBoxIsOpen);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxKalpi);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelKalpi);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WatchKalpi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch Kalpi";
            this.Load += new System.EventHandler(this.WatchKalpi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsOpen;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxKalpi;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelKalpi;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button button23;

    }
}