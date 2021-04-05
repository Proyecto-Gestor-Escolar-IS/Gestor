namespace SistemaGestorEscolar.Login
{
    partial class IfrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IfrmLogin));
            this.txtdentidad = new System.Windows.Forms.TextBox();
            this.txtContrase = new System.Windows.Forms.TextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new AltoControls.AltoButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIngresar = new AltoControls.AltoButton();
            this.lblOlvideContra = new System.Windows.Forms.LinkLabel();
            this.chkMostrarContra = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picImagotipo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdentidad
            // 
            this.txtdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdentidad.Location = new System.Drawing.Point(411, 475);
            this.txtdentidad.Name = "txtdentidad";
            this.txtdentidad.Size = new System.Drawing.Size(310, 31);
            this.txtdentidad.TabIndex = 11;
            // 
            // txtContrase
            // 
            this.txtContrase.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrase.Location = new System.Drawing.Point(411, 602);
            this.txtContrase.Name = "txtContrase";
            this.txtContrase.PasswordChar = '●';
            this.txtContrase.Size = new System.Drawing.Size(310, 31);
            this.txtContrase.TabIndex = 12;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.panelPrincipal.Controls.Add(this.picImagotipo);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1920, 1080);
            this.panelPrincipal.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.lblOlvideContra);
            this.panel1.Controls.Add(this.txtdentidad);
            this.panel1.Controls.Add(this.txtContrase);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.chkMostrarContra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(858, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 1080);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Active1 = System.Drawing.Color.DarkRed;
            this.btnSalir.Active2 = System.Drawing.Color.DarkRed;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.Font = new System.Drawing.Font("Balsamiq Sans", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Inactive1 = System.Drawing.Color.Red;
            this.btnSalir.Inactive2 = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(904, 1034);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Radius = 20;
            this.btnSalir.Size = new System.Drawing.Size(155, 43);
            this.btnSalir.Stroke = true;
            this.btnSalir.StrokeColor = System.Drawing.Color.Red;
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Transparency = false;
            this.btnSalir.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 38);
            this.label4.TabIndex = 21;
            this.label4.Text = "INGRESE SUS DATOS PARA COMENZAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Balsamiq Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 53);
            this.label7.TabIndex = 20;
            this.label7.Text = "¡BIENVENIDO!";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnIngresar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnIngresar.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnIngresar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnIngresar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnIngresar.Location = new System.Drawing.Point(411, 738);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Radius = 20;
            this.btnIngresar.Size = new System.Drawing.Size(310, 61);
            this.btnIngresar.Stroke = true;
            this.btnIngresar.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnIngresar.TabIndex = 19;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.Transparency = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblOlvideContra
            // 
            this.lblOlvideContra.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblOlvideContra.AutoSize = true;
            this.lblOlvideContra.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideContra.LinkColor = System.Drawing.Color.Black;
            this.lblOlvideContra.Location = new System.Drawing.Point(466, 900);
            this.lblOlvideContra.Name = "lblOlvideContra";
            this.lblOlvideContra.Size = new System.Drawing.Size(212, 19);
            this.lblOlvideContra.TabIndex = 18;
            this.lblOlvideContra.TabStop = true;
            this.lblOlvideContra.Text = "¿Olvido su Contraseña?";
            this.lblOlvideContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvideContra_LinkClicked);
            // 
            // chkMostrarContra
            // 
            this.chkMostrarContra.AutoSize = true;
            this.chkMostrarContra.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarContra.Location = new System.Drawing.Point(452, 657);
            this.chkMostrarContra.Name = "chkMostrarContra";
            this.chkMostrarContra.Size = new System.Drawing.Size(226, 25);
            this.chkMostrarContra.TabIndex = 14;
            this.chkMostrarContra.Text = "Mostrar Contraseña";
            this.chkMostrarContra.UseVisualStyleBackColor = true;
            this.chkMostrarContra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "NUMERO DE IDENTIDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "CONTRASEÑA";
            // 
            // picImagotipo
            // 
            this.picImagotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.picImagotipo.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.logoredm2;
            this.picImagotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picImagotipo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picImagotipo.Location = new System.Drawing.Point(0, 0);
            this.picImagotipo.Name = "picImagotipo";
            this.picImagotipo.Size = new System.Drawing.Size(859, 1080);
            this.picImagotipo.TabIndex = 22;
            this.picImagotipo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaGestorEscolar.Properties.Resources.contra_2;
            this.pictureBox3.Location = new System.Drawing.Point(360, 593);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaGestorEscolar.Properties.Resources.Usuario;
            this.pictureBox2.Location = new System.Drawing.Point(360, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // IfrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IfrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO DE SESIÓN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtdentidad;
        private System.Windows.Forms.TextBox txtContrase;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkMostrarContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblOlvideContra;
        private AltoControls.AltoButton btnIngresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picImagotipo;
        private AltoControls.AltoButton btnSalir;
    }
}