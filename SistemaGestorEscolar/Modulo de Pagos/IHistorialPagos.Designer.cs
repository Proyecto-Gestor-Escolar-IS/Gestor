
namespace SistemaGestorEscolar.Modulo_de_Pagos
{
    partial class IHistorialPagos
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
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoIdentidadEstudiante = new System.Windows.Forms.TextBox();
            this.txtNombrePadre = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.btnConsultarID = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvHistorialPagos = new System.Windows.Forms.DataGridView();
            this.lblPendientePago = new System.Windows.Forms.Label();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPagos)).BeginInit();
            this.grpDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTA DE PAGOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(1263, 51);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(278, 31);
            this.lblFechaActual.TabIndex = 2;
            this.lblFechaActual.Text = "Fecha Actual: --/--/----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el número de Identidad del Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Padre, Madre o Encargado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre del Estudiante";
            // 
            // txtNoIdentidadEstudiante
            // 
            this.txtNoIdentidadEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoIdentidadEstudiante.Location = new System.Drawing.Point(657, 120);
            this.txtNoIdentidadEstudiante.Name = "txtNoIdentidadEstudiante";
            this.txtNoIdentidadEstudiante.Size = new System.Drawing.Size(369, 28);
            this.txtNoIdentidadEstudiante.TabIndex = 6;
            this.txtNoIdentidadEstudiante.TextChanged += new System.EventHandler(this.txtNoIdentidadEstudiante_TextChanged);
            // 
            // txtNombrePadre
            // 
            this.txtNombrePadre.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePadre.Location = new System.Drawing.Point(561, 177);
            this.txtNombrePadre.Name = "txtNombrePadre";
            this.txtNombrePadre.ReadOnly = true;
            this.txtNombrePadre.Size = new System.Drawing.Size(465, 28);
            this.txtNombrePadre.TabIndex = 7;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(344, 237);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.ReadOnly = true;
            this.txtNombreEstudiante.Size = new System.Drawing.Size(465, 28);
            this.txtNombreEstudiante.TabIndex = 8;
            // 
            // btnConsultarID
            // 
            this.btnConsultarID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnConsultarID.FlatAppearance.BorderSize = 0;
            this.btnConsultarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarID.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarID.Location = new System.Drawing.Point(1073, 115);
            this.btnConsultarID.Name = "btnConsultarID";
            this.btnConsultarID.Size = new System.Drawing.Size(179, 33);
            this.btnConsultarID.TabIndex = 9;
            this.btnConsultarID.Text = "CONSULTAR";
            this.btnConsultarID.UseVisualStyleBackColor = false;
            this.btnConsultarID.Click += new System.EventHandler(this.btnConsultarID_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1402, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(179, 33);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(1207, 234);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(179, 33);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvHistorialPagos
            // 
            this.dgvHistorialPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPagos.Location = new System.Drawing.Point(6, 14);
            this.dgvHistorialPagos.Name = "dgvHistorialPagos";
            this.dgvHistorialPagos.ReadOnly = true;
            this.dgvHistorialPagos.RowTemplate.ReadOnly = true;
            this.dgvHistorialPagos.Size = new System.Drawing.Size(1572, 519);
            this.dgvHistorialPagos.TabIndex = 12;
            this.dgvHistorialPagos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialPagos_CellContentDoubleClick);
            // 
            // lblPendientePago
            // 
            this.lblPendientePago.AutoSize = true;
            this.lblPendientePago.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientePago.Location = new System.Drawing.Point(22, 889);
            this.lblPendientePago.Name = "lblPendientePago";
            this.lblPendientePago.Size = new System.Drawing.Size(392, 35);
            this.lblPendientePago.TabIndex = 13;
            this.lblPendientePago.Text = "Pendiente de Pago: Lps. 0.00";
            // 
            // grpDataGrid
            // 
            this.grpDataGrid.Controls.Add(this.dgvHistorialPagos);
            this.grpDataGrid.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataGrid.Location = new System.Drawing.Point(28, 304);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(1584, 539);
            this.grpDataGrid.TabIndex = 14;
            this.grpDataGrid.TabStop = false;
            // 
            // IHistorialPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.grpDataGrid);
            this.Controls.Add(this.lblPendientePago);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultarID);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.txtNombrePadre);
            this.Controls.Add(this.txtNoIdentidadEstudiante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IHistorialPagos";
            this.Text = "IHistorialPagos";
            this.Load += new System.EventHandler(this.IHistorialPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPagos)).EndInit();
            this.grpDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoIdentidadEstudiante;
        private System.Windows.Forms.TextBox txtNombrePadre;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Button btnConsultarID;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvHistorialPagos;
        private System.Windows.Forms.Label lblPendientePago;
        private System.Windows.Forms.GroupBox grpDataGrid;
    }
}