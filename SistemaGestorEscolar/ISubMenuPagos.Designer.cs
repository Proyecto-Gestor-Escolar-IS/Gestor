
namespace SistemaGestorEscolar
{
    partial class ISubMenuPagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnHistorialPagos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = " PAGOS";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnRegistrarPago.Enabled = false;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPago.Location = new System.Drawing.Point(246, 426);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(407, 200);
            this.btnRegistrarPago.TabIndex = 21;
            this.btnRegistrarPago.Text = "REGISTRAR PAGO";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            // 
            // btnHistorialPagos
            // 
            this.btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnHistorialPagos.Enabled = false;
            this.btnHistorialPagos.FlatAppearance.BorderSize = 0;
            this.btnHistorialPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPagos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPagos.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialPagos.Location = new System.Drawing.Point(983, 426);
            this.btnHistorialPagos.Name = "btnHistorialPagos";
            this.btnHistorialPagos.Size = new System.Drawing.Size(407, 200);
            this.btnHistorialPagos.TabIndex = 22;
            this.btnHistorialPagos.Text = "HISTORIAL DE PAGOS";
            this.btnHistorialPagos.UseVisualStyleBackColor = false;
            // 
            // ISubMenuPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.btnHistorialPagos);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ISubMenuPagos";
            this.Text = "ISubMenuPagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnHistorialPagos;
    }
}