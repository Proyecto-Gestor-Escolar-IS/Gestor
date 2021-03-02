
namespace SistemaGestorEscolar
{
    partial class IMessageBoxCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMessageBoxCheck));
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pctError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctError)).BeginInit();
            this.SuspendLayout();
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(13)))));
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(432, 30);
            this.panEncabezado.TabIndex = 2;
            this.panEncabezado.Paint += new System.Windows.Forms.PaintEventHandler(this.panEncabezado_Paint);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Balsamiq Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(164)))), ((int)(((byte)(12)))));
            this.lblCheck.Location = new System.Drawing.Point(145, 83);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(275, 20);
            this.lblCheck.TabIndex = 7;
            this.lblCheck.Text = "ACTUALIZACIÓN REALIZADA";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Silver;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(182, 132);
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
            this.pctError.Location = new System.Drawing.Point(32, 66);
            this.pctError.Name = "pctError";
            this.pctError.Size = new System.Drawing.Size(65, 59);
            this.pctError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctError.TabIndex = 5;
            this.pctError.TabStop = false;
            // 
            // IMessageBoxCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 193);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pctError);
            this.Controls.Add(this.panEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMessageBoxCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMessageBoxCheck";
            this.Load += new System.EventHandler(this.IMessageBoxCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panEncabezado;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pctError;
        public System.Windows.Forms.Label lblCheck;
    }
}