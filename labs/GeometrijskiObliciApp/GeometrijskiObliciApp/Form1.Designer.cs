
namespace GeometrijskiObliciApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblKvadrat = new System.Windows.Forms.Label();
            this.tbStranicaKvadrata = new System.Windows.Forms.TextBox();
            this.tbRadijusKruznice = new System.Windows.Forms.TextBox();
            this.lblKruznica = new System.Windows.Forms.Label();
            this.tbGeometrijskiOblici = new System.Windows.Forms.TextBox();
            this.lblGeoOblici = new System.Windows.Forms.Label();
            this.btnDodajKvadrat = new System.Windows.Forms.Button();
            this.btnDodajKruznicu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKvadrat
            // 
            this.lblKvadrat.AutoSize = true;
            this.lblKvadrat.Location = new System.Drawing.Point(34, 33);
            this.lblKvadrat.Name = "lblKvadrat";
            this.lblKvadrat.Size = new System.Drawing.Size(97, 15);
            this.lblKvadrat.TabIndex = 0;
            this.lblKvadrat.Text = "Stranica kvadrata";
            // 
            // tbStranicaKvadrata
            // 
            this.tbStranicaKvadrata.Location = new System.Drawing.Point(34, 60);
            this.tbStranicaKvadrata.Name = "tbStranicaKvadrata";
            this.tbStranicaKvadrata.Size = new System.Drawing.Size(171, 23);
            this.tbStranicaKvadrata.TabIndex = 1;
            // 
            // tbRadijusKruznice
            // 
            this.tbRadijusKruznice.Location = new System.Drawing.Point(34, 184);
            this.tbRadijusKruznice.Name = "tbRadijusKruznice";
            this.tbRadijusKruznice.Size = new System.Drawing.Size(171, 23);
            this.tbRadijusKruznice.TabIndex = 3;
            // 
            // lblKruznica
            // 
            this.lblKruznica.AutoSize = true;
            this.lblKruznica.Location = new System.Drawing.Point(34, 157);
            this.lblKruznica.Name = "lblKruznica";
            this.lblKruznica.Size = new System.Drawing.Size(95, 15);
            this.lblKruznica.TabIndex = 2;
            this.lblKruznica.Text = "Radijus kružnice:";
            // 
            // tbGeometrijskiOblici
            // 
            this.tbGeometrijskiOblici.Location = new System.Drawing.Point(269, 60);
            this.tbGeometrijskiOblici.Multiline = true;
            this.tbGeometrijskiOblici.Name = "tbGeometrijskiOblici";
            this.tbGeometrijskiOblici.Size = new System.Drawing.Size(256, 454);
            this.tbGeometrijskiOblici.TabIndex = 4;
            // 
            // lblGeoOblici
            // 
            this.lblGeoOblici.AutoSize = true;
            this.lblGeoOblici.Location = new System.Drawing.Point(269, 33);
            this.lblGeoOblici.Name = "lblGeoOblici";
            this.lblGeoOblici.Size = new System.Drawing.Size(108, 15);
            this.lblGeoOblici.TabIndex = 5;
            this.lblGeoOblici.Text = "Geometrijski oblici:";
            // 
            // btnDodajKvadrat
            // 
            this.btnDodajKvadrat.Location = new System.Drawing.Point(34, 103);
            this.btnDodajKvadrat.Name = "btnDodajKvadrat";
            this.btnDodajKvadrat.Size = new System.Drawing.Size(171, 23);
            this.btnDodajKvadrat.TabIndex = 6;
            this.btnDodajKvadrat.Text = "Dodaj kvadrat";
            this.btnDodajKvadrat.UseVisualStyleBackColor = true;
            this.btnDodajKvadrat.Click += new System.EventHandler(this.btnDodajKvadrat_Click);
            // 
            // btnDodajKruznicu
            // 
            this.btnDodajKruznicu.Location = new System.Drawing.Point(34, 233);
            this.btnDodajKruznicu.Name = "btnDodajKruznicu";
            this.btnDodajKruznicu.Size = new System.Drawing.Size(171, 23);
            this.btnDodajKruznicu.TabIndex = 7;
            this.btnDodajKruznicu.Text = "Dodaj kružnicu";
            this.btnDodajKruznicu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 591);
            this.Controls.Add(this.btnDodajKruznicu);
            this.Controls.Add(this.btnDodajKvadrat);
            this.Controls.Add(this.lblGeoOblici);
            this.Controls.Add(this.tbGeometrijskiOblici);
            this.Controls.Add(this.tbRadijusKruznice);
            this.Controls.Add(this.lblKruznica);
            this.Controls.Add(this.tbStranicaKvadrata);
            this.Controls.Add(this.lblKvadrat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKvadrat;
        private System.Windows.Forms.TextBox tbStranicaKvadrata;
        private System.Windows.Forms.TextBox tbRadijusKruznice;
        private System.Windows.Forms.Label lblKruznica;
        private System.Windows.Forms.TextBox tbGeometrijskiOblici;
        private System.Windows.Forms.Label lblGeoOblici;
        private System.Windows.Forms.Button btnDodajKvadrat;
        private System.Windows.Forms.Button btnDodajKruznicu;
    }
}

