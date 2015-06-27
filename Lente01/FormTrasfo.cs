using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#pragma warning disable 1591
namespace Lente01 {
	public partial class FormTrasfo: Form
		{
		public double x,y,r;

		public FormTrasfo() {
			InitializeComponent();
			tb_X.Text = "0";
			tb_Y.Text = "0";
			tb_R.Text = "0";
			x = y = r = 0.0;
			}

		private void IdOK_Click(object sender, EventArgs e)
			{
			double tmp;			
			if(Double.TryParse(tb_X.Text, out tmp))
				x = tmp;
			if(Double.TryParse(tb_Y.Text, out tmp))
				y = tmp;
			if(Double.TryParse(tb_R.Text, out tmp))
				r = tmp*Math.PI/180.0;
			this.Close();
			}
		}
	}
#pragma warning restore 1591