
namespace SistemaGestorEscolar
{
    partial class IMessageBoxWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMessageBoxWarning));
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pctWarning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(432, 30);
            this.panEncabezado.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(140, 66);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(227, 22);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "La contraseña es Insegura";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(169, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 41);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese la contraseña nuevamente";
            // 
            // pctWarning
            // 
            this.pctWarning.Image = ((System.Drawing.Image)(resources.GetObject("pctWarning.Image")));
            this.pctWarning.Location = new System.Drawing.Point(29, 63);
            this.pctWarning.Name = "pctWarning";
            this.pctWarning.Size = new System.Drawing.Size(65, 59);
            this.pctWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctWarning.TabIndex = 5;
            this.pctWarning.TabStop = false;
            // 
            // IMessageBoxWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(432, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pctWarning);
            this.Controls.Add(this.panEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMessageBoxWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMessageBoxWarning";
            ((System.ComponentModel.ISupportInitialize)(this.pctWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panEncabezado;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pctWarning;
        private System.Windows.Forms.Label label1;
    }
}