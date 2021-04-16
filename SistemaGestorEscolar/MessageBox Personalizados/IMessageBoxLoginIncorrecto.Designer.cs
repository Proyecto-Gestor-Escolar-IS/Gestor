
namespace SistemaGestorEscolar.MessageBox_Personalizados
{
    partial class IMessageBoxLoginIncorrecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMessageBoxLoginIncorrecto));
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pctError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctError)).BeginInit();
            this.SuspendLayout();
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(458, 30);
            this.panEncabezado.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.lblError.Location = new System.Drawing.Point(124, 68);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(252, 40);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "USUARIO O CONTRASEÑA \r\nINCORRECTOS";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Silver;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(200, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 41);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pctError
            // 
            this.pctError.Image = ((System.Drawing.Image)(resources.GetObject("pctError.Image")));
            this.pctError.Location = new System.Drawing.Point(28, 53);
            this.pctError.Name = "pctError";
            this.pctError.Size = new System.Drawing.Size(65, 59);
            this.pctError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctError.TabIndex = 5;
            this.pctError.TabStop = false;
            // 
            // IMessageBoxLoginIncorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 193);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pctError);
            this.Controls.Add(this.panEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IMessageBoxLoginIncorrecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMessageBoxLoginIncorrecto";
            this.Load += new System.EventHandler(this.IMessageBoxLoginIncorrecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panEncabezado;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pctError;
        public System.Windows.Forms.Label lblError;
    }
}