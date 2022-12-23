namespace Oglasnik {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblNaslov = new System.Windows.Forms.Label();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.lblTekst = new System.Windows.Forms.Label();
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.cbSlikovniOglas = new System.Windows.Forms.CheckBox();
            this.tbSlikovniLink = new System.Windows.Forms.TextBox();
            this.tbVideoLink = new System.Windows.Forms.TextBox();
            this.cbVideoOglas = new System.Windows.Forms.CheckBox();
            this.btnDodajOglas = new System.Windows.Forms.Button();
            this.lblOglasi = new System.Windows.Forms.Label();
            this.lbOglasi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(15, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(43, 13);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov:";
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(15, 26);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(182, 20);
            this.tbNaslov.TabIndex = 1;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(15, 53);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(37, 13);
            this.lblTekst.TabIndex = 2;
            this.lblTekst.Text = "Tekst:";
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(15, 69);
            this.tbTekst.Multiline = true;
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(182, 188);
            this.tbTekst.TabIndex = 3;
            // 
            // cbSlikovniOglas
            // 
            this.cbSlikovniOglas.AutoSize = true;
            this.cbSlikovniOglas.Location = new System.Drawing.Point(15, 275);
            this.cbSlikovniOglas.Name = "cbSlikovniOglas";
            this.cbSlikovniOglas.Size = new System.Drawing.Size(91, 17);
            this.cbSlikovniOglas.TabIndex = 4;
            this.cbSlikovniOglas.Text = "Slikovni oglas";
            this.cbSlikovniOglas.UseVisualStyleBackColor = true;
            // 
            // tbSlikovniLink
            // 
            this.tbSlikovniLink.Location = new System.Drawing.Point(15, 298);
            this.tbSlikovniLink.Name = "tbSlikovniLink";
            this.tbSlikovniLink.Size = new System.Drawing.Size(182, 20);
            this.tbSlikovniLink.TabIndex = 5;
            // 
            // tbVideoLink
            // 
            this.tbVideoLink.Location = new System.Drawing.Point(15, 365);
            this.tbVideoLink.Name = "tbVideoLink";
            this.tbVideoLink.Size = new System.Drawing.Size(182, 20);
            this.tbVideoLink.TabIndex = 7;
            // 
            // cbVideoOglas
            // 
            this.cbVideoOglas.AutoSize = true;
            this.cbVideoOglas.Location = new System.Drawing.Point(15, 342);
            this.cbVideoOglas.Name = "cbVideoOglas";
            this.cbVideoOglas.Size = new System.Drawing.Size(81, 17);
            this.cbVideoOglas.TabIndex = 6;
            this.cbVideoOglas.Text = "Video oglas";
            this.cbVideoOglas.UseVisualStyleBackColor = true;
            // 
            // btnDodajOglas
            // 
            this.btnDodajOglas.Location = new System.Drawing.Point(15, 412);
            this.btnDodajOglas.Name = "btnDodajOglas";
            this.btnDodajOglas.Size = new System.Drawing.Size(182, 47);
            this.btnDodajOglas.TabIndex = 8;
            this.btnDodajOglas.Text = "Dodaj oglas";
            this.btnDodajOglas.UseVisualStyleBackColor = true;
            this.btnDodajOglas.Click += new System.EventHandler(this.btnDodajOglas_Click);
            // 
            // lblOglasi
            // 
            this.lblOglasi.AutoSize = true;
            this.lblOglasi.Location = new System.Drawing.Point(235, 9);
            this.lblOglasi.Name = "lblOglasi";
            this.lblOglasi.Size = new System.Drawing.Size(36, 13);
            this.lblOglasi.TabIndex = 9;
            this.lblOglasi.Text = "Oglasi";
            // 
            // lbOglasi
            // 
            this.lbOglasi.FormattingEnabled = true;
            this.lbOglasi.Location = new System.Drawing.Point(238, 26);
            this.lbOglasi.Name = "lbOglasi";
            this.lbOglasi.Size = new System.Drawing.Size(336, 433);
            this.lbOglasi.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 477);
            this.Controls.Add(this.lbOglasi);
            this.Controls.Add(this.lblOglasi);
            this.Controls.Add(this.btnDodajOglas);
            this.Controls.Add(this.tbVideoLink);
            this.Controls.Add(this.cbVideoOglas);
            this.Controls.Add(this.tbSlikovniLink);
            this.Controls.Add(this.cbSlikovniOglas);
            this.Controls.Add(this.tbTekst);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.tbNaslov);
            this.Controls.Add(this.lblNaslov);
            this.Name = "FormMain";
            this.Text = "Oglasnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.CheckBox cbSlikovniOglas;
        private System.Windows.Forms.TextBox tbSlikovniLink;
        private System.Windows.Forms.TextBox tbVideoLink;
        private System.Windows.Forms.CheckBox cbVideoOglas;
        private System.Windows.Forms.Button btnDodajOglas;
        private System.Windows.Forms.Label lblOglasi;
        private System.Windows.Forms.ListBox lbOglasi;
    }
}

