namespace Matching_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable del Diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.RowCount = 4;

            for (int i = 0; i < 4; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            }

            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;

            for (int i = 0; i < 16; i++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Dock = System.Windows.Forms.DockStyle.Fill;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold);
                label.BackColor = System.Drawing.Color.Gray;
                label.ForeColor = label.BackColor;
                label.Click += new System.EventHandler(this.label_Click);
                this.tableLayoutPanel1.Controls.Add(label);
            }

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Matching Game";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
