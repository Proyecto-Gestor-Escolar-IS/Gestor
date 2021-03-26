
namespace SistemaGestorEscolar.Modulo_de_Cursos
{
    partial class IGestionCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGestionCursos));
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnActualizarCurso = new AltoControls.AltoButton();
            this.btnRegistrarCurso = new AltoControls.AltoButton();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDgv = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnActualizarDgv = new AltoControls.AltoButton();
            this.grbPrincipal.SuspendLayout();
            this.grbDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.btnEliminar);
            this.grbPrincipal.Controls.Add(this.btnActualizarCurso);
            this.grbPrincipal.Controls.Add(this.btnRegistrarCurso);
            this.grbPrincipal.Controls.Add(this.txtNombreCurso);
            this.grbPrincipal.Controls.Add(this.label4);
            this.grbPrincipal.Controls.Add(this.txtPrecio);
            this.grbPrincipal.Controls.Add(this.label3);
            this.grbPrincipal.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrincipal.Location = new System.Drawing.Point(47, 140);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(846, 840);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnEliminar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnEliminar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnEliminar.Location = new System.Drawing.Point(567, 506);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(241, 58);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Transparency = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizarCurso
            // 
            this.btnActualizarCurso.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnActualizarCurso.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnActualizarCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizarCurso.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCurso.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCurso.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnActualizarCurso.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnActualizarCurso.Location = new System.Drawing.Point(567, 376);
            this.btnActualizarCurso.Name = "btnActualizarCurso";
            this.btnActualizarCurso.Radius = 10;
            this.btnActualizarCurso.Size = new System.Drawing.Size(241, 58);
            this.btnActualizarCurso.Stroke = false;
            this.btnActualizarCurso.StrokeColor = System.Drawing.Color.Gray;
            this.btnActualizarCurso.TabIndex = 9;
            this.btnActualizarCurso.Text = "Actualizar";
            this.btnActualizarCurso.Transparency = false;
            this.btnActualizarCurso.Click += new System.EventHandler(this.btnActualizarCurso_Click);
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnRegistrarCurso.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnRegistrarCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistrarCurso.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCurso.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarCurso.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnRegistrarCurso.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnRegistrarCurso.Location = new System.Drawing.Point(567, 263);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Radius = 10;
            this.btnRegistrarCurso.Size = new System.Drawing.Size(241, 58);
            this.btnRegistrarCurso.Stroke = false;
            this.btnRegistrarCurso.StrokeColor = System.Drawing.Color.Gray;
            this.btnRegistrarCurso.TabIndex = 8;
            this.btnRegistrarCurso.Text = "Registrar";
            this.btnRegistrarCurso.Transparency = false;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(226, 386);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(232, 31);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre curso";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(226, 484);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 31);
            this.txtPrecio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE CURSOS";
            // 
            // grbDgv
            // 
            this.grbDgv.Controls.Add(this.btnActualizarDgv);
            this.grbDgv.Controls.Add(this.label2);
            this.grbDgv.Controls.Add(this.dgvCursos);
            this.grbDgv.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDgv.Location = new System.Drawing.Point(908, 140);
            this.grbDgv.Name = "grbDgv";
            this.grbDgv.Size = new System.Drawing.Size(715, 840);
            this.grbDgv.TabIndex = 3;
            this.grbDgv.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cursos";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(50, 184);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(629, 628);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // btnActualizarDgv
            // 
            this.btnActualizarDgv.Active1 = System.Drawing.Color.Transparent;
            this.btnActualizarDgv.Active2 = System.Drawing.Color.Transparent;
            this.btnActualizarDgv.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarDgv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarDgv.BackgroundImage")));
            this.btnActualizarDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarDgv.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizarDgv.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizarDgv.ForeColor = System.Drawing.Color.Transparent;
            this.btnActualizarDgv.Inactive1 = System.Drawing.Color.Transparent;
            this.btnActualizarDgv.Inactive2 = System.Drawing.Color.Transparent;
            this.btnActualizarDgv.Location = new System.Drawing.Point(50, 132);
            this.btnActualizarDgv.Name = "btnActualizarDgv";
            this.btnActualizarDgv.Radius = 10;
            this.btnActualizarDgv.Size = new System.Drawing.Size(47, 46);
            this.btnActualizarDgv.Stroke = false;
            this.btnActualizarDgv.StrokeColor = System.Drawing.Color.Gray;
            this.btnActualizarDgv.TabIndex = 4;
            this.btnActualizarDgv.Transparency = false;
            this.btnActualizarDgv.Click += new System.EventHandler(this.btnActualizarDgv_Click);
            // 
            // IGestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.grbDgv);
            this.Controls.Add(this.grbPrincipal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IGestionCursos";
            this.Text = "IGestionCursos";
            this.Load += new System.EventHandler(this.IGestionCursos_Load);
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            this.grbDgv.ResumeLayout(false);
            this.grbDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnActualizarCurso;
        private AltoControls.AltoButton btnRegistrarCurso;
        private AltoControls.AltoButton btnActualizarDgv;
    }
}