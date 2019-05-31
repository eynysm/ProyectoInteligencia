namespace WindowsFormsApp1
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEntradasSalidas = new System.Windows.Forms.Button();
			this.btnConfiguracion = new System.Windows.Forms.Button();
			this.btnEntrenamiento = new System.Windows.Forms.Button();
			this.panelcontenedor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(835, 71);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(316, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Perceptrón Simple";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Green;
			this.panel2.Location = new System.Drawing.Point(0, 67);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(835, 27);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btnEntradasSalidas
			// 
			this.btnEntradasSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.btnEntradasSalidas.FlatAppearance.BorderSize = 0;
			this.btnEntradasSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntradasSalidas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntradasSalidas.ForeColor = System.Drawing.Color.White;
			this.btnEntradasSalidas.Location = new System.Drawing.Point(87, 124);
			this.btnEntradasSalidas.Name = "btnEntradasSalidas";
			this.btnEntradasSalidas.Size = new System.Drawing.Size(185, 38);
			this.btnEntradasSalidas.TabIndex = 2;
			this.btnEntradasSalidas.Text = "Entradas Salidas";
			this.btnEntradasSalidas.UseVisualStyleBackColor = false;
			this.btnEntradasSalidas.Click += new System.EventHandler(this.btnEntradasSalidas_Click);
			// 
			// btnConfiguracion
			// 
			this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.btnConfiguracion.FlatAppearance.BorderSize = 0;
			this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
			this.btnConfiguracion.Location = new System.Drawing.Point(335, 124);
			this.btnConfiguracion.Name = "btnConfiguracion";
			this.btnConfiguracion.Size = new System.Drawing.Size(185, 38);
			this.btnConfiguracion.TabIndex = 3;
			this.btnConfiguracion.Text = "Configuración";
			this.btnConfiguracion.UseVisualStyleBackColor = false;
			this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
			// 
			// btnEntrenamiento
			// 
			this.btnEntrenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(182)))), ((int)(((byte)(32)))));
			this.btnEntrenamiento.FlatAppearance.BorderSize = 0;
			this.btnEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrenamiento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrenamiento.ForeColor = System.Drawing.Color.White;
			this.btnEntrenamiento.Location = new System.Drawing.Point(583, 124);
			this.btnEntrenamiento.Name = "btnEntrenamiento";
			this.btnEntrenamiento.Size = new System.Drawing.Size(185, 38);
			this.btnEntrenamiento.TabIndex = 4;
			this.btnEntrenamiento.Text = "Entrenamiento";
			this.btnEntrenamiento.UseVisualStyleBackColor = false;
			this.btnEntrenamiento.Click += new System.EventHandler(this.btnEntrenamiento_Click);
			// 
			// panelcontenedor
			// 
			this.panelcontenedor.Location = new System.Drawing.Point(0, 181);
			this.panelcontenedor.Name = "panelcontenedor";
			this.panelcontenedor.Size = new System.Drawing.Size(835, 348);
			this.panelcontenedor.TabIndex = 5;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(835, 541);
			this.Controls.Add(this.panelcontenedor);
			this.Controls.Add(this.btnEntrenamiento);
			this.Controls.Add(this.btnConfiguracion);
			this.Controls.Add(this.btnEntradasSalidas);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmPrincipal";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnEntradasSalidas;
		private System.Windows.Forms.Button btnConfiguracion;
		private System.Windows.Forms.Button btnEntrenamiento;
		private System.Windows.Forms.Panel panelcontenedor;
	}
}

