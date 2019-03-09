namespace Pagina
{
	partial class FormPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRestaurar = new System.Windows.Forms.PictureBox();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.btnMaximizar = new System.Windows.Forms.PictureBox();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.panelContenedor.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			this.SuspendLayout();
			// 
			// panelContenedor
			// 
			this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panelContenedor.Controls.Add(this.panel3);
			this.panelContenedor.Controls.Add(this.panel2);
			this.panelContenedor.Controls.Add(this.panel1);
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 0);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(1025, 650);
			this.panelContenedor.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(250, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(775, 610);
			this.panel3.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 610);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
			this.panel1.Controls.Add(this.btnRestaurar);
			this.panel1.Controls.Add(this.btnMinimizar);
			this.panel1.Controls.Add(this.btnMaximizar);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1025, 40);
			this.panel1.TabIndex = 0;
			// 
			// btnRestaurar
			// 
			this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
			this.btnRestaurar.Location = new System.Drawing.Point(979, 8);
			this.btnRestaurar.Name = "btnRestaurar";
			this.btnRestaurar.Size = new System.Drawing.Size(18, 18);
			this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnRestaurar.TabIndex = 1;
			this.btnRestaurar.TabStop = false;
			this.btnRestaurar.Visible = false;
			this.btnRestaurar.Click += new System.EventHandler(this.btnMaximizar_Click);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
			this.btnMinimizar.Location = new System.Drawing.Point(957, 8);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(18, 18);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimizar.TabIndex = 3;
			this.btnMinimizar.TabStop = false;
			// 
			// btnMaximizar
			// 
			this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
			this.btnMaximizar.Location = new System.Drawing.Point(979, 8);
			this.btnMaximizar.Name = "btnMaximizar";
			this.btnMaximizar.Size = new System.Drawing.Size(18, 18);
			this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMaximizar.TabIndex = 2;
			this.btnMaximizar.TabStop = false;
			this.btnMaximizar.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.Location = new System.Drawing.Point(1001, 8);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(18, 18);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 650);
			this.Controls.Add(this.panelContenedor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(650, 400);
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panelContenedor.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox btnMinimizar;
		private System.Windows.Forms.PictureBox btnMaximizar;
		private System.Windows.Forms.PictureBox btnRestaurar;
		private System.Windows.Forms.PictureBox btnCerrar;
	}
}

