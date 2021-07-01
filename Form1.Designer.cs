
namespace RegressionLineApp {
  partial class RegressionLine {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegressionLine));
      this.Calculate = new System.Windows.Forms.Button();
      this.xV = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.yV = new System.Windows.Forms.TextBox();
      this.formulaBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.Reset = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.Close = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // Calculate
      // 
      this.Calculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Calculate.Location = new System.Drawing.Point(737, 495);
      this.Calculate.Name = "Calculate";
      this.Calculate.Size = new System.Drawing.Size(202, 55);
      this.Calculate.TabIndex = 0;
      this.Calculate.Text = "Calculate";
      this.Calculate.UseVisualStyleBackColor = false;
      this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
      // 
      // xV
      // 
      this.xV.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xV.Location = new System.Drawing.Point(250, 56);
      this.xV.Name = "xV";
      this.xV.Size = new System.Drawing.Size(689, 30);
      this.xV.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
      this.label1.Location = new System.Drawing.Point(12, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(232, 37);
      this.label1.TabIndex = 2;
      this.label1.Text = "Enter X values:";
      // 
      // yV
      // 
      this.yV.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yV.Location = new System.Drawing.Point(250, 100);
      this.yV.Name = "yV";
      this.yV.Size = new System.Drawing.Size(688, 30);
      this.yV.TabIndex = 4;
      // 
      // formulaBox
      // 
      this.formulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.formulaBox.Location = new System.Drawing.Point(12, 29);
      this.formulaBox.Name = "formulaBox";
      this.formulaBox.Size = new System.Drawing.Size(515, 38);
      this.formulaBox.TabIndex = 17;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
      this.label2.Location = new System.Drawing.Point(11, 93);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(233, 37);
      this.label2.TabIndex = 18;
      this.label2.Text = "Enter Y values:";
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Location = new System.Drawing.Point(43, 148);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series1.Name = "Points";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series2.Name = "Line";
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(856, 305);
      this.chart1.TabIndex = 19;
      this.chart1.Text = "chart1";
      // 
      // Reset
      // 
      this.Reset.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Reset.Location = new System.Drawing.Point(540, 495);
      this.Reset.Name = "Reset";
      this.Reset.Size = new System.Drawing.Size(191, 55);
      this.Reset.TabIndex = 20;
      this.Reset.Text = "Reset";
      this.Reset.UseVisualStyleBackColor = false;
      this.Reset.Click += new System.EventHandler(this.Reset_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.yV);
      this.panel1.Controls.Add(this.xV);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(951, 142);
      this.panel1.TabIndex = 21;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.Gray;
      this.panel3.Controls.Add(this.Close);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(951, 50);
      this.panel3.TabIndex = 19;
      // 
      // Close
      // 
      this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
      this.Close.ForeColor = System.Drawing.Color.Red;
      this.Close.Location = new System.Drawing.Point(898, 3);
      this.Close.Name = "Close";
      this.Close.Size = new System.Drawing.Size(50, 44);
      this.Close.TabIndex = 0;
      this.Close.Text = "Close";
      this.Close.UseVisualStyleBackColor = false;
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
      this.panel2.Controls.Add(this.formulaBox);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 477);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(951, 100);
      this.panel2.TabIndex = 22;
      // 
      // RegressionLine
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
      this.ClientSize = new System.Drawing.Size(951, 577);
      this.Controls.Add(this.Reset);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.Calculate);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "RegressionLine";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Best Fit Line";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegressionLine_MouseDown);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button Calculate;
    private System.Windows.Forms.TextBox xV;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox yV;
    private System.Windows.Forms.TextBox formulaBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Button Reset;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button Close;
  }
}

