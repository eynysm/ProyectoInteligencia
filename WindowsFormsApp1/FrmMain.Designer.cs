namespace WindowsFormsApp1
{
	partial class FrmMain
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
			this.btnEntrenamiento = new System.Windows.Forms.Button();
			this.btnSimulacion = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEntrenamiento
			// 
			this.btnEntrenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.btnEntrenamiento.FlatAppearance.BorderSize = 0;
			this.btnEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrenamiento.Location = new System.Drawing.Point(240, 188);
			this.btnEntrenamiento.Name = "btnEntrenamiento";
			this.btnEntrenamiento.Size = new System.Drawing.Size(102, 96);
			this.btnEntrenamiento.TabIndex = 0;
			this.btnEntrenamiento.Text = "Entrenamiento";
			this.btnEntrenamiento.UseVisualStyleBackColor = false;
			this.btnEntrenamiento.Click += new System.EventHandler(this.btnEntrenamiento_Click);
			// 
			// btnSimulacion
			// 
			this.btnSimulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.btnSimulacion.FlatAppearance.BorderSize = 0;
			this.btnSimulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimulacion.Location = new System.Drawing.Point(491, 188);
			this.btnSimulacion.Name = "btnSimulacion";
			this.btnSimulacion.Size = new System.Drawing.Size(102, 96);
			this.btnSimulacion.TabIndex = 1;
			this.btnSimulacion.Text = "Simulacion";
			this.btnSimulacion.UseVisualStyleBackColor = false;
			this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Green;
			this.panel2.Location = new System.Drawing.Point(0, 68);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(835, 36);
			this.panel2.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(834, 71);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(279, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(267, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Redes Neuronales Artifiales\r\n";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnSimulacion);
			this.Controls.Add(this.btnEntrenamiento);
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEntrenamiento;
		private System.Windows.Forms.Button btnSimulacion;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}