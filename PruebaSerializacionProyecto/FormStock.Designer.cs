
namespace PruebaSerializacionProyecto
{
    partial class FormStock
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.barraProgresoSuper = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.barraProgresoDiesel = new System.Windows.Forms.ProgressBar();
            this.barraProgresoPremium = new System.Windows.Forms.ProgressBar();
            this.barraProgresoUltra = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stockSuperActual = new System.Windows.Forms.TextBox();
            this.stockDieselActual = new System.Windows.Forms.TextBox();
            this.stockPremiumActual = new System.Windows.Forms.TextBox();
            this.stockUltraActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(496, 312);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 34);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(374, 312);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(81, 34);
            this.Regresar.TabIndex = 27;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // barraProgresoSuper
            // 
            this.barraProgresoSuper.Location = new System.Drawing.Point(315, 69);
            this.barraProgresoSuper.Maximum = 1000;
            this.barraProgresoSuper.Name = "barraProgresoSuper";
            this.barraProgresoSuper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoSuper.Size = new System.Drawing.Size(209, 34);
            this.barraProgresoSuper.Step = 1;
            this.barraProgresoSuper.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Stock";
            // 
            // barraProgresoDiesel
            // 
            this.barraProgresoDiesel.Location = new System.Drawing.Point(315, 119);
            this.barraProgresoDiesel.Maximum = 1000;
            this.barraProgresoDiesel.Name = "barraProgresoDiesel";
            this.barraProgresoDiesel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoDiesel.Size = new System.Drawing.Size(209, 34);
            this.barraProgresoDiesel.Step = 1;
            this.barraProgresoDiesel.TabIndex = 30;
            // 
            // barraProgresoPremium
            // 
            this.barraProgresoPremium.Location = new System.Drawing.Point(315, 168);
            this.barraProgresoPremium.Maximum = 1000;
            this.barraProgresoPremium.Name = "barraProgresoPremium";
            this.barraProgresoPremium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoPremium.Size = new System.Drawing.Size(209, 34);
            this.barraProgresoPremium.Step = 1;
            this.barraProgresoPremium.TabIndex = 31;
            // 
            // barraProgresoUltra
            // 
            this.barraProgresoUltra.Location = new System.Drawing.Point(315, 221);
            this.barraProgresoUltra.Maximum = 1000;
            this.barraProgresoUltra.Name = "barraProgresoUltra";
            this.barraProgresoUltra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoUltra.Size = new System.Drawing.Size(209, 34);
            this.barraProgresoUltra.Step = 1;
            this.barraProgresoUltra.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Super:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Diesel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "Premium:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ultra Diesel:";
            // 
            // stockSuperActual
            // 
            this.stockSuperActual.Location = new System.Drawing.Point(201, 77);
            this.stockSuperActual.Name = "stockSuperActual";
            this.stockSuperActual.Size = new System.Drawing.Size(67, 20);
            this.stockSuperActual.TabIndex = 37;
            // 
            // stockDieselActual
            // 
            this.stockDieselActual.Location = new System.Drawing.Point(201, 127);
            this.stockDieselActual.Name = "stockDieselActual";
            this.stockDieselActual.Size = new System.Drawing.Size(67, 20);
            this.stockDieselActual.TabIndex = 38;
            // 
            // stockPremiumActual
            // 
            this.stockPremiumActual.Location = new System.Drawing.Point(201, 176);
            this.stockPremiumActual.Name = "stockPremiumActual";
            this.stockPremiumActual.Size = new System.Drawing.Size(67, 20);
            this.stockPremiumActual.TabIndex = 39;
            // 
            // stockUltraActual
            // 
            this.stockUltraActual.Location = new System.Drawing.Point(201, 229);
            this.stockUltraActual.Name = "stockUltraActual";
            this.stockUltraActual.Size = new System.Drawing.Size(67, 20);
            this.stockUltraActual.TabIndex = 40;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.stockUltraActual);
            this.Controls.Add(this.stockPremiumActual);
            this.Controls.Add(this.stockDieselActual);
            this.Controls.Add(this.stockSuperActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraProgresoUltra);
            this.Controls.Add(this.barraProgresoPremium);
            this.Controls.Add(this.barraProgresoDiesel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraProgresoSuper);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.ProgressBar barraProgresoSuper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar barraProgresoDiesel;
        private System.Windows.Forms.ProgressBar barraProgresoPremium;
        private System.Windows.Forms.ProgressBar barraProgresoUltra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stockSuperActual;
        private System.Windows.Forms.TextBox stockDieselActual;
        private System.Windows.Forms.TextBox stockPremiumActual;
        private System.Windows.Forms.TextBox stockUltraActual;
    }
}