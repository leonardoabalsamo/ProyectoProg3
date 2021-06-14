
namespace PruebaSerializacionProyecto
{
    partial class FormReporte
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
            this.Regresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.ComboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.listReporte = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(38, 395);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(108, 42);
            this.Regresar.TabIndex = 29;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(187, 395);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 42);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seleccione el Empleado para generar el Reporte:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(38, 126);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(257, 34);
            this.Seleccionar.TabIndex = 31;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // ComboBoxEmpleados
            // 
            this.ComboBoxEmpleados.FormattingEnabled = true;
            this.ComboBoxEmpleados.Location = new System.Drawing.Point(38, 80);
            this.ComboBoxEmpleados.Name = "ComboBoxEmpleados";
            this.ComboBoxEmpleados.Size = new System.Drawing.Size(257, 24);
            this.ComboBoxEmpleados.TabIndex = 30;
            // 
            // listReporte
            // 
            this.listReporte.FormattingEnabled = true;
            this.listReporte.ItemHeight = 16;
            this.listReporte.Location = new System.Drawing.Point(38, 184);
            this.listReporte.Name = "listReporte";
            this.listReporte.Size = new System.Drawing.Size(257, 196);
            this.listReporte.TabIndex = 34;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 468);
            this.Controls.Add(this.listReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.ComboBoxEmpleados);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.ComboBox ComboBoxEmpleados;
        private System.Windows.Forms.ListBox listReporte;
    }
}