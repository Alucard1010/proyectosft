using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagina
{
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			InitializeComponent();
		}

		//RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
		private int tolerance = 12;
		private const int WM_NCHITTEST = 132;
		private const int HTBOTTOMRIGHT = 17;
		private Rectangle sizeGripRectangle;

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case WM_NCHITTEST:
					base.WndProc(ref m);
					var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
					if (sizeGripRectangle.Contains(hitPoint))
						m.Result = new IntPtr(HTBOTTOMRIGHT);
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}
		//----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

			sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

			region.Exclude(sizeGripRectangle);
			this.panelContenedor.Region = region;
			this.Invalidate();
		}
		//----------------COLOR Y GRIP DE RECTANGULO INFERIOR
		protected override void OnPaint(PaintEventArgs e)
		{
			SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
			e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

			//base.OnPaint(e);
			//ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//estas variables son para maximizar y minimizar que quede en una posicion
		int x, y;
		int w, h;

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			x = this.Location.X;
			y = this.Location.Y;
			w = this.Size.Width;
			h = this.Size.Height;
			btnMaximizar.Visible = false;
			btnRestaurar.Visible = true;
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
		}

		
		private void btnMaximizar_Click(object sender, EventArgs e)
		{
			btnMaximizar.Visible = true;
			btnRestaurar.Visible = false;
			this.Size = new Size(w,h);
			this.Location = new Point(x,y);
		}
	}
}
