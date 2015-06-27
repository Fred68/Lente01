using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Fred68.Tools.Engineering;
using Lente01.Properties;						// Risorse

#pragma warning disable 1591

namespace Lente01
	{
	public partial class FormLente : Form
		{
		Lente dLente;
		public Lente lente
			{
			get	{
				return dLente;
				}
			set	{
				dLente = value;
				}
			}
		public FormLente()						// Costruttore 
			{
			this.dLente = new Lente();			// Chiama il costruttore di Lente
			InitializeComponent();
			this.Text = Resources.FormLenteTitolo;
			}
		public FormLente(Lente pLente)			// Costruttore 
			{
			this.dLente = new Lente(pLente);	// Chiama il costruttore di copia di Lente
			InitializeComponent();
			this.Text = Resources.FormLenteTitolo;
			}
		private void FormLente_Load(object sender, EventArgs e) 
			{
			this.cb_S1.Items.Clear();
			this.cb_S1.Items.Add(Lente.TipoSuperficie.concava);
			this.cb_S1.Items.Add(Lente.TipoSuperficie.convessa);
			this.cb_S1.Items.Add(Lente.TipoSuperficie.piana);
			
			this.cb_S2.Items.Clear();
			this.cb_S2.Items.Add(Lente.TipoSuperficie.concava);
			this.cb_S2.Items.Add(Lente.TipoSuperficie.convessa);
			this.cb_S2.Items.Add(Lente.TipoSuperficie.piana);
			this.ImpostaCampi();
			}
		private void OkButton_Click(object sender, EventArgs e)			// Pulsante OK
			{															// Chiude la form ma non la distrugge.
			LeggiCampi();
			ImpostaCampi();
			this.DialogResult = DialogResult.OK;						
			}
		private void CancelButton_Click(object sender, EventArgs e)		// Pulsante Cancel
			{
			this.DialogResult = DialogResult.Cancel;
			}
		private void CalcolaButton_Click(object sender, EventArgs e)	// Calcola ed assegna
			{
			Ricalcola();
			}
		protected void Ricalcola()
			{
			LeggiCampi();						// Legge i campi (lente calcolata automaticamente)
			ImpostaCampi();						// E li reimposta dopo il calcolo
			}
		protected void LeggiCampi()
			{
			double itmp;
			if (double.TryParse(this.tb_ET.Text, out itmp)) dLente.ET = itmp;
			if (double.TryParse(this.tb_n.Text, out itmp)) dLente.N = itmp;
			if (double.TryParse(this.tb_DL.Text, out itmp)) dLente.D = itmp;
			if (double.TryParse(this.tb_R1.Text, out itmp)) dLente.R1 = itmp;
			if (double.TryParse(this.tb_R2.Text, out itmp)) dLente.R2 = itmp;
			dLente.Nome = this.tb_Nome.Text;
			if (this.cb_S1.SelectedIndex != -1)
				dLente.TIPO1 = (Lente.TipoSuperficie)this.cb_S1.SelectedItem;
			if (this.cb_S2.SelectedIndex != -1)
				dLente.TIPO2 = (Lente.TipoSuperficie)this.cb_S2.SelectedItem;
			if(dLente.TIPO1 == Lente.TipoSuperficie.piana)
				{
				tb_R1.ReadOnly = true;
				}
			else
				{
				tb_R1.ReadOnly = false;
				}
			if (dLente.TIPO2 == Lente.TipoSuperficie.piana)
				{
				tb_R2.ReadOnly = true;
				}
			else
				{
				tb_R2.ReadOnly = false;
				}
			}
		protected void ImpostaCampi()
			{
			this.tb_ET.Text = dLente.ET.ToString();						// Imposta il contenuto
			this.tb_CT.Text = dLente.CT.ToString();						// dei campi della form
			this.tb_n.Text = dLente.N.ToString();
			this.tb_DL.Text = dLente.D.ToString();
			this.tb_RL.Text = dLente.RL.ToString();
			this.tb_R1.Text = dLente.R1.ToString();
			this.tb_R2.Text = dLente.R2.ToString();
			this.tb_Nome.Text = dLente.Nome;	
			// Eseguire per ultime !
			// Richiamano l'handler selected index changed, che esegue un Ricalcola()
			// che richiama a sua volta LeggiCampi(), prima di inizializzarli.
			this.cb_S1.SelectedIndex = this.cb_S1.FindStringExact(dLente.TIPO1.ToString());
			this.cb_S2.SelectedIndex = this.cb_S2.FindStringExact(dLente.TIPO2.ToString());
			if(dLente.IsValid)
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
		private void cb_S1_SelectedIndexChanged(object sender, EventArgs e)
			{
			if(((Lente.TipoSuperficie)((ComboBox)sender).SelectedItem) == Lente.TipoSuperficie.piana)
				{
				tb_R1.ReadOnly = true;
				}
			else
				{
				tb_R1.ReadOnly = false;
				}
			Ricalcola();
			}
		private void cb_S2_SelectedIndexChanged(object sender, EventArgs e)
			{
			if (((Lente.TipoSuperficie)((ComboBox)sender).SelectedItem) == Lente.TipoSuperficie.piana)
				{
				tb_R2.ReadOnly = true;
				}
			else
				{
				tb_R2.ReadOnly = false;
				}
			Ricalcola();
			}
		private void tb_ET_Leave(object sender, EventArgs e)
			{
			Ricalcola();
			}

		private void tb_n_Leave(object sender, EventArgs e)
			{
			Ricalcola();
			}

		private void tb_DL_Leave(object sender, EventArgs e)
			{
			Ricalcola();
			}

		private void tb_R1_Leave(object sender, EventArgs e)
			{
			Ricalcola();
			}

		private void tb_R2_Leave(object sender, EventArgs e)
			{
			Ricalcola();
			}

		private void tb_Nome_Leave(object sender, EventArgs e)
			{
			Ricalcola();
			}
		}
	}
#pragma warning restore 1591