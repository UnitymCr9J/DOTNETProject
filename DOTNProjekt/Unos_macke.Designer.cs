namespace DOTNProjekt
{
    partial class Unos_macke
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
            this.lb_1 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.lb_3 = new System.Windows.Forms.Label();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.lb_4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(12, 25);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(100, 13);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Unesite ime mačke:";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(118, 25);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(128, 20);
            this.tb_1.TabIndex = 1;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(12, 75);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(101, 13);
            this.lb_2.TabIndex = 2;
            this.lb_2.Text = "Unesite cijenu u kn:";
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(118, 75);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(128, 20);
            this.tb_2.TabIndex = 3;
            // 
            // cb_1
            // 
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Location = new System.Drawing.Point(118, 128);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(155, 21);
            this.cb_1.TabIndex = 4;
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Location = new System.Drawing.Point(12, 131);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(91, 13);
            this.lb_3.TabIndex = 5;
            this.lb_3.Text = "Odaberite državu:";
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(74, 192);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(95, 38);
            this.bt_1.TabIndex = 6;
            this.bt_1.Text = "Kreiraj";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(233, 192);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(89, 38);
            this.bt_2.TabIndex = 7;
            this.bt_2.Text = "Cancel";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.Location = new System.Drawing.Point(15, 246);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(0, 13);
            this.lb_4.TabIndex = 8;
            // 
            // Unos_macke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 286);
            this.Controls.Add(this.lb_4);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.lb_1);
            this.Name = "Unos_macke";
            this.Text = "Unos_macke";
            this.Load += new System.EventHandler(this.Unos_macke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Label lb_4;
    }
}