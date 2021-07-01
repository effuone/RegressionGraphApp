using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegressionLineApp {
  public partial class RegressionLine : Form {
    public RegressionLine() {
      InitializeComponent();
			chart1.Titles.Add("Regression");
    }
    private void RegressionLine_MouseDown(object sender, MouseEventArgs e) {
      base.Capture = false;
      Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }
    private void Calculate_Click(object sender, EventArgs e) {
      bool isValid = true;
			if(isValid == true && (string.IsNullOrWhiteSpace(xV.Text) || string.IsNullOrWhiteSpace(yV.Text))) {
        isValid = false;
				MessageBox.Show("Please enter missing data");
      }
      if (isValid == true && !Validator.AreAllNumbers(xV.Text + yV.Text)) {
        isValid = false;
        MessageBox.Show("Please enter only numbers");
      }
      if(isValid == true && xV.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length != yV.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length) {
        isValid = false;
        MessageBox.Show("Number of X values is not equal to number of Y values");
      }
      if(isValid == true) {
        string xCord = xV.Text;
        string yCord = yV.Text;
        string[] xArr = xCord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] yArr = yCord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int size = xArr.Length;
        double[] xValues = new double[size];
        double[] yValues = new double[size];
        for (int i = 0; i < xArr.Length; i++) {
          xValues[i] = double.Parse(xArr[i]);
        }
        for (int i = 0; i < yArr.Length; i++) {
          yValues[i] = double.Parse(yArr[i]);
        }
        double sumOfX = 0;
        double sumOfY = 0;
        double SSX = 0;
        double SP = 0;
        for (int i = 0; i < size; ++i) {
          sumOfX += xValues[i];
          sumOfY += yValues[i];
        }
        double meanOfX = sumOfX / size;
        double meanOfY = sumOfY / size;
        for (int i = 0; i < xArr.Length; ++i) {
          SSX += Math.Pow(xValues[i] - meanOfX, 2);
          SP += (xValues[i] - meanOfX) * (yValues[i] - meanOfY);
        }
        if ((meanOfY - ((SP / SSX) * meanOfX)) >= 0) {
          formulaBox.Text = $"y = {SP / SSX}x + {(meanOfY - ((SP / SSX) * meanOfX))}";
        } else {
          formulaBox.Text = $"y = {SP / SSX}x {(meanOfY - ((SP / SSX) * meanOfX))}";
        }
        for (int i = 0; i < size; i++) {
          this.chart1.Series["Points"].Points.AddXY(xValues[i], yValues[i]);
        }
        double maxX = xValues[0];
        for (int i = 0; i < size; i++) {
          if (maxX > xValues[i]) maxX = xValues[i];
        }
        for (int i = Convert.ToInt32(xValues[0]); i < maxX + 10; i++) {
          this.chart1.Series["Line"].Points.AddXY(i, ((SP / SSX) * i) + (meanOfY - ((SP / SSX) * meanOfX)));
        }
      }
    }

    private void Reset_Click(object sender, EventArgs e) {
			formulaBox.Clear();
			xV.Clear();
			yV.Clear();
			chart1.Series.Clear();
		}

    private void Close_Click(object sender, EventArgs e) {
      Close();
    }
  }
}
