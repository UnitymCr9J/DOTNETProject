namespace DOTNProjekt
{
    partial class Unos_drzave
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
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.lb_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(12, 35);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(81, 13);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Unesite državu:";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(99, 35);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(213, 20);
            this.tb_1.TabIndex = 1;
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(54, 89);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(94, 35);
            this.bt_1.TabIndex = 2;
            this.bt_1.Text = "Kreiraj";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(213, 89);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(85, 35);
            this.bt_2.TabIndex = 3;
            this.bt_2.Text = "Cancel";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(27, 154);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(0, 13);
            this.lb_2.TabIndex = 4;
            // 
            // Unos_drzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 207);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.lb_1);
            this.Name = "Unos_drzave";
            this.Text = "Unos_drzave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Label lb_2;
    }
}