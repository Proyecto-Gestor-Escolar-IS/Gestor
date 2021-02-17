
namespace SistemaGestorEscolar
{
    partial class InterfazGraficaPrincipal
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
            this.panSuperior = new System.Windows.Forms.Panel();
            this.panLateral = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panSuperior
            // 
            this.panSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperior.Location = new System.Drawing.Point(0, 0);
            this.panSuperior.Name = "panSuperior";
            this.panSuperior.Size = new System.Drawing.Size(1280, 45);
            this.panSuperior.TabIndex = 0;
            // 
            // panLateral
            // 
            this.panLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateral.Location = new System.Drawing.Point(0, 45);
            this.panLateral.Name = "panLateral";
            this.panLateral.Size = new System.Drawing.Size(285, 675);
            this.panLateral.TabIndex = 1;
            // 
            // InterfazGraficaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panLateral);
            this.Controls.Add(this.panSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazGraficaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazGraficaPrincipal";
            this.Load += new System.EventHandler(this.InterfazGraficaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuperior;
        private System.Windows.Forms.Panel panLateral;
    }
}