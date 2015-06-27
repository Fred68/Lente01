using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Lente01.Properties;										// Risorse
using Fred68.Tools.Engineering;
using Fred68.Tools.Grafica;
using Fred68.Tools.Matematica;

#pragma warning disable 1591

namespace Lente01
	{
	public partial class Lente01 : Form
		{
		public Lente lente;											// Oggetti
		string nomefile;		
		public SorgenteOttica sorgente;
		Finestra finestra;
		Pen[] penne;
		DisplayList displayList;
		Ambiente singolo, completo;
		Ambiente ambienteAttivo;
		decimal angolo;
		decimal percentodiam;

		public Lente01()
			{
			InitializeComponent();

			lente = new Lente();								// Crea nuovi oggetti
			sorgente = new SorgenteOttica();
			finestra = new Finestra();
			nomefile = "-";
			displayList = new DisplayList();
			singolo = new Ambiente();
			completo = new Ambiente();
			ambienteAttivo = singolo;

			penne = new Pen[4];
			penne[0] = new Pen(Color.Blue,2);
			penne[1] = new Pen(Color.Red,1);
			penne[2] = new Pen(Color.Green,1);
			penne[3] = new Pen(Color.Gray,1);

			angolo = 0;
			this.gradiprimi.Value = angolo;
			percentodiam = 110;
			this.percdiam.Value = percentodiam;

			RidimensionaFinestra();								// Richiede primo ricalcolo della finestra

			}
		private void RidimensionaFinestra()						// Aggiorna la finestra per la grafica
			{
			Rectangle rect;
			rect = this.ClientRectangle;
			finestra.Set(0, rect.Height, rect.Width, this.barraMenu.Height);
			finestra.Set(-5*lente.RL, -lente.D, 5*lente.RL, lente.D);			
			Invalidate();
			}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
			{
			if (MessageBox.Show( Resources.Uscita , Resources.UscitaTitolo, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
				e.Cancel = true;
			}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
			{
			Close();
			}
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
			{
			MessageBox.Show(Resources.AboutTitolo + '\n' + Resources.AboutAutore + '\n' + Resources.AboutVersione);
			}
		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
			{

			}
		private void modificaLenteToolStripMenuItem_Click(object sender, EventArgs e)
			{
			FormLente formlente = new FormLente(lente);
			if(formlente.ShowDialog() == DialogResult.OK)
				{
				this.lente = formlente.lente;
				}
			formlente.Close();
			Invalidate();
			}
		private void nuovaLenteToolStripMenuItem_Click(object sender, EventArgs e)
			{
			FormLente formlente = new FormLente();
			if (formlente.ShowDialog() == DialogResult.OK)
				{
				this.lente = formlente.lente;
				}
			formlente.Close();
			this.nomefile = "-";
			Invalidate();
			}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
			{
			saveDialog.Filter="Text file|*.txt";
			saveDialog.DefaultExt="txt";
			if(saveDialog.ShowDialog() == DialogResult.OK)
				{
				string nomefile = saveDialog.FileName;
				StreamWriter strw = new StreamWriter(nomefile,false);	// Apre in scrittura (sovrascrive dati esistenti)
				lente.SalvaStream(strw);
				strw.Close();
				this.nomefile = nomefile;
				this.Invalidate();
				}
			}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if(openDialog.ShowDialog() == DialogResult.OK)
				{
				string nomefile;
				nomefile = openDialog.FileName;
				StreamReader strr = new StreamReader(nomefile);
				lente.CaricaStream(strr);
				strr.Close();
				this.nomefile = nomefile;
				this.Invalidate();
				}
			}

		private void Lente01_Paint(object sender, PaintEventArgs e)
			{
			this.Text = "Helmut: " + nomefile;
			Graphics dc = e.Graphics;									// Ricava il DC (device context) della finestra
			dc.Clear(Color.Ivory);
			displayList.Plot(dc,finestra,penne);
			}

		private void Lente01_KeyPress(object sender, KeyPressEventArgs e)
			{
			switch(e.KeyChar)
				{
				case 's':
					finestra.PanSu();
					break;
				case 'w':
					finestra.PanGiu();
					break;
				case 'a':
					finestra.PanDx();
					break;
				case 'd':
					finestra.PanSx();
					break;
				case 'e':
					finestra.ZoomIn();
					break;
				case 'q':
					finestra.ZoomOut();
					break;
				}
			Invalidate();
			}
		private void fitZoomToolStripMenuItem_Click(object sender, EventArgs e)
			{
			RidimensionaFinestra();
			}

		#region TESTMENU
		private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
			{
			Point2D p1 = new Point2D(1, 0);
			Point2D p2 = new Point2D(0, 1);
			Point2D p3 = new Point2D (1,1);
			Point2D pc = new Point2D (0,0);
			Point2D p4 = new Point2D (0, -1);
			Point2D p5 = new Point2D (1, 2);
			Point2D p6 = new Point2D (1, -1);

			Arc2D ar1 = new Arc2D(pc, p1, p2);
			Arc2D ar1x = new Arc2D(p1, p2, pc, Arc2D.TrePunti.Estremi_e_Centro);
			Arc2D ar2 = new Arc2D(pc, p2, p1);
			Arc2D ar2x = new Arc2D(p2, p1, pc, Arc2D.TrePunti.Estremi_e_Centro);

			Arc2D ar3 = new Arc2D(p3, p2);

			Line2D ln1 = new Line2D(p1, p2);
			Line2D ln2 = new Line2D(pc, p3);
			Line2D ln3 = new Line2D(0,0,30,3,false,true);
			Line2D ln4 = new Line2D(pc, p2, true);
			Line2D ln5 = new Line2D(p2, p3);

			bool b1 = ar1.Belongs(0);
			bool b2 = ar1.Belongs(Math.PI/4);
			bool b3 = ar1.Belongs(Math.PI / 8);
			bool b4 = ln1.Belongs(p1);

			bool c1 = ar1.Belongs(new Point2D(0,1));
			bool c2 = ar1.Belongs(new Point2D(1,0));
			bool c3 = ar1.Belongs(new Point2D(Math.Sqrt(2)/2,Math.Sqrt(2)/2));

			List<Intersection> li1 = Function2D.Intersect(ln1, ln2);
			List<Intersection> li2 = Function2D.Intersect(ln2, ar1);
			List<Intersection> li3 = Function2D.Intersect(ln2, ar1, true, true);
			List<Intersection> li4 = Function2D.Intersect(ln3, ar1);
			List<Intersection> li5 = Function2D.Intersect(ln2, ar2, false, true);
			List<Intersection> li6 = Function2D.Intersect(ln4, ar3, false, false);
			List<Intersection> li7 = Function2D.Intersect(ln5, ln3);

			Point2D[] nr = new Point2D[3];
			double[] nrd = new double[3];
			Function2D.Nearest(p2, ln2, out nr[0], out nrd[0]);
			Function2D.Nearest(p4, ln3, out nr[1], out nrd[1], true);
			Function2D.Nearest(p6, ln3, out nr[2], out nrd[2]);
			Point2D[] nrx = new Point2D[3];
			nrx[0] = Function2D.Nearest(p2, ln2);
			nrx[1] = Function2D.Nearest(p4, ln3, true);
			nrx[2] = Function2D.Nearest(p6, ln3);

			Point2D[] pr = new Point2D[4];
			bool[] prb = new bool[4];

			prb[0] = Function2D.Projection(p3, ln2, out pr[0]);
			prb[1] = Function2D.Projection(p4, ln2, out pr[1]);
			prb[2] = Function2D.Projection(p6, ln2, out pr[2]);
			prb[3] = Function2D.Projection(p2, ln3, out pr[3]);
			Point2D[] prx = new Point2D[4];
			prx[0] = Function2D.Projection(p3, ln2);
			prx[1] = Function2D.Projection(p4, ln2);
			prx[2] = Function2D.Projection(p6, ln2);
			prx[3] = Function2D.Projection(p2, ln3);

			Point2D[] pra = new Point2D[5];
			bool[] prab = new bool[5];

			prab[0] = Function2D.Projection(p6, ar2, out pra[0], true);
			prab[1] = Function2D.Projection(p5, ar1, out pra[1], true);
			prab[2] = Function2D.Projection(p5, ar2, out pra[2], true);
			prab[3] = Function2D.Projection(p5, ar2, out pra[3], false);
			prab[4] = Function2D.Projection(p4, ar3, out pra[4], true);
			Point2D[] prax = new Point2D[5];
			prax[0] = Function2D.Projection(p6, ar2, true);
			prax[1] = Function2D.Projection(p5, ar1, true);
			prax[2] = Function2D.Projection(p5, ar2, true);
			prax[3] = Function2D.Projection(p5, ar2);
			prax[4] = Function2D.Projection(p4, ar3, true);
			Point2D x = new Point2D(10,-1);
			x = -x;
			Line2D[] vout = new Line2D[3];
			bool[] bv = new bool[3];
			bv[0] = Function2D.LineOut(pra[0], ar2, out vout[0], p6);
			bv[1] = Function2D.LineOut(pr[3], ln3, out vout[1], p3);
			bv[2] = Function2D.LineOut(pra[0], ar2, out vout[2], p2);
			Line2D[] voux = new Line2D[3];
			voux[0] = Function2D.LineOut(pra[0], ar2, p6);
			voux[1] = Function2D.LineOut(pr[3], ln3, p3);
			voux[2] = Function2D.LineOut(pra[0], ar2, p2);
			Point2D[] vettori = new Point2D[3];
			vettori[0] = voux[0].Vector();
			vettori[1] = voux[1].Vector();
			vettori[2] = voux[2].Vector();

			Point2D[] vvout = new Point2D[3];
			bool[] bvv = new bool[3];
			bvv[0] = Function2D.VersorOut(pra[0], ar2, out vvout[0], p6);
			bvv[1] = Function2D.VersorOut(pr[3], ln3, out vvout[1], p3);
			bvv[2] = Function2D.VersorOut(pra[0], ar2, out vvout[2], p2);

			Point2D[] vvoux = new Point2D[3];
			vvoux[0] = Function2D.VersorOut(pra[0], ar2, p6);
			vvoux[1] = Function2D.VersorOut(pr[3], ln3, p3);
			vvoux[2] = Function2D.VersorOut(pra[0], ar2, p2);


			double[] scalari = new double[3];
			scalari[0] = vvoux[0]^vettori[0];
			scalari[1] = vvoux[1]^vettori[1];
			scalari[2] = vvoux[2]^vettori[2];


			Point2D Punto2 = new Point2D(-5.17,9.91);
			Point2D Punto3 = new Point2D(-4.82,-10.08);
			Point2D centroX = new Point2D(94.48,1.64);
			Arc2D Arco = new Arc2D(Punto2,Punto3,centroX,Arc2D.TrePunti.Estremi_e_Centro);


			#pragma warning disable
			int tmp;
			tmp = 1;
			#pragma warning restore

			}
		private void test2ToolStripMenuItem_Click(object sender,EventArgs e)
			{
			Point2D[] v = new Point2D[10];
			v[0] = new Point2D(1, 0, false);
			v[1] = new Point2D(1, 90, false);
			v[2] = new Point2D(1, 180, false);
			v[3] = new Point2D(1, -90, false);
			v[4] = new Point2D(1, 30, false);			
			v[5] = new Point2D(1, 45, false);			
			v[6] = new Point2D(1, 60, false);			
			v[7] = new Point2D(1, -45, false);			
			v[8] = new Point2D(1, -135, false);			
			v[9] = new Point2D(1, 135, false);
			
			Point2D[] r = new Point2D[8];
			r[0] = Ottica.Riflesso(v[1], v[3]);				// ok
			r[1] = Ottica.Rifratto(v[1], v[3], 1, 1.33);	// ok	
			r[2] = Ottica.Riflesso(v[4], v[8]);				// -v[6] ok
			r[3] = Ottica.Rifratto(v[6], v[8], 1, 1.4);		// ok
			r[4] = Ottica.Rifratto(v[6], v[8], 1.4, 1);		// ok
			r[5] = Ottica.Riflesso(v[4],v[9]);
			r[6] = Ottica.Rifratto(v[4],v[9],1,1.33);
			r[7] = Ottica.Rifratto(v[4],v[9],1.33,1);
			//r[8] = Ottica.Rifratto

			double[] ang = new double[8];
			ang[0] = r[0].Alfa(false);
			ang[1] = r[1].Alfa(false);
			ang[2] = r[2].Alfa(false);
			ang[3] = r[3].Alfa(false);
			ang[4] = r[4].Alfa(false);
			ang[5] = r[5].Alfa(false);
			ang[6] = r[6].Alfa(false);
			ang[7] = r[7].Alfa(false);
			//ang[8] = r[8].Alfa(false);

			double x = Math.Atan2(0,0);
			
			#pragma warning disable
			int tmp;
			tmp = 1;
			#pragma warning restore
			}
		private void test3ToolStripMenuItem_Click(object sender,EventArgs e)
			{
			Point2D p1 = new Point2D(1, 0);
			Point2D p2 = new Point2D(0, 1);
			Point2D p3 = new Point2D (1,1);
			Point2D pc = new Point2D (0,0);

			Arc2D ar1 = new Arc2D(pc, p1, p2);
			Arc2D ar2 = new Arc2D(pc, p2, p1);
			Arc2D ar3 = new Arc2D(p3, p2);

			Line2D ln1 = new Line2D(p1, p2);
			Line2D ln2 = new Line2D(pc, p3);
			Line2D ln3 = new Line2D(0,0,30,3,false,true);
			
			List<Contorno> profilo = new List<Contorno>();
			profilo.Add(new Contorno(ln1));
			profilo.Add(new Contorno(ln2));
			profilo.Add(new Contorno(ar1));

			List<Intersection> li1 = Function2D.Intersect(ln1, profilo[1].Tratto);
			
			CorpoOttico blocco = new CorpoOttico(new MaterialeOttico("vetro",1.4));

			#pragma warning disable
			int tmp;
			tmp = 1;
			#pragma warning restore
			}
		private void test4ToolStripMenuItem_Click(object sender,EventArgs e)
			{
			Point2D p1 = new Point2D(1, 0);
			Point2D p2 = new Point2D(0, 1);
			Point2D p3 = new Point2D (0,2);
			Point2D pc = new Point2D (0,0);
			Point2D p4 = new Point2D (2, 1);
			Point2D p1w = new Point2D(1, -0.01);

			Arc2D ar1 = new Arc2D(pc, p1, p2);
			Line2D ln1 = new Line2D(p2, p3);
			Line2D ln2 = new Line2D(p4, p3);
			Line2D ln3;
			ln3 = new Line2D(p4,p1);
//			ln3 = new Line2D(p4,p1w);

			CorpoOttico cc = new CorpoOttico(new MaterialeOttico("vetro",1.4));
			cc.Add(new Contorno(ln3));
			cc.Add(new Contorno(ln2));
			cc.Add(new Contorno(ln1));
			cc.Add(new Contorno(ar1));
			cc.Validate();

			Point2D po = new Point2D(1.5, -1);

			Line2D ray;
			ray = new Line2D(po, p1 + new Point2D(0.05,0));
			ray.Normalize();
			List<Intersection> intersezioni = cc.TrovaIntersezioniPositive(ray);

			#pragma warning disable
			int tmp;
			tmp = 1;
			#pragma warning restore

			}
		private void test5ToolStripMenuItem_Click(object sender,EventArgs e)
			{
			Line2D lin = new Line2D(0,0,1,1);
			Raggio ray0 = new Raggio(lin,700);

			Matrix mm = Matrix.Lower(4);
			Matrix mm1 = !mm;

            Point2D p1 = new Point2D(1, 0);
            Point2D p2 = new Point2D(0, 1);
            Point2D p3 = new Point2D (0,2);
            Point2D pc = new Point2D (0,0);
            Point2D p4 = new Point2D (2, 1);
            Point2D p1w = new Point2D(1, -0.01);

            Arc2D ar1 = new Arc2D(pc, p1, p2);
            Line2D ln1 = new Line2D(p2, p3);
            Line2D ln2 = new Line2D(p4, p3);
            Line2D ln3;
            ln3 = new Line2D(p4,p1);

			CorpoOttico cc = new CorpoOttico(new MaterialeOttico("vetro",1.4));
			cc.Add(new Contorno(ln3));
			cc.Add(new Contorno(ln2));
			cc.Add(new Contorno(ln1));
			cc.Add(new Contorno(ar1));
			cc.Validate();

			Point2D po = new Point2D(1.5, -1);

			Arc2D cerchio = new Arc2D(po, 4);
			

			Raggio ray;
			ray = new Raggio(new Line2D(po, p1 + new Point2D(0.05,0)),Ottica.LunghezzaOnda.Rosso);

			List<Intersection> intersezioni = cc.TrovaIntersezioniPositive(ray);
			Contorno xx = cc.Contorno(intersezioni[0].tr2);
			
			#pragma warning disable
			int tmp;
			tmp = 1;
			
			}
		private void test6RaggiToolStripMenuItem_Click(object sender, EventArgs e)
			{
			List<Raggio> listaraggi = new List<Raggio>();
			CorpoOttico lenteW = (CorpoOttico)singolo.GetOggetto(lente.GetNomeCorpoOttico());
			double yraggio, i;
			for(i = -1.1; i <= 1.1; i+=0.05)
				{
				yraggio = lente.RL * i;
				Line2D lr = new Line2D(new Point2D(-10,yraggio),new Point2D(10.0,0,false),true);
				Raggio r = new Raggio(lr,Ottica.LunghezzaOnda.Verde);
				r.CorpoAttuale = singolo.Matrice;
				listaraggi.AddRange(lenteW.CalcolaRaggi(r,singolo.Matrice));
				}
			MessageBox.Show(listaraggi.Count.ToString());

			foreach(Raggio rr in listaraggi)
				rr.Display(displayList,1);

			Invalidate();
			#pragma warning disable
			int tmp;
			tmp = 1;
			#pragma warning restore

			}
		private void test7TrasfoToolStripMenuItem_Click(object sender, EventArgs e)
			{
			Matrix A = new Matrix(3,3);
			A.Set(0,0,1);
			A.Set(0,1,2);
			A.Set(0,2,3);
			A.Set(1,0,4);
			A.Set(1,1,5);
			A.Set(1,2,6);
			A.Set(2,0,7);
			A.Set(2,1,8);
			A.Set(2,2,9);

			Matrix B = new Matrix(3,2);
			B.Set(0,0,1);
			B.Set(0,1,0);
			B.Set(1,0,-1);
			B.Set(1,1,2);
			B.Set(2,0,0);
			B.Set(2,1,1);
			Matrix C = A*B;
			Matrix D = B*A;
			MessageBox.Show("A=\n" + A.ToString());
			MessageBox.Show("B=\n" + B.ToString());
			MessageBox.Show("C=\n" + C.ToString());
			MessageBox.Show("D=\n" + D.ToString());

			Point2D p1 = new Point2D(10,5);
			MessageBox.Show("p1=\n" + p1.ToString());

			Transform2D tr;
			Transform2D t1 = Transform2D.Traslazione(100,-200);
			Transform2D t2 = Transform2D.Traslazione(-10,-20);
			tr = t1 + t2;	// Combinazione di trasformazioni
			MessageBox.Show("tr=\n" + tr.ToString());

			Matrix homo = Transform2D.Convert(p1);
			MessageBox.Show("homo=\n" + homo.ToString());

			Point2D p2 = Transform2D.Convert(homo);
			MessageBox.Show("p2=\n" + p2.ToString());

			Point2D p3 = tr.Transform(p1);
			MessageBox.Show("p3=\n" + p3.ToString());

			Transform2D rot = Transform2D.Rotazione(20,false);
			Transform2D tra = Transform2D.Traslazione(100,0);

			Transform2D rot_tra = rot + tra;
			Transform2D tra_rot = tra + rot;

			Point2D p0 = new Point2D(0,0);
			rot_tra.Transform(p0);

			MessageBox.Show(p0 + " rotXtra\n" + rot_tra.Transform(p0));
			MessageBox.Show(p0 + " traXrot\n" + tra_rot.Transform(p0));

			#pragma warning disable
			int tmp;
			tmp = 1;
			#pragma warning restore
			}
		private void test8RifrazioneToolStripMenuItem_Click(object sender, EventArgs e)
			{
			List<Point2D> lp = new List<Point2D>();
			lp.Add( new Point2D(1.0, 10.0));
			lp.Add( new Point2D(-1.0, -10.0));
			lp.Add( new Point2D(3.0, 30.0));
			lp.Add( new Point2D(4.0, 40.0));
			lp.Add( new Point2D(6.0, 60.0));
			lp.Add( new Point2D(5.0, 50.0));
			lp.Add( new Point2D(5.0, 55.0));
			lp.Add( new Point2D(-2.0, -20.0));
			lp.Add( new Point2D(-3.0, -30.0));
			lp.Add( new Point2D(2.0, 20.0));

			int i;
			double y;
			y = Function2D.InterpolazioneLineare(lp, 4.7);
			i = lp.Count;
			y = Function2D.InterpolazioneLineare(lp, 5.0);
			i = lp.Count;
			y = Function2D.InterpolazioneLineare(lp, -2.8);
			i = lp.Count;
			y = Function2D.InterpolazioneLineare(lp, -3.0);
			i = lp.Count;
			y = Function2D.InterpolazioneLineare(lp, -4.0);
			i = lp.Count;
			y = Function2D.InterpolazioneLineare(lp, 6.5);
			i = lp.Count;

			Function2D.OrdinaInX(lp);

			i = lp.Count;
			}

		#endregion

		private void Lente01_ResizeEnd(object sender,EventArgs e)
			{
			RidimensionaFinestra();
			}
		private void anisotropicoToolStripMenuItem_Click(object sender,EventArgs e)
			{
			finestra.tipoScala = Finestra.TipoScala.Anisotropico;
			Invalidate();
			}
		private void isotropicoToolStripMenuItem_Click(object sender, EventArgs e)
			{
			finestra.tipoScala = Finestra.TipoScala.Isotropico;
			Invalidate();
			}

		private void cancellaTuttoToolStripMenuItem_Click(object sender, EventArgs e)
			{
			displayList.Clear();
			singolo.CancellaOggetti();

			Point2D ax1, ax2, ax3;										// Punti assi
			ax1 = new Point2D(0,0);
			ax2 = new Point2D(finestra.P2.x,0);
			ax3 = new Point2D(0,finestra.P2.y);


			(new Line2D(ax1,ax2)).Display(displayList,3);				// Assi
			(new Line2D(ax1,ax3)).Display(displayList,3);

			this.gradiprimi.Visible=true;
			this.percdiam.Visible=true;

			Invalidate();
			}
		private void aggiungiLenteToolStripMenuItem_Click(object sender, EventArgs e)
			{
			displayList.Clear();
			singolo.CancellaOggetti();

			Point2D ax1, ax2, ax3;										// Punti assi
			ax1 = new Point2D(0,0);
			ax2 = new Point2D(finestra.P2.x,0);
			ax3 = new Point2D(0,finestra.P2.y);


			(new Line2D(ax1,ax2)).Display(displayList,3);				// Assi
			(new Line2D(ax1,ax3)).Display(displayList,3);

			this.gradiprimi.Visible=true;
			this.percdiam.Visible=true;

			//FormTrasfo ft = new FormTrasfo();
			//ft.ShowDialog();
			
			//Transform2D tr = Transform2D.Rotazione(ft.r) + Transform2D.Traslazione(ft.x,ft.y);
			//Transform2D tr = Transform2D.Traslazione(Math.Max(lente.ET,lente.CT),0.0);

			//CorpoOttico corpolente = lente.CreaCorpoOttico(tr);
			CorpoOttico corpolente = lente.CreaCorpoOttico();
			MaterialeOttico ambiente = new MaterialeOttico("vuoto", 1.0);
			singolo.Add(corpolente.Materiale);
			singolo.Add(ambiente);
			singolo.Add(corpolente);
			
			//((CorpoOttico)amb.GetOggetto("lente")).Display(displayList,0);	//lenteIn.Display(displayList,0);
			singolo.Display(displayList,0);
		
			//corpolente.Display(displayList,0);

			MessageBox.Show(singolo.ListaNomi());

			Invalidate();
			}
		private void aggiungiRaggiECalcolaToolStripMenuItem_Click(object sender, EventArgs e)
			{
			List<Raggio> listaraggi = new List<Raggio>();		// Raggi complessivi
			List<Raggio>[] routs = new List<Raggio>[2];			// Raggi tratto superiore ed inferiore
			List<Raggio> rout = new List<Raggio>();				// I due raggi finali
			List<Point2D> fuoco = new List<Point2D>();			// I punti focali

			double ang = ((double)this.angolo) / 60.0;

			this.gradiprimi.Visible = false;
			this.percdiam.Visible = false;

			CorpoOttico lenteW = (CorpoOttico)singolo.GetOggetto(lente.GetNomeCorpoOttico());
			if(lenteW != null)
				{
				double yraggio, i, xraggio, rmax;
				xraggio = Math.Max(lente.CT, lente.ET)*1.5;
				rmax = ((double)percentodiam)/100.0;
				for(i = 0.0; i <= rmax; i+=rmax/20.0)
					{
					yraggio = lente.RL * i;
					Line2D[] lr = new Line2D[2];
					lr[0] = new Line2D(new Point2D(-xraggio,yraggio),new Point2D(10.0,ang,false),true);		// raggio superiore
					lr[1] = new Line2D(new Point2D(-xraggio,-yraggio),new Point2D(10.0,ang,false),true);	// raggio inferiore

					Raggio[] r = new Raggio[2];

					r[0] = new Raggio(lr[0],Ottica.LunghezzaOnda.Rosso);
					r[1] = new Raggio(lr[1],Ottica.LunghezzaOnda.Rosso);
					r[0].CorpoAttuale = singolo.Matrice;
					r[1].CorpoAttuale = singolo.Matrice;

					routs[0] = lenteW.CalcolaRaggi(r[0],singolo.Matrice);		// Raggi superiori
					routs[1] = lenteW.CalcolaRaggi(r[1],singolo.Matrice);		// Raggi inferiori

					rout.Clear();
					if(routs[0].Count > 1)
						rout.Add((routs[0])[routs[0].Count-1]);
					if(routs[1].Count > 1)
						rout.Add((routs[1])[routs[1].Count-1]);

					listaraggi.AddRange(routs[0]);
					if(yraggio!=0.0)
						listaraggi.AddRange(routs[1]);

					// Calcola intersezione
					if(rout.Count==2)
						{
						List<Intersection> pint;
						pint = Function2D.Intersect(rout[0],rout[1]);
						if(pint.Count>0)
							{
							Intersection intr = pint[0];
							if((intr.t1>Raggio.CoincidenceDistance)&&(intr.t2>Raggio.CoincidenceDistance))
								{
								rout[0].T2r=intr.t1;
								rout[1].T2r=intr.t2;
								fuoco.Add(intr.p);
								}
							}
						}
					}
				MessageBox.Show(listaraggi.Count.ToString());

				foreach(Raggio rr in listaraggi)
					rr.Display(displayList,1);

				if(fuoco.Count > 0)
					{
					double xmin = Double.MaxValue;
					double xmax = -Double.MaxValue;
					double ymin = Double.MaxValue;
					double ymax = -Double.MaxValue;
					foreach(Point2D p in fuoco)
						{
						if(xmin > p.x)	xmin = p.x;
						if(xmax < p.x)	xmax = p.x;
						if(ymin > p.y)	ymin = p.y;
						if(ymax < p.y)	ymax = p.y;
						}
					MessageBox.Show(String.Format("Fuoco:\nX tra {0} e {1}\nY tra {2} e {3}",xmin,xmax,ymin,ymax));
					}
				}
			Invalidate();
			}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
			{
			angolo = this.gradiprimi.Value;
			}

		private void percdiam_ValueChanged(object sender, EventArgs e)
			{
			percentodiam = this.percdiam.Value;
			}

		private void aggiungiToolStripMenuItem_Click(object sender, EventArgs e)
			{
			displayList.Clear();

			Point2D ax1, ax2, ax3;										// Punti assi
			ax1 = new Point2D(0,0);
			ax2 = new Point2D(finestra.P2.x,0);
			ax3 = new Point2D(0,finestra.P2.y);


			(new Line2D(ax1,ax2)).Display(displayList,3);				// Assi
			(new Line2D(ax1,ax3)).Display(displayList,3);

			this.gradiprimi.Visible=true;
			this.percdiam.Visible=true;

			FormTrasfo ft = new FormTrasfo();
			ft.ShowDialog();
			
			Transform2D tr = Transform2D.Rotazione(ft.r) + Transform2D.Traslazione(ft.x,ft.y);
			//Transform2D tr = Transform2D.Traslazione(Math.Max(lente.ET,lente.CT),0.0);

			CorpoOttico corpolente = lente.CreaCorpoOttico(tr);
			MaterialeOttico ambiente = new MaterialeOttico("vuoto", 1.0);
			completo.Add(corpolente.Materiale);
			completo.Add(ambiente);
			completo.Add(corpolente);
			
			//((CorpoOttico)amb.GetOggetto("lente")).Display(displayList,0);	//lenteIn.Display(displayList,0);
			completo.Display(displayList,0);
		
			//corpolente.Display(displayList,0);

			

			Invalidate();

			}

		private void singoloToolStripMenuItem_Click(object sender, EventArgs e)
			{
			ambienteAttivo = singolo;
			displayList.Clear();
			ambienteAttivo.Display(displayList,0);
			Invalidate();
			}

		private void completoToolStripMenuItem_Click(object sender, EventArgs e)
			{
			ambienteAttivo = completo;
			displayList.Clear();
			ambienteAttivo.Display(displayList,0);
			Invalidate();
			}

		private void cancellaTuttoToolStripMenuItem1_Click(object sender, EventArgs e)
			{
			displayList.Clear();
			completo.CancellaOggetti();
			Invalidate();
			}

		private void calcolaRaggiToolStripMenuItem_Click(object sender, EventArgs e)
			{
			double xraggio, yraggio, alfraggio;

			FormTrasfo ft = new FormTrasfo();
			ft.Text = "Inserimento del raggio, angolo in gradi";
			ft.ShowDialog();

			xraggio = ft.x;
			yraggio = ft.y;
			alfraggio = ft.r;			

			Line2D lr;
			lr = new Line2D(new Point2D(xraggio,yraggio),new Point2D(10.0,alfraggio,true),true);
			Raggio r = new Raggio(lr,Ottica.LunghezzaOnda.linea_C);
			r.CorpoAttuale = completo.Matrice;

			List<Raggio> raggi;

			raggi = completo.CalcolaRaggio(r);
			MessageBox.Show(raggi.Count.ToString());
			foreach(Raggio rr in raggi)
				rr.Display(displayList,1);

			Invalidate();
			}

		private void test9MatOtticiToolStripMenuItem_Click(object sender, EventArgs e)
			{
			MessageBox.Show(Ottica.MaterialiOttici.Lista());
			double lambda;

			lambda = Ottica.LunghezzaOnda.linea_HeNe;
			MessageBox.Show("FC5 " + Ottica.MaterialiOttici.Get("FC5").GetnRifrazione(lambda).ToString() +"@"+lambda);
			lambda = Ottica.LunghezzaOnda.Rosso;
			//MessageBox.Show("E-BAF8 " + Ottica.MaterialiOttici.Get("E-BAF8").GetnRifrazione(lambda).ToString() +"@"+lambda);
			lambda = Ottica.LunghezzaOnda.linea_D;
			//MessageBox.Show("E-CF6 " + Ottica.MaterialiOttici.Get("E-CF6").GetnRifrazione(lambda).ToString() +"@"+lambda);
			MessageBox.Show("LBC3N " + Ottica.MaterialiOttici.Get("LBC3N").GetnRifrazione(lambda).ToString() +"@"+lambda);
			}

		private void modificaSorgenteToolStripMenuItem_Click(object sender, EventArgs e)
			{
			FormSorgente formsorgente = new FormSorgente(this.sorgente);
			if(formsorgente.ShowDialog() == DialogResult.OK)
				{
				this.sorgente = formsorgente.sorgente;
				}
			formsorgente.Close();
			Invalidate();
			}

		private void nuovaSorgenteToolStripMenuItem_Click(object sender, EventArgs e)
			{
			FormSorgente formsorgente = new FormSorgente();
			if (formsorgente.ShowDialog() == DialogResult.OK)
				{
				this.sorgente = formsorgente.sorgente;
				}
			formsorgente.Close();
			Invalidate();
			}

		private void aggiungiSorgenteToolStripMenuItem_Click(object sender, EventArgs e)
			{
			displayList.Clear();
			FormTrasfo ft = new FormTrasfo();
			ft.ShowDialog();
			SorgenteOttica corposorgente = new SorgenteOttica(	sorgente.Nome,
																new Point2D(ft.x,ft.y),
																ft.r + sorgente.Direzione.Alfa(),
																true,
																sorgente.Diametro,
																sorgente.Divergenza,
																sorgente.Lambda,
																sorgente.nRaggi
																);
			corposorgente.Validate();
			completo.Add(corposorgente);
			completo.Display(displayList,0);
			Invalidate();
			}

		private void listaNomiToolStripMenuItem_Click(object sender, EventArgs e)
			{
			MessageBox.Show(completo.ListaNomi());
			}

		private void calcolaRaggitestToolStripMenuItem_Click(object sender, EventArgs e)
			{
			List<Raggio> raggi;
			raggi = completo.CalcolaRaggi();
			MessageBox.Show(raggi.Count.ToString());
			foreach(Raggio rr in raggi)
				rr.Display(displayList,1);
			Invalidate();
			}

		private void Lente01_Load(object sender, EventArgs e) {

			}



		}
	}

#pragma warning restore 1591
