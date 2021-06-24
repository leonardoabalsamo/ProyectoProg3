
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.barraProgresoSuper = new System.Windows.Forms.ProgressBar();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(27, 207);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(68, 34);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(362, 207);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(94, 34);
            this.Regresar.TabIndex = 27;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // barraProgresoSuper
            // 
            this.barraProgresoSuper.Location = new System.Drawing.Point(231, 32);
            this.barraProgresoSuper.Maximum = 10000;
            this.barraProgresoSuper.Name = "barraProgresoSuper";
            this.barraProgresoSuper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoSuper.Size = new System.Drawing.Size(225, 22);
            this.barraProgresoSuper.Step = 1;
            this.barraProgresoSuper.TabIndex = 28;
            // 
            // barraProgresoDiesel
            // 
            this.barraProgresoDiesel.Location = new System.Drawing.Point(231, 66);
            this.barraProgresoDiesel.Maximum = 10000;
            this.barraProgresoDiesel.Name = "barraProgresoDiesel";
            this.barraProgresoDiesel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoDiesel.Size = new System.Drawing.Size(225, 21);
            this.barraProgresoDiesel.Step = 1;
            this.barraProgresoDiesel.TabIndex = 30;
            // 
            // barraProgresoPremium
            // 
            this.barraProgresoPremium.Location = new System.Drawing.Point(231, 99);
            this.barraProgresoPremium.Maximum = 10000;
            this.barraProgresoPremium.Name = "barraProgresoPremium";
            this.barraProgresoPremium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoPremium.Size = new System.Drawing.Size(225, 21);
            this.barraProgresoPremium.Step = 1;
            this.barraProgresoPremium.TabIndex = 31;
            // 
            // barraProgresoUltra
            // 
            this.barraProgresoUltra.Location = new System.Drawing.Point(231, 135);
            this.barraProgresoUltra.Maximum = 10000;
            this.barraProgresoUltra.Name = "barraProgresoUltra";
            this.barraProgresoUltra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgresoUltra.Size = new System.Drawing.Size(225, 19);
            this.barraProgresoUltra.Step = 1;
            this.barraProgresoUltra.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Super:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(64, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Diesel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(47, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Premium:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ultra Diesel:";
            // 
            // stockSuperActual
            // 
            this.stockSuperActual.Enabled = false;
            this.stockSuperActual.Location = new System.Drawing.Point(128, 33);
            this.stockSuperActual.Name = "stockSuperActual";
            this.stockSuperActual.Size = new System.Drawing.Size(67, 20);
            this.stockSuperActual.TabIndex = 37;
            // 
            // stockDieselActual
            // 
            this.stockDieselActual.Enabled = false;
            this.stockDieselActual.Location = new System.Drawing.Point(128, 66);
            this.stockDieselActual.Name = "stockDieselActual";
            this.stockDieselActual.Size = new System.Drawing.Size(67, 20);
            this.stockDieselActual.TabIndex = 38;
            // 
            // stockPremiumActual
            // 
            this.stockPremiumActual.Enabled = false;
            this.stockPremiumActual.Location = new System.Drawing.Point(128, 99);
            this.stockPremiumActual.Name = "stockPremiumActual";
            this.stockPremiumActual.Size = new System.Drawing.Size(67, 20);
            this.stockPremiumActual.TabIndex = 39;
            // 
            // stockUltraActual
            // 
            this.stockUltraActual.Enabled = false;
            this.stockUltraActual.Location = new System.Drawing.Point(128, 133);
            this.stockUltraActual.Name = "stockUltraActual";
            this.stockUltraActual.Size = new System.Drawing.Size(67, 20);
            this.stockUltraActual.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "lts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "lts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "lts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "lts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "0 lts <------------------> 10000 lts";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 253);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.barraProgresoSuper);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStock";
            this.Text = "Control de Stock";
            this.Activated += new System.EventHandler(this.FormStock_Activated);
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.ProgressBar barraProgresoSuper;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}