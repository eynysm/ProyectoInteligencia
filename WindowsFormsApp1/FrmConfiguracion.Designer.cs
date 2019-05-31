namespace WindowsFormsApp1
{
	partial class FrmConfiguracion
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIteraciones = new System.Windows.Forms.TextBox();
			this.txtRata = new System.Windows.Forms.TextBox();
			this.txtErrorMaximo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(202, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(364, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Configuración de los parametros de entrenamiento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(181, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Número de Iteraciones";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(336, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Rata de Aprendizaje";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(477, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Error Máximo Permitido";
			// 
			// txtIteraciones
			// 
			this.txtIteraciones.Location = new System.Drawing.Point(196, 224);
			this.txtIteraciones.Name = "txtIteraciones";
			this.txtIteraciones.Size = new System.Drawing.Size(74, 20);
			this.txtIteraciones.TabIndex = 4;
			this.txtIteraciones.Text = "1000";
			// 
			// txtRata
			// 
			this.txtRata.Location = new System.Drawing.Point(349, 224);
			this.txtRata.Name = "txtRata";
			this.txtRata.Size = new System.Drawing.Size(74, 20);
			this.txtRata.TabIndex = 5;
			this.txtRata.Text = "1";
			// 
			// txtErrorMaximo
			// 
			this.txtErrorMaximo.Location = new System.Drawing.Point(497, 224);
			this.txtErrorMaximo.Name = "txtErrorMaximo";
			this.txtErrorMaximo.Size = new System.Drawing.Size(74, 20);
			this.txtErrorMaximo.TabIndex = 6;
			this.txtErrorMaximo.Text = "0.0";
			// 
			// FrmConfiguracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtErrorMaximo);
			this.Controls.Add(this.txtRata);
			this.Controls.Add(this.txtIteraciones);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmConfiguracion";
			this.Text = "FrmConfiguracion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIteraciones;
		private System.Windows.Forms.TextBox txtRata;
		private System.Windows.Forms.TextBox txtErrorMaximo;
	}
}