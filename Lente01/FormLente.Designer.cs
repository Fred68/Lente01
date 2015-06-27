namespace Lente01
	{
	public partial class FormLente
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
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.CalcolaButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_VALIDA = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.tb_ET = new System.Windows.Forms.TextBox();
			this.tb_CT = new System.Windows.Forms.TextBox();
			this.tb_n = new System.Windows.Forms.TextBox();
			this.tb_DL = new System.Windows.Forms.TextBox();
			this.tb_RL = new System.Windows.Forms.TextBox();
			this.tb_R1 = new System.Windows.Forms.TextBox();
			this.tb_R2 = new System.Windows.Forms.TextBox();
			this.cb_S1 = new System.Windows.Forms.ComboBox();
			this.cb_S2 = new System.Windows.Forms.ComboBox();
			this.tb_Nome = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OKButton
			// 
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OKButton.Location = new System.Drawing.Point(210, 475);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(73, 34);
			this.OKButton.TabIndex = 1010;
			this.OKButton.Text = "Ok";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelButton.Location = new System.Drawing.Point(289, 475);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(73, 34);
			this.CancelButton.TabIndex = 1020;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// CalcolaButton
			// 
			this.CalcolaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalcolaButton.Location = new System.Drawing.Point(131, 475);
			this.CalcolaButton.Name = "CalcolaButton";
			this.CalcolaButton.Size = new System.Drawing.Size(73, 34);
			this.CalcolaButton.TabIndex = 1000;
			this.CalcolaButton.Text = "Calcola";
			this.CalcolaButton.UseVisualStyleBackColor = true;
			this.CalcolaButton.Click += new System.EventHandler(this.CalcolaButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Dati della lente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Edge thickness";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Center thickness";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Indice di rifrazione";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(33, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Diametro lente";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(33, 285);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Raggio lente";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(33, 321);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 16);
			this.label7.TabIndex = 9;
			this.label7.Text = "Superficie di ingresso";
			// 
			// lbl_VALIDA
			// 
			this.lbl_VALIDA.AutoSize = true;
			this.lbl_VALIDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_VALIDA.Location = new System.Drawing.Point(33, 75);
			this.lbl_VALIDA.Name = "lbl_VALIDA";
			this.lbl_VALIDA.Size = new System.Drawing.Size(93, 16);
			this.lbl_VALIDA.TabIndex = 10;
			this.lbl_VALIDA.Text = "Lente valida";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(33, 357);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(125, 16);
			this.label9.TabIndex = 11;
			this.label9.Text = "Raggio di curvatura";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(33, 393);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 16);
			this.label10.TabIndex = 12;
			this.label10.Text = "Superficie di uscita";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(33, 429);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(125, 16);
			this.label11.TabIndex = 13;
			this.label11.Text = "Raggio di curvatura";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(168, 429);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(25, 16);
			this.label12.TabIndex = 22;
			this.label12.Text = "R2";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(168, 357);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(25, 16);
			this.label14.TabIndex = 20;
			this.label14.Text = "R1";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(168, 285);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(25, 16);
			this.label16.TabIndex = 18;
			this.label16.Text = "RL";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(168, 249);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(25, 16);
			this.label17.TabIndex = 17;
			this.label17.Text = "DL";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(169, 213);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(15, 16);
			this.label18.TabIndex = 16;
			this.label18.Text = "n";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(169, 177);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(26, 16);
			this.label19.TabIndex = 15;
			this.label19.Text = "CT";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(167, 141);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(26, 16);
			this.label20.TabIndex = 14;
			this.label20.Text = "ET";
			// 
			// tb_ET
			// 
			this.tb_ET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_ET.Location = new System.Drawing.Point(236, 138);
			this.tb_ET.Name = "tb_ET";
			this.tb_ET.Size = new System.Drawing.Size(126, 22);
			this.tb_ET.TabIndex = 20;
			this.tb_ET.Leave += new System.EventHandler(this.tb_ET_Leave);
			// 
			// tb_CT
			// 
			this.tb_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_CT.Location = new System.Drawing.Point(236, 174);
			this.tb_CT.Name = "tb_CT";
			this.tb_CT.ReadOnly = true;
			this.tb_CT.Size = new System.Drawing.Size(126, 22);
			this.tb_CT.TabIndex = 24;
			this.tb_CT.TabStop = false;
			// 
			// tb_n
			// 
			this.tb_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_n.Location = new System.Drawing.Point(236, 210);
			this.tb_n.Name = "tb_n";
			this.tb_n.Size = new System.Drawing.Size(126, 22);
			this.tb_n.TabIndex = 30;
			this.tb_n.Leave += new System.EventHandler(this.tb_n_Leave);
			// 
			// tb_DL
			// 
			this.tb_DL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_DL.Location = new System.Drawing.Point(236, 246);
			this.tb_DL.Name = "tb_DL";
			this.tb_DL.Size = new System.Drawing.Size(126, 22);
			this.tb_DL.TabIndex = 40;
			this.tb_DL.Leave += new System.EventHandler(this.tb_DL_Leave);
			// 
			// tb_RL
			// 
			this.tb_RL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_RL.Location = new System.Drawing.Point(236, 282);
			this.tb_RL.Name = "tb_RL";
			this.tb_RL.ReadOnly = true;
			this.tb_RL.Size = new System.Drawing.Size(126, 22);
			this.tb_RL.TabIndex = 27;
			this.tb_RL.TabStop = false;
			// 
			// tb_R1
			// 
			this.tb_R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_R1.Location = new System.Drawing.Point(236, 354);
			this.tb_R1.Name = "tb_R1";
			this.tb_R1.Size = new System.Drawing.Size(126, 22);
			this.tb_R1.TabIndex = 60;
			this.tb_R1.Leave += new System.EventHandler(this.tb_R1_Leave);
			// 
			// tb_R2
			// 
			this.tb_R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_R2.Location = new System.Drawing.Point(236, 426);
			this.tb_R2.Name = "tb_R2";
			this.tb_R2.Size = new System.Drawing.Size(126, 22);
			this.tb_R2.TabIndex = 80;
			this.tb_R2.Leave += new System.EventHandler(this.tb_R2_Leave);
			// 
			// cb_S1
			// 
			this.cb_S1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_S1.FormattingEnabled = true;
			this.cb_S1.Items.AddRange(new object[] {
            "convessa",
            "piana",
            "concava"});
			this.cb_S1.Location = new System.Drawing.Point(236, 318);
			this.cb_S1.Name = "cb_S1";
			this.cb_S1.Size = new System.Drawing.Size(126, 24);
			this.cb_S1.TabIndex = 50;
			this.cb_S1.SelectedIndexChanged += new System.EventHandler(this.cb_S1_SelectedIndexChanged);
			// 
			// cb_S2
			// 
			this.cb_S2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_S2.FormattingEnabled = true;
			this.cb_S2.Items.AddRange(new object[] {
            "convessa",
            "piana",
            "concava"});
			this.cb_S2.Location = new System.Drawing.Point(236, 390);
			this.cb_S2.Name = "cb_S2";
			this.cb_S2.Size = new System.Drawing.Size(126, 24);
			this.cb_S2.TabIndex = 70;
			this.cb_S2.SelectedIndexChanged += new System.EventHandler(this.cb_S2_SelectedIndexChanged);
			// 
			// tb_Nome
			// 
			this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Nome.Location = new System.Drawing.Point(236, 102);
			this.tb_Nome.Name = "tb_Nome";
			this.tb_Nome.Size = new System.Drawing.Size(126, 22);
			this.tb_Nome.TabIndex = 10;
			this.tb_Nome.Leave += new System.EventHandler(this.tb_Nome_Leave);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(167, 105);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 16);
			this.label8.TabIndex = 33;
			this.label8.Text = "Name";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(33, 105);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 16);
			this.label13.TabIndex = 32;
			this.label13.Text = "Nome";
			// 
			// FormLente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 534);
			this.Controls.Add(this.tb_Nome);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.cb_S2);
			this.Controls.Add(this.cb_S1);
			this.Controls.Add(this.tb_R2);
			this.Controls.Add(this.tb_R1);
			this.Controls.Add(this.tb_RL);
			this.Controls.Add(this.tb_DL);
			this.Controls.Add(this.tb_n);
			this.Controls.Add(this.tb_CT);
			this.Controls.Add(this.tb_ET);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lbl_VALIDA);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CalcolaButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Name = "FormLente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dati della lente";
			this.Load += new System.EventHandler(this.FormLente_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button OKButton;
		private new System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button CalcolaButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_VALIDA;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox tb_ET;
		private System.Windows.Forms.TextBox tb_CT;
		private System.Windows.Forms.TextBox tb_n;
		private System.Windows.Forms.TextBox tb_DL;
		private System.Windows.Forms.TextBox tb_RL;
		private System.Windows.Forms.TextBox tb_R1;
		private System.Windows.Forms.TextBox tb_R2;
		private System.Windows.Forms.ComboBox cb_S1;
		private System.Windows.Forms.ComboBox cb_S2;
		private System.Windows.Forms.TextBox tb_Nome;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label13;		// Ridefinisce
		}
	}