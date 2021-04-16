namespace SistemaGestorEscolar.Login
{
    partial class frmRecuperacionContrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperacionContrasenia));
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.rtxtHtml = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "RECUPERACIÓN DE CONTRASEÑA";
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.exitButton;
            this.btnCerrarPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarPrograma.FlatAppearance.BorderSize = 0;
            this.btnCerrarPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrograma.Location = new System.Drawing.Point(388, -2);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(36, 36);
            this.btnCerrarPrograma.TabIndex = 11;
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "NUMERO DE IDENTIDAD";
            // 
            // mtxtIdentidad
            // 
            this.mtxtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtIdentidad.Location = new System.Drawing.Point(131, 141);
            this.mtxtIdentidad.Mask = "0000000000000";
            this.mtxtIdentidad.Name = "mtxtIdentidad";
            this.mtxtIdentidad.Size = new System.Drawing.Size(133, 28);
            this.mtxtIdentidad.TabIndex = 13;
            this.mtxtIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(127, 199);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(142, 34);
            this.btnRecuperar.TabIndex = 14;
            this.btnRecuperar.Text = "RECUPERAR";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // rtxtHtml
            // 
            this.rtxtHtml.Location = new System.Drawing.Point(12, 199);
            this.rtxtHtml.Name = "rtxtHtml";
            this.rtxtHtml.Size = new System.Drawing.Size(100, 96);
            this.rtxtHtml.TabIndex = 15;
            this.rtxtHtml.Text = resources.GetString("rtxtHtml.Text");
            this.rtxtHtml.Visible = false;
            // 
            // frmRecuperacionContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 252);
            this.Controls.Add(this.rtxtHtml);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.mtxtIdentidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarPrograma);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecuperacionContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacion de Contraseña";
            this.Load += new System.EventHandler(this.frmRecuperacionContrasenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtIdentidad;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.RichTextBox rtxtHtml;
    }
}