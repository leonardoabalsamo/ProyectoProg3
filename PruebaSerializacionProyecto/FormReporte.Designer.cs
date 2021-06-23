
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
            this.gridReporte = new System.Windows.Forms.DataGridView();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantLitros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(133, 396);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(81, 34);
            this.Regresar.TabIndex = 29;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(245, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 34);
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
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seleccione el Empleado para generar el Reporte:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(31, 98);
            this.Seleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(193, 28);
            this.Seleccionar.TabIndex = 31;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // ComboBoxEmpleados
            // 
            this.ComboBoxEmpleados.FormattingEnabled = true;
            this.ComboBoxEmpleados.Location = new System.Drawing.Point(31, 68);
            this.ComboBoxEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxEmpleados.Name = "ComboBoxEmpleados";
            this.ComboBoxEmpleados.Size = new System.Drawing.Size(194, 21);
            this.ComboBoxEmpleados.TabIndex = 30;
            // 
            // gridReporte
            // 
            this.gridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEmpleado,
            this.tipoCombustible,
            this.valorPesos,
            this.cantLitros});
            this.gridReporte.Location = new System.Drawing.Point(20, 145);
            this.gridReporte.Name = "gridReporte";
            this.gridReporte.Size = new System.Drawing.Size(440, 223);
            this.gridReporte.TabIndex = 40;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.HeaderText = "Nombre Empleado";
            this.nombreEmpleado.Name = "nombreEmpleado";
            // 
            // tipoCombustible
            // 
            this.tipoCombustible.HeaderText = "Tipo Combustible";
            this.tipoCombustible.Name = "tipoCombustible";
            // 
            // valorPesos
            // 
            this.valorPesos.HeaderText = "Valor de Venta ($)";
            this.valorPesos.Name = "valorPesos";
            // 
            // cantLitros
            // 
            this.cantLitros.HeaderText = "Venta en litros (cantidad)";
            this.cantLitros.Name = "cantLitros";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 442);
            this.Controls.Add(this.gridReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.ComboBoxEmpleados);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.ComboBox ComboBoxEmpleados;
        private System.Windows.Forms.DataGridView gridReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantLitros;
    }
}