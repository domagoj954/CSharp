
namespace VrijemeApp {
  partial class FormMain {
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
      this.components = new System.ComponentModel.Container();
      this.cbCities = new System.Windows.Forms.ComboBox();
      this.lblCity = new System.Windows.Forms.Label();
      this.lblCityTemperature = new System.Windows.Forms.Label();
      this.lblCityHumdity = new System.Windows.Forms.Label();
      this.lblCityPressure = new System.Windows.Forms.Label();
      this.lbWarmestCities = new System.Windows.Forms.ListBox();
      this.lbColdestCities = new System.Windows.Forms.ListBox();
      this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // cbCities
      // 
      this.cbCities.FormattingEnabled = true;
      this.cbCities.Location = new System.Drawing.Point(12, 12);
      this.cbCities.Name = "cbCities";
      this.cbCities.Size = new System.Drawing.Size(338, 23);
      this.cbCities.TabIndex = 0;
      this.cbCities.TextChanged += new System.EventHandler(this.cbCities_TextChanged);
      // 
      // lblCity
      // 
      this.lblCity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblCity.Location = new System.Drawing.Point(12, 60);
      this.lblCity.Name = "lblCity";
      this.lblCity.Size = new System.Drawing.Size(338, 49);
      this.lblCity.TabIndex = 1;
      this.lblCity.Text = "-";
      this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCityTemperature
      // 
      this.lblCityTemperature.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblCityTemperature.Location = new System.Drawing.Point(12, 109);
      this.lblCityTemperature.Name = "lblCityTemperature";
      this.lblCityTemperature.Size = new System.Drawing.Size(338, 49);
      this.lblCityTemperature.TabIndex = 2;
      this.lblCityTemperature.Text = "- °C";
      this.lblCityTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCityHumdity
      // 
      this.lblCityHumdity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblCityHumdity.Location = new System.Drawing.Point(12, 158);
      this.lblCityHumdity.Name = "lblCityHumdity";
      this.lblCityHumdity.Size = new System.Drawing.Size(338, 49);
      this.lblCityHumdity.TabIndex = 3;
      this.lblCityHumdity.Text = "- %";
      this.lblCityHumdity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCityPressure
      // 
      this.lblCityPressure.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblCityPressure.Location = new System.Drawing.Point(12, 207);
      this.lblCityPressure.Name = "lblCityPressure";
      this.lblCityPressure.Size = new System.Drawing.Size(338, 49);
      this.lblCityPressure.TabIndex = 4;
      this.lblCityPressure.Text = "- hPa";
      this.lblCityPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbWarmestCities
      // 
      this.lbWarmestCities.FormattingEnabled = true;
      this.lbWarmestCities.ItemHeight = 15;
      this.lbWarmestCities.Location = new System.Drawing.Point(12, 271);
      this.lbWarmestCities.Name = "lbWarmestCities";
      this.lbWarmestCities.Size = new System.Drawing.Size(157, 169);
      this.lbWarmestCities.TabIndex = 5;
      // 
      // lbColdestCities
      // 
      this.lbColdestCities.FormattingEnabled = true;
      this.lbColdestCities.ItemHeight = 15;
      this.lbColdestCities.Location = new System.Drawing.Point(193, 271);
      this.lbColdestCities.Name = "lbColdestCities";
      this.lbColdestCities.Size = new System.Drawing.Size(157, 169);
      this.lbColdestCities.TabIndex = 6;
      // 
      // tmrRefresh
      // 
      this.tmrRefresh.Interval = 30000;
      this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(362, 453);
      this.Controls.Add(this.lbColdestCities);
      this.Controls.Add(this.lbWarmestCities);
      this.Controls.Add(this.lblCityPressure);
      this.Controls.Add(this.lblCityHumdity);
      this.Controls.Add(this.lblCityTemperature);
      this.Controls.Add(this.lblCity);
      this.Controls.Add(this.cbCities);
      this.Name = "FormMain";
      this.Text = "VrijemeApp";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbCities;
    private System.Windows.Forms.Label lblCity;
    private System.Windows.Forms.Label lblCityTemperature;
    private System.Windows.Forms.Label lblCityHumdity;
    private System.Windows.Forms.Label lblCityPressure;
    private System.Windows.Forms.ListBox lbWarmestCities;
    private System.Windows.Forms.ListBox lbColdestCities;
    private System.Windows.Forms.Timer tmrRefresh;
  }
}

