namespace WindowsFormsApp1
{
	partial class FrmEntrenamiento
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblRata = new System.Windows.Forms.Label();
			this.lblErrorMaximo = new System.Windows.Forms.Label();
			this.lblNumeroIteraciones = new System.Windows.Forms.Label();
			this.lblIIteracion = new System.Windows.Forms.Label();
			this.lblErrorIteracion = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.chartErrorIteracion = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartPesosUmbrales = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartErrorIteracion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartPesosUmbrales)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(45, 387);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(709, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// lblRata
			// 
			this.lblRata.AutoSize = true;
			this.lblRata.Location = new System.Drawing.Point(42, 48);
			this.lblRata.Name = "lblRata";
			this.lblRata.Size = new System.Drawing.Size(124, 13);
			this.lblRata.TabIndex = 3;
			this.lblRata.Text = "Rata de Aprendizaje: 0.0";
			// 
			// lblErrorMaximo
			// 
			this.lblErrorMaximo.AutoSize = true;
			this.lblErrorMaximo.Location = new System.Drawing.Point(42, 75);
			this.lblErrorMaximo.Name = "lblErrorMaximo";
			this.lblErrorMaximo.Size = new System.Drawing.Size(135, 13);
			this.lblErrorMaximo.TabIndex = 4;
			this.lblErrorMaximo.Text = "Error Máximo Permitido: 0.0";
			// 
			// lblNumeroIteraciones
			// 
			this.lblNumeroIteraciones.AutoSize = true;
			this.lblNumeroIteraciones.Location = new System.Drawing.Point(42, 102);
			this.lblNumeroIteraciones.Name = "lblNumeroIteraciones";
			this.lblNumeroIteraciones.Size = new System.Drawing.Size(135, 13);
			this.lblNumeroIteraciones.TabIndex = 5;
			this.lblNumeroIteraciones.Text = "Número de Iteraciones: 0.0";
			// 
			// lblIIteracion
			// 
			this.lblIIteracion.AutoSize = true;
			this.lblIIteracion.Location = new System.Drawing.Point(445, 48);
			this.lblIIteracion.Name = "lblIIteracion";
			this.lblIIteracion.Size = new System.Drawing.Size(69, 13);
			this.lblIIteracion.TabIndex = 9;
			this.lblIIteracion.Text = "Iteracion: 0.0";
			// 
			// lblErrorIteracion
			// 
			this.lblErrorIteracion.AutoSize = true;
			this.lblErrorIteracion.Location = new System.Drawing.Point(445, 75);
			this.lblErrorIteracion.Name = "lblErrorIteracion";
			this.lblErrorIteracion.Size = new System.Drawing.Size(113, 13);
			this.lblErrorIteracion.TabIndex = 10;
			this.lblErrorIteracion.Text = "Error Por Iteracion: 0.0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(664, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Guardar ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// chartErrorIteracion
			// 
			this.chartErrorIteracion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea1.Name = "ChartArea1";
			this.chartErrorIteracion.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Name = "Legend1";
			this.chartErrorIteracion.Legends.Add(legend1);
			this.chartErrorIteracion.Location = new System.Drawing.Point(36, 128);
			this.chartErrorIteracion.Name = "chartErrorIteracion";
			this.chartErrorIteracion.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Color = System.Drawing.Color.Red;
			series1.Legend = "Legend1";
			series1.Name = "Error por Iteracion";
			series2.BorderColor = System.Drawing.Color.Green;
			series2.BorderWidth = 2;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.DodgerBlue;
			series2.Legend = "Legend1";
			series2.Name = "ERROR MAXIMO";
			this.chartErrorIteracion.Series.Add(series1);
			this.chartErrorIteracion.Series.Add(series2);
			this.chartErrorIteracion.Size = new System.Drawing.Size(350, 233);
			this.chartErrorIteracion.TabIndex = 23;
			this.chartErrorIteracion.Text = "chart1";
			// 
			// chartPesosUmbrales
			// 
			this.chartPesosUmbrales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea2.Name = "ChartArea1";
			this.chartPesosUmbrales.ChartAreas.Add(chartArea2);
			legend2.Alignment = System.Drawing.StringAlignment.Center;
			legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend2.Name = "Legend1";
			this.chartPesosUmbrales.Legends.Add(legend2);
			this.chartPesosUmbrales.Location = new System.Drawing.Point(404, 128);
			this.chartPesosUmbrales.Name = "chartPesosUmbrales";
			this.chartPesosUmbrales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series3.Color = System.Drawing.Color.Orange;
			series3.Legend = "Legend1";
			series3.Name = "Pesos";
			series4.BorderColor = System.Drawing.Color.Green;
			series4.BorderWidth = 2;
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series4.Color = System.Drawing.Color.Blue;
			series4.Legend = "Legend1";
			series4.Name = "Umbrales";
			this.chartPesosUmbrales.Series.Add(series3);
			this.chartPesosUmbrales.Series.Add(series4);
			this.chartPesosUmbrales.Size = new System.Drawing.Size(350, 233);
			this.chartPesosUmbrales.TabIndex = 24;
			this.chartPesosUmbrales.Text = "chart1";
			// 
			// FrmEntrenamiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.chartPesosUmbrales);
			this.Controls.Add(this.chartErrorIteracion);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblErrorIteracion);
			this.Controls.Add(this.lblIIteracion);
			this.Controls.Add(this.lblNumeroIteraciones);
			this.Controls.Add(this.lblErrorMaximo);
			this.Controls.Add(this.lblRata);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEntrenamiento";
			this.Text = "FrmEntrenamiento";
			this.Load += new System.EventHandler(this.FrmEntrenamiento_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartErrorIteracion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartPesosUmbrales)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lblRata;
		private System.Windows.Forms.Label lblErrorMaximo;
		private System.Windows.Forms.Label lblNumeroIteraciones;
		private System.Windows.Forms.Label lblIIteracion;
		private System.Windows.Forms.Label lblErrorIteracion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartErrorIteracion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPesosUmbrales;
    }
}