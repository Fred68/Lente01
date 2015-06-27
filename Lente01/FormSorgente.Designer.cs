namespace Lente01 {
	partial class FormSorgente {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Nome = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.tb_D = new System.Windows.Forms.TextBox();
			this.tb_alfa = new System.Windows.Forms.TextBox();
			this.tb_lambda = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tb_div = new System.Windows.Forms.TextBox();
			this.CalcolaButton = new System.Windows.Forms.Button();
			this.tb_nr = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_VALIDA = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OKButton
			// 
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OKButton.Location = new System.Drawing.Point(215, 420);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(73, 34);
			this.OKButton.TabIndex = 1010;
			this.OKButton.Text = "Ok";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelButton.Location = new System.Drawing.Point(294, 420);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(73, 34);
			this.CancelButton.TabIndex = 1020;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 38;
			this.label2.Text = "Diametro";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 16);
			this.label4.TabIndex = 40;
			this.label4.Text = "Angolo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 214);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 16);
			this.label5.TabIndex = 41;
			this.label5.Text = "Lunghezza d\'onda";
			// 
			// tb_Nome
			// 
			this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Nome.Location = new System.Drawing.Point(241, 99);
			this.tb_Nome.Name = "tb_Nome";
			this.tb_Nome.Size = new System.Drawing.Size(126, 22);
			this.tb_Nome.TabIndex = 10;
			this.tb_Nome.Leave += new System.EventHandler(this.tb_Nome_Leave);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(172, 130);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(18, 16);
			this.label20.TabIndex = 48;
			this.label20.Text = "D";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(174, 158);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(32, 16);
			this.label18.TabIndex = 50;
			this.label18.Text = "deg";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(173, 214);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(26, 16);
			this.label17.TabIndex = 51;
			this.label17.Text = "nm";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_D
			// 
			this.tb_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_D.Location = new System.Drawing.Point(241, 127);
			this.tb_D.Name = "tb_D";
			this.tb_D.Size = new System.Drawing.Size(126, 22);
			this.tb_D.TabIndex = 20;
			this.tb_D.Leave += new System.EventHandler(this.tb_D_Leave);
			// 
			// tb_alfa
			// 
			this.tb_alfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_alfa.Location = new System.Drawing.Point(241, 155);
			this.tb_alfa.Name = "tb_alfa";
			this.tb_alfa.Size = new System.Drawing.Size(126, 22);
			this.tb_alfa.TabIndex = 30;
			this.tb_alfa.Leave += new System.EventHandler(this.tb_alfa_Leave);
			// 
			// tb_lambda
			// 
			this.tb_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_lambda.Location = new System.Drawing.Point(241, 211);
			this.tb_lambda.Name = "tb_lambda";
			this.tb_lambda.Size = new System.Drawing.Size(126, 22);
			this.tb_lambda.TabIndex = 50;
			this.tb_lambda.Leave += new System.EventHandler(this.tb_lambda_Leave);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(38, 102);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 16);
			this.label13.TabIndex = 64;
			this.label13.Text = "Nome";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(172, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 16);
			this.label8.TabIndex = 65;
			this.label8.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 16);
			this.label3.TabIndex = 39;
			this.label3.Text = "Divergenza";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(174, 186);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(39, 16);
			this.label19.TabIndex = 49;
			this.label19.Text = "mrad";
			// 
			// tb_div
			// 
			this.tb_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_div.Location = new System.Drawing.Point(241, 183);
			this.tb_div.Name = "tb_div";
			this.tb_div.Size = new System.Drawing.Size(126, 22);
			this.tb_div.TabIndex = 40;
			this.tb_div.Leave += new System.EventHandler(this.tb_div_Leave);
			// 
			// CalcolaButton
			// 
			this.CalcolaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalcolaButton.Location = new System.Drawing.Point(136, 420);
			this.CalcolaButton.Name = "CalcolaButton";
			this.CalcolaButton.Size = new System.Drawing.Size(73, 34);
			this.CalcolaButton.TabIndex = 1000;
			this.CalcolaButton.Text = "Calcola";
			this.CalcolaButton.UseVisualStyleBackColor = true;
			this.CalcolaButton.Click += new System.EventHandler(this.CalcolaButton_Click);
			// 
			// tb_nr
			// 
			this.tb_nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_nr.Location = new System.Drawing.Point(241, 239);
			this.tb_nr.Name = "tb_nr";
			this.tb_nr.Size = new System.Drawing.Size(126, 22);
			this.tb_nr.TabIndex = 60;
			this.tb_nr.Leave += new System.EventHandler(this.tb_nr_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 16);
			this.label6.TabIndex = 67;
			this.label6.Text = "Numero di raggi";
			// 
			// lbl_VALIDA
			// 
			this.lbl_VALIDA.AutoSize = true;
			this.lbl_VALIDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_VALIDA.Location = new System.Drawing.Point(38, 65);
			this.lbl_VALIDA.Name = "lbl_VALIDA";
			this.lbl_VALIDA.Size = new System.Drawing.Size(93, 16);
			this.lbl_VALIDA.TabIndex = 71;
			this.lbl_VALIDA.Text = "Lente valida";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(252, 20);
			this.label1.TabIndex = 70;
			this.label1.Text = "Dati della sorgente puntiforme";
			// 
			// FormSorgente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 475);
			this.Controls.Add(this.lbl_VALIDA);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_nr);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_Nome);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.tb_lambda);
			this.Controls.Add(this.tb_alfa);
			this.Controls.Add(this.tb_div);
			this.Controls.Add(this.tb_D);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CalcolaButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Name = "FormSorgente";
			this.Text = "FormSorgente";
			this.Load += new System.EventHandler(this.FormSorgente_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_Nome;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tb_D;
		private System.Windows.Forms.TextBox tb_alfa;
		private System.Windows.Forms.TextBox tb_lambda;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tb_div;
		private System.Windows.Forms.Button CalcolaButton;
		private System.Windows.Forms.TextBox tb_nr;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_VALIDA;
		private System.Windows.Forms.Label label1;

		}
	}