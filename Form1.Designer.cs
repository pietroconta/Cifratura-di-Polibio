
namespace polibio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_data = new System.Windows.Forms.DataGridView();
            this.lbl_decifrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tab_data)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_data
            // 
            this.tab_data.AllowUserToAddRows = false;
            this.tab_data.AllowUserToDeleteRows = false;
            this.tab_data.AllowUserToOrderColumns = true;
            this.tab_data.AllowUserToResizeColumns = false;
            this.tab_data.AllowUserToResizeRows = false;
            this.tab_data.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.tab_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tab_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_data.ColumnHeadersVisible = false;
            this.tab_data.Location = new System.Drawing.Point(41, 102);
            this.tab_data.Name = "tab_data";
            this.tab_data.RowHeadersVisible = false;
            this.tab_data.Size = new System.Drawing.Size(310, 298);
            this.tab_data.TabIndex = 0;
            this.tab_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tab_data_CellClick);
            // 
            // lbl_decifrato
            // 
            this.lbl_decifrato.AutoSize = true;
            this.lbl_decifrato.Location = new System.Drawing.Point(15, 404);
            this.lbl_decifrato.Name = "lbl_decifrato";
            this.lbl_decifrato.Size = new System.Drawing.Size(0, 13);
            this.lbl_decifrato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cifratura Polibio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(350, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_decifrato);
            this.Controls.Add(this.tab_data);
            this.Name = "Form1";
            this.Text = "Poilibio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tab_data;
        private System.Windows.Forms.Label lbl_decifrato;
        private System.Windows.Forms.Label label1;
    }
}

