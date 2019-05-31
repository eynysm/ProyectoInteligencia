namespace WindowsFormsApp1
{
	partial class FrmEntradasSalidas
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
			this.btnEntradasSalidas = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listEntradas = new System.Windows.Forms.ListBox();
			this.listSalidas = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPatrones = new System.Windows.Forms.TextBox();
			this.txtSalidas = new System.Windows.Forms.TextBox();
			this.txtEntradas = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnEntradasSalidas
			// 
			this.btnEntradasSalidas.Location = new System.Drawing.Point(91, 204);
			this.btnEntradasSalidas.Name = "btnEntradasSalidas";
			this.btnEntradasSalidas.Size = new System.Drawing.Size(126, 31);
			this.btnEntradasSalidas.TabIndex = 0;
			this.btnEntradasSalidas.Text = "Entradas Salidas";
			this.btnEntradasSalidas.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(110, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre de la Red";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(69, 147);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(173, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Entradas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(130, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Salidas";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(193, 275);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Patrones";
			// 
			// listEntradas
			// 
			this.listEntradas.FormattingEnabled = true;
			this.listEntradas.Location = new System.Drawing.Point(292, 82);
			this.listEntradas.Name = "listEntradas";
			this.listEntradas.Size = new System.Drawing.Size(181, 290);
			this.listEntradas.TabIndex = 9;
			// 
			// listSalidas
			// 
			this.listSalidas.FormattingEnabled = true;
			this.listSalidas.Location = new System.Drawing.Point(508, 82);
			this.listSalidas.Name = "listSalidas";
			this.listSalidas.Size = new System.Drawing.Size(181, 290);
			this.listSalidas.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(354, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Entradas";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(570, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Salidas";
			// 
			// txtPatrones
			// 
			this.txtPatrones.Location = new System.Drawing.Point(196, 291);
			this.txtPatrones.Name = "txtPatrones";
			this.txtPatrones.Size = new System.Drawing.Size(46, 20);
			this.txtPatrones.TabIndex = 8;
			// 
			// txtSalidas
			// 
			this.txtSalidas.Location = new System.Drawing.Point(133, 291);
			this.txtSalidas.Name = "txtSalidas";
			this.txtSalidas.Size = new System.Drawing.Size(46, 20);
			this.txtSalidas.TabIndex = 7;
			// 
			// txtEntradas
			// 
			this.txtEntradas.Location = new System.Drawing.Point(69, 291);
			this.txtEntradas.Name = "txtEntradas";
			this.txtEntradas.Size = new System.Drawing.Size(46, 20);
			this.txtEntradas.TabIndex = 6;
			// 
			// FrmEntradasSalidas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(781, 444);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listSalidas);
			this.Controls.Add(this.listEntradas);
			this.Controls.Add(this.txtPatrones);
			this.Controls.Add(this.txtSalidas);
			this.Controls.Add(this.txtEntradas);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEntradasSalidas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEntradasSalidas";
			this.Text = "FrmEntradasSalidas";
			this.Load += new System.EventHandler(this.FrmEntradasSalidas_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEntradasSalidas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listEntradas;
		private System.Windows.Forms.ListBox listSalidas;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPatrones;
		private System.Windows.Forms.TextBox txtSalidas;
		private System.Windows.Forms.TextBox txtEntradas;
	}
}