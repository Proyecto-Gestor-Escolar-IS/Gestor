
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
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualización = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDgv = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.grbPrincipal.SuspendLayout();
            this.grbDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.btnEliminarCurso);
            this.grbPrincipal.Controls.Add(this.txtNombreCurso);
            this.grbPrincipal.Controls.Add(this.label4);
            this.grbPrincipal.Controls.Add(this.txtPrecio);
            this.grbPrincipal.Controls.Add(this.label3);
            this.grbPrincipal.Controls.Add(this.btnActualización);
            this.grbPrincipal.Controls.Add(this.btnRegistro);
            this.grbPrincipal.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrincipal.Location = new System.Drawing.Point(47, 140);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(846, 840);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(567, 573);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(241, 55);
            this.btnEliminarCurso.TabIndex = 7;
            this.btnEliminarCurso.Text = "Eliminar curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
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
            // btnActualización
            // 
            this.btnActualización.Location = new System.Drawing.Point(567, 424);
            this.btnActualización.Name = "btnActualización";
            this.btnActualización.Size = new System.Drawing.Size(241, 55);
            this.btnActualización.TabIndex = 2;
            this.btnActualización.Text = "Actualizar curso";
            this.btnActualización.UseVisualStyleBackColor = true;
            this.btnActualización.Click += new System.EventHandler(this.btnActualización_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(567, 283);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(241, 55);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registrar curso";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
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
            this.grbDgv.Controls.Add(this.btnActualizar);
            this.grbDgv.Controls.Add(this.label2);
            this.grbDgv.Controls.Add(this.dgvCursos);
            this.grbDgv.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDgv.Location = new System.Drawing.Point(908, 140);
            this.grbDgv.Name = "grbDgv";
            this.grbDgv.Size = new System.Drawing.Size(715, 840);
            this.grbDgv.TabIndex = 3;
            this.grbDgv.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(50, 133);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(48, 45);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 70);
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
        private System.Windows.Forms.Button btnActualización;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminarCurso;
    }
}