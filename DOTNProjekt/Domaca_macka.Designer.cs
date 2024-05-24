namespace DOTNProjekt
{
    partial class Domaca_macka
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
            this.dw_1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dw_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(12, 28);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(116, 13);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Lista domaćih mačaka:";
            // 
            // dw_1
            // 
            this.dw_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dw_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dw_1.Location = new System.Drawing.Point(15, 74);
            this.dw_1.Name = "dw_1";
            this.dw_1.Size = new System.Drawing.Size(444, 155);
            this.dw_1.TabIndex = 1;
            // 
            // Domaca_macka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 268);
            this.Controls.Add(this.dw_1);
            this.Controls.Add(this.lb_1);
            this.Name = "Domaca_macka";
            this.Text = "Domaca_macka";
            this.Load += new System.EventHandler(this.Domaca_macka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dw_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.DataGridView dw_1;
    }
}