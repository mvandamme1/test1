namespace Graden
{
    partial class frmTermometer
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
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.lblGradenCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtGradenCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(251, 127);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(84, 109);
            this.btnSluiten.TabIndex = 0;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(139, 127);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(84, 109);
            this.btnWissen.TabIndex = 1;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Location = new System.Drawing.Point(29, 125);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(84, 109);
            this.btnBerekenen.TabIndex = 2;
            this.btnBerekenen.Text = "Berekenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // lblGradenCelsius
            // 
            this.lblGradenCelsius.AutoSize = true;
            this.lblGradenCelsius.Location = new System.Drawing.Point(45, 46);
            this.lblGradenCelsius.Name = "lblGradenCelsius";
            this.lblGradenCelsius.Size = new System.Drawing.Size(78, 13);
            this.lblGradenCelsius.TabIndex = 3;
            this.lblGradenCelsius.Text = "Graden Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(45, 80);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 4;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // txtGradenCelsius
            // 
            this.txtGradenCelsius.Location = new System.Drawing.Point(163, 43);
            this.txtGradenCelsius.Name = "txtGradenCelsius";
            this.txtGradenCelsius.Size = new System.Drawing.Size(160, 20);
            this.txtGradenCelsius.TabIndex = 5;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(163, 77);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(160, 20);
            this.txtFahrenheit.TabIndex = 6;
            // 
            // frmTermometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.Maroon;

            this.ClientSize = new System.Drawing.Size(347, 246);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtGradenCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblGradenCelsius);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnSluiten);
            this.Name = "frmTermometer";
            this.Text = "Thermometer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnBerekenen;
        private System.Windows.Forms.Label lblGradenCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtGradenCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
    }
}

