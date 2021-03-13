
namespace SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas
{
    partial class Registro_Datos_Notas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.btnMostarCuadroN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotaProm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.txtIdClase = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorPrvIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrvIdentidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de Notas ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(444, 231);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentidad.MaxLength = 13;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(232, 35);
            this.txtIdentidad.TabIndex = 1;
            this.txtIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentidad.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged);
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarNota.FlatAppearance.BorderSize = 0;
            this.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNota.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNota.Location = new System.Drawing.Point(847, 53);
            this.btnAgregarNota.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(171, 41);
            this.btnAgregarNota.TabIndex = 2;
            this.btnAgregarNota.Text = "Agregar Nota";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificarNota.FlatAppearance.BorderSize = 0;
            this.btnModificarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarNota.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarNota.Location = new System.Drawing.Point(847, 129);
            this.btnModificarNota.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(171, 41);
            this.btnModificarNota.TabIndex = 3;
            this.btnModificarNota.Text = "Modificar Nota";
            this.btnModificarNota.UseVisualStyleBackColor = false;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnMostarCuadroN
            // 
            this.btnMostarCuadroN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMostarCuadroN.FlatAppearance.BorderSize = 0;
            this.btnMostarCuadroN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostarCuadroN.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMostarCuadroN.Location = new System.Drawing.Point(805, 755);
            this.btnMostarCuadroN.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostarCuadroN.Name = "btnMostarCuadroN";
            this.btnMostarCuadroN.Size = new System.Drawing.Size(248, 41);
            this.btnMostarCuadroN.TabIndex = 4;
            this.btnMostarCuadroN.Text = "Ver Cuadro de Notas";
            this.btnMostarCuadroN.UseVisualStyleBackColor = false;
            this.btnMostarCuadroN.Click += new System.EventHandler(this.btnMostarCuadroN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1014, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sección:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSeccion
            // 
            this.txtSeccion.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.Location = new System.Drawing.Point(1137, 234);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.ReadOnly = true;
            this.txtSeccion.Size = new System.Drawing.Size(130, 35);
            this.txtSeccion.TabIndex = 6;
            this.txtSeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre del Alumno(a):";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(585, 334);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(485, 35);
            this.txtNombreAlumno.TabIndex = 8;
            this.txtNombreAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAlumno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nota Primer Parcial:";
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(660, 53);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota1.MaxLength = 3;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(104, 35);
            this.txtNota1.TabIndex = 10;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Segundo Parcial:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(660, 139);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota3.MaxLength = 3;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(104, 35);
            this.txtNota3.TabIndex = 12;
            this.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nota Promedio:";
            // 
            // txtNotaProm
            // 
            this.txtNotaProm.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaProm.Location = new System.Drawing.Point(660, 231);
            this.txtNotaProm.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaProm.MaxLength = 3;
            this.txtNotaProm.Name = "txtNotaProm";
            this.txtNotaProm.Size = new System.Drawing.Size(104, 35);
            this.txtNotaProm.TabIndex = 16;
            this.txtNotaProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotaProm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotaProm_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tercer Parcial:";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(252, 139);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota2.MaxLength = 3;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(104, 35);
            this.txtNota2.TabIndex = 14;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // txtNota4
            // 
            this.txtNota4.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(252, 230);
            this.txtNota4.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota4.MaxLength = 3;
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(104, 35);
            this.txtNota4.TabIndex = 19;
            this.txtNota4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota4_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cuarto Parcial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(746, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Curso:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(848, 235);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(130, 35);
            this.txtCurso.TabIndex = 20;
            this.txtCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(541, 755);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 41);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.Tomato;
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.Location = new System.Drawing.Point(847, 197);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(171, 41);
            this.btnCambiarEstado.TabIndex = 23;
            this.btnCambiarEstado.Text = "Eliminar";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            // 
            // txtIdClase
            // 
            this.txtIdClase.Font = new System.Drawing.Font("Balsamiq Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClase.Location = new System.Drawing.Point(252, 53);
            this.txtIdClase.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdClase.MaxLength = 3;
            this.txtIdClase.Name = "txtIdClase";
            this.txtIdClase.Size = new System.Drawing.Size(104, 35);
            this.txtIdClase.TabIndex = 25;
            this.txtIdClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdClase_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "ID Clase:";
            // 
            // errorPrvIdentidad
            // 
            this.errorPrvIdentidad.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNota1);
            this.groupBox2.Controls.Add(this.btnAgregarNota);
            this.groupBox2.Controls.Add(this.txtIdClase);
            this.groupBox2.Controls.Add(this.btnModificarNota);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnCambiarEstado);
            this.groupBox2.Controls.Add(this.txtNota3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNota2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNota4);
            this.groupBox2.Controls.Add(this.txtNotaProm);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(289, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 309);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese las Notas:";
            // 
            // Registro_Datos_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostarCuadroN);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_Datos_Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Datos_Notas";
            this.Load += new System.EventHandler(this.Registro_Datos_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorPrvIdentidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Button btnModificarNota;
        private System.Windows.Forms.Button btnMostarCuadroN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotaProm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.TextBox txtIdClase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorPrvIdentidad;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}