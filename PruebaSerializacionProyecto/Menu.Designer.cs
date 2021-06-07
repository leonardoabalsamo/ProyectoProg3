
namespace PruebaSerializacionProyecto
{
    partial class Menu
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
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.regresaInicio = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnDescarga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la Opción:";
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(41, 104);
            this.btnCarga.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(256, 64);
            this.btnCarga.TabIndex = 1;
            this.btnCarga.Text = "Carga de combustible";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(350, 349);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(188, 60);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // regresaInicio
            // 
            this.regresaInicio.Location = new System.Drawing.Point(109, 349);
            this.regresaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.regresaInicio.Name = "regresaInicio";
            this.regresaInicio.Size = new System.Drawing.Size(188, 60);
            this.regresaInicio.TabIndex = 3;
            this.regresaInicio.Text = "Regresar";
            this.regresaInicio.UseVisualStyleBackColor = true;
            this.regresaInicio.Click += new System.EventHandler(this.regresaInicio_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(41, 212);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(256, 64);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(350, 212);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(256, 64);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnDescarga
            // 
            this.btnDescarga.Location = new System.Drawing.Point(350, 104);
            this.btnDescarga.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescarga.Name = "btnDescarga";
            this.btnDescarga.Size = new System.Drawing.Size(256, 64);
            this.btnDescarga.TabIndex = 6;
            this.btnDescarga.Text = "Descarga de combustible";
            this.btnDescarga.UseVisualStyleBackColor = true;
            this.btnDescarga.Click += new System.EventHandler(this.btnDescarga_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 433);
            this.Controls.Add(this.btnDescarga);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.regresaInicio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button regresaInicio;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnDescarga;
    }
}