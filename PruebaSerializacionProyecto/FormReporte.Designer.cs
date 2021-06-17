
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(192, 416);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(108, 42);
            this.Regresar.TabIndex = 29;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(341, 416);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label2.Location = new System.Drawing.Point(167, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seleccione el Empleado para generar el Reporte:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(192, 126);
            this.Seleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Seleccionar.Location = new System.Drawing.Point(144, 102);
            this.Seleccionar.Margin = new System.Windows.Forms.Padding(2);
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
            this.ComboBoxEmpleados.Location = new System.Drawing.Point(192, 80);
            this.ComboBoxEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxEmpleados.Location = new System.Drawing.Point(144, 65);
            this.ComboBoxEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxEmpleados.Name = "ComboBoxEmpleados";
            this.ComboBoxEmpleados.Size = new System.Drawing.Size(257, 24);
            this.ComboBoxEmpleados.TabIndex = 30;
            // 
            // listReporte
            // 
            this.listReporte.FormattingEnabled = true;
            this.listReporte.ItemHeight = 16;
            this.listReporte.Location = new System.Drawing.Point(53, 204);
            this.listReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listReporte.Location = new System.Drawing.Point(28, 150);
            this.listReporte.Margin = new System.Windows.Forms.Padding(2);
            this.listReporte.Name = "listReporte";
            this.listReporte.Size = new System.Drawing.Size(557, 196);
            this.listReporte.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(50, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre Empleado";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(189, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo Combustible";
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(338, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Valor Pesos";
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(456, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cantidad Litros";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ClientSize = new System.Drawing.Size(535, 406);
            this.Controls.Add(this.listReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.ComboBoxEmpleados);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}