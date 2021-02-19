
namespace SistemaGestorEscolar
{
    partial class IRegistroPago
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDatosPago = new System.Windows.Forms.GroupBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.chkDescuento = new System.Windows.Forms.CheckBox();
            this.txtSaldoDisponible = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtFechaFacturacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdentidadEstudiante = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.errorIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpDatosPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PAGOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del Alumno(a)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de Factura";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Identidad del Estudiante";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Facturación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grpDatosPago
            // 
            this.grpDatosPago.Controls.Add(this.textBox1);
            this.grpDatosPago.Controls.Add(this.label8);
            this.grpDatosPago.Controls.Add(this.txtDescuento);
            this.grpDatosPago.Controls.Add(this.chkDescuento);
            this.grpDatosPago.Controls.Add(this.txtSaldoDisponible);
            this.grpDatosPago.Controls.Add(this.txtTotalPagar);
            this.grpDatosPago.Controls.Add(this.txtFechaFacturacion);
            this.grpDatosPago.Controls.Add(this.label7);
            this.grpDatosPago.Controls.Add(this.label9);
            this.grpDatosPago.Controls.Add(this.txtNoFactura);
            this.grpDatosPago.Controls.Add(this.txtNombreEstudiante);
            this.grpDatosPago.Controls.Add(this.txtIdentidadEstudiante);
            this.grpDatosPago.Controls.Add(this.textBox2);
            this.grpDatosPago.Controls.Add(this.label6);
            this.grpDatosPago.Controls.Add(this.label2);
            this.grpDatosPago.Controls.Add(this.label3);
            this.grpDatosPago.Controls.Add(this.label5);
            this.grpDatosPago.Controls.Add(this.label4);
            this.grpDatosPago.Location = new System.Drawing.Point(102, 131);
            this.grpDatosPago.Name = "grpDatosPago";
            this.grpDatosPago.Size = new System.Drawing.Size(1434, 534);
            this.grpDatosPago.TabIndex = 15;
            this.grpDatosPago.TabStop = false;
            this.grpDatosPago.Enter += new System.EventHandler(this.grpDatosPago_Enter);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(935, 306);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(173, 28);
            this.txtDescuento.TabIndex = 24;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkDescuento
            // 
            this.chkDescuento.AutoSize = true;
            this.chkDescuento.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescuento.Location = new System.Drawing.Point(919, 266);
            this.chkDescuento.Name = "chkDescuento";
            this.chkDescuento.Size = new System.Drawing.Size(202, 23);
            this.chkDescuento.TabIndex = 23;
            this.chkDescuento.Text = "APLICAR DESCUENTO";
            this.chkDescuento.UseVisualStyleBackColor = true;
            this.chkDescuento.CheckedChanged += new System.EventHandler(this.chkDescuento_CheckedChanged);
            // 
            // txtSaldoDisponible
            // 
            this.txtSaldoDisponible.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoDisponible.Location = new System.Drawing.Point(530, 422);
            this.txtSaldoDisponible.Name = "txtSaldoDisponible";
            this.txtSaldoDisponible.ReadOnly = true;
            this.txtSaldoDisponible.Size = new System.Drawing.Size(187, 28);
            this.txtSaldoDisponible.TabIndex = 22;
            this.txtSaldoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaldoDisponible.TextChanged += new System.EventHandler(this.txtSaldoDisponible_TextChanged);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(530, 374);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(187, 28);
            this.txtTotalPagar.TabIndex = 21;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // txtFechaFacturacion
            // 
            this.txtFechaFacturacion.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFacturacion.Location = new System.Drawing.Point(530, 327);
            this.txtFechaFacturacion.Name = "txtFechaFacturacion";
            this.txtFechaFacturacion.ReadOnly = true;
            this.txtFechaFacturacion.Size = new System.Drawing.Size(187, 28);
            this.txtFechaFacturacion.TabIndex = 20;
            this.txtFechaFacturacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaFacturacion.TextChanged += new System.EventHandler(this.txtFechaFacturacion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Saldo Disponible";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total a Pagar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(530, 275);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(70, 28);
            this.txtNoFactura.TabIndex = 17;
            this.txtNoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoFactura.TextChanged += new System.EventHandler(this.txtNoFactura_TextChanged);
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(593, 151);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.ReadOnly = true;
            this.txtNombreEstudiante.Size = new System.Drawing.Size(341, 28);
            this.txtNombreEstudiante.TabIndex = 16;
            this.txtNombreEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdentidadEstudiante
            // 
            this.txtIdentidadEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidadEstudiante.Location = new System.Drawing.Point(778, 55);
            this.txtIdentidadEstudiante.Name = "txtIdentidadEstudiante";
            this.txtIdentidadEstudiante.Size = new System.Drawing.Size(279, 28);
            this.txtIdentidadEstudiante.TabIndex = 15;
            this.txtIdentidadEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentidadEstudiante.TextChanged += new System.EventHandler(this.txtIdentidadEstudiante_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(778, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(279, 28);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Padre, Madre o Encargado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPago.Location = new System.Drawing.Point(678, 867);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(272, 53);
            this.btnRegistrarPago.TabIndex = 16;
            this.btnRegistrarPago.Text = "REGISTRAR PAGO";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            // 
            // errorIdentidad
            // 
            this.errorIdentidad.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(921, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "MONTO A PAGAR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(934, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 28);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IRegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.grpDatosPago);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IRegistroPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRegistroPago";
            this.Load += new System.EventHandler(this.IRegistroPago_Load);
            this.grpDatosPago.ResumeLayout(false);
            this.grpDatosPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDatosPago;
        private System.Windows.Forms.TextBox txtIdentidadEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.TextBox txtFechaFacturacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtSaldoDisponible;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.CheckBox chkDescuento;
        private System.Windows.Forms.ErrorProvider errorIdentidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}