using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Fred68.Tools.Engineering;
using Fred68.Tools.Matematica;
using Lente01.Properties;						// Risorse

#pragma warning disable 1591

namespace Lente01
	{
	public partial class FormSorgente: Form
		{
		SorgenteOttica dSorgente;
		public SorgenteOttica sorgente
			{
			get	{
				return dSorgente;
				}
			set	{
				dSorgente = value;
				}
			}
		public FormSorgente()
			{
			this.dSorgente = new SorgenteOttica();
			InitializeComponent();
			this.Text = Resources.FormSorgenteTitolo;
			}

		public FormSorgente(SorgenteOttica pSorgente)
			{
			this.dSorgente = new SorgenteOttica(pSorgente);	// Chiama il costruttore di copia di SorgenteOttica
			InitializeComponent();
			this.Text = Resources.FormSorgenteTitolo;
			}

		private void FormSorgente_Load(object sender, EventArgs e)
			{
			this.ImpostaCampi();
			}

		private void OKButton_Click(object sender, EventArgs e)
			{
			LeggiCampi(SorgenteOttica.TipoSorgente.collimata);
			ImpostaCampi();
			this.DialogResult = DialogResult.OK;
			}

		private void CancelButton_Click(object sender, EventArgs e)
			{
			this.DialogResult = DialogResult.Cancel;
			}

		private void CalcolaButton_Click(object sender, EventArgs e)
			{
			Ricalcola(SorgenteOttica.TipoSorgente.collimata);
			}

		private void tb_Nome_Leave(object sender, EventArgs e)		{Ricalcola(SorgenteOttica.TipoSorgente.collimata);}
		private void tb_D_Leave(object sender, EventArgs e)			{Ricalcola(SorgenteOttica.TipoSorgente.collimata);}
		private void tb_alfa_Leave(object sender, EventArgs e)		{Ricalcola(SorgenteOttica.TipoSorgente.collimata);}
		private void tb_div_Leave(object sender, EventArgs e)		{Ricalcola(SorgenteOttica.TipoSorgente.collimata);}
		private void tb_lambda_Leave(object sender, EventArgs e)	{Ricalcola(SorgenteOttica.TipoSorgente.collimata);}
		private void tb_nr_Leave(object sender, EventArgs e)		{Ricalcola(SorgenteOttica.TipoSorgente.collimata);}

		protected void Ricalcola(SorgenteOttica.TipoSorgente tp)
			{
			switch(tp)
				{
				case SorgenteOttica.TipoSorgente.collimata:
					{
					LeggiCampi(tp);
					ImpostaCampi();
					}
					break;
				case SorgenteOttica.TipoSorgente.puntiforme:
					{
					throw new Exception("TipoSorgente.puntiforme non implementata");
					}
				default:
					{
					throw new Exception("TipoSorgente non gestita");
					}
				}
			}
		protected void LeggiCampi(SorgenteOttica.TipoSorgente ts)
			{
			double itmp;
			dSorgente.Nome = this.tb_Nome.Text;
			switch(ts)
				{
				case SorgenteOttica.TipoSorgente.collimata:
					{
					if (double.TryParse(this.tb_D.Text, out itmp))
						dSorgente.Diametro = itmp;
					if (double.TryParse(this.tb_alfa.Text, out itmp))
						{
						double alfrad = (itmp*Math.PI)/180.0;									// Angolo in radianti
						dSorgente.Direzione = new Point2D(Math.Cos(alfrad),Math.Sin(alfrad));
						}
					if (double.TryParse(this.tb_div.Text, out itmp))							// Angolo in radianti
						dSorgente.Divergenza = itmp/1000.0;
					if (double.TryParse(this.tb_lambda.Text, out itmp))
						dSorgente.Lambda = itmp;
					if (double.TryParse(this.tb_nr.Text, out itmp))
						dSorgente.nRaggi = (int)itmp;
					}
					break;
				case SorgenteOttica.TipoSorgente.puntiforme:
					throw new Exception("TipoSorgente.puntiforme non impleimentata");
				default:
					throw new Exception("TipoSorgente non gestita");
				}

			}
		protected void ImpostaCampi()
			{
			this.tb_Nome.Text = dSorgente.Nome.ToString();						// Imposta il contenuto
			this.tb_D.Text = dSorgente.Diametro.ToString();
			this.tb_alfa.Text = dSorgente.Direzione.Alfa(false).ToString();
			this.tb_div.Text = (dSorgente.Divergenza*1000.0).ToString();
			this.tb_lambda.Text = dSorgente.Lambda.ToString();
			this.tb_nr.Text = dSorgente.nRaggi.ToString();

			if(dSorgente.IsValid)
				{
				this.lbl_VALIDA.Text = Resources.LenteValida;
				this.lbl_VALIDA.ForeColor = Color.Black;
				this.OKButton.Enabled = true;
				}
			else
				{
				this.lbl_VALIDA.Text = Resources.LenteNonValida;
				this.lbl_VALIDA.ForeColor = Color.Red;
				this.OKButton.Enabled = false;
				}
			}

		}
	}

#pragma warning restore 1591