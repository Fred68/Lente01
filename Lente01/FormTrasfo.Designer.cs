namespace Lente01 {
	partial class FormTrasfo {
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
			this.tb_X = new System.Windows.Forms.TextBox();
			this.tb_Y = new System.Windows.Forms.TextBox();
			this.tb_R = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.IdOK = new System.Windows.Forms.Button();
			this.IdCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_X
			// 
			this.tb_X.Location = new System.Drawing.Point(105, 43);
			this.tb_X.Name = "tb_X";
			this.tb_X.Size = new System.Drawing.Size(100, 20);
			this.tb_X.TabIndex = 0;
			// 
			// tb_Y
			// 
			this.tb_Y.Location = new System.Drawing.Point(105, 70);
			this.tb_Y.Name = "tb_Y";
			this.tb_Y.Size = new System.Drawing.Size(100, 20);
			this.tb_Y.TabIndex = 1;
			// 
			// tb_R
			// 
			this.tb_R.Location = new System.Drawing.Point(105, 97);
			this.tb_R.Name = "tb_R";
			this.tb_R.Size = new System.Drawing.Size(100, 20);
			this.tb_R.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Traslazione X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Traslazione Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Rotazione";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(214, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "gradi";
			// 
			// IdOK
			// 
			this.IdOK.Location = new System.Drawing.Point(105, 135);
			this.IdOK.Name = "IdOK";
			this.IdOK.Size = new System.Drawing.Size(75, 23);
			this.IdOK.TabIndex = 9;
			this.IdOK.Text = "OK";
			this.IdOK.UseVisualStyleBackColor = true;
			this.IdOK.Click += new System.EventHandler(this.IdOK_Click);
			// 
			// IdCancel
			// 
			this.IdCancel.Location = new System.Drawing.Point(186, 135);
			this.IdCancel.Name = "IdCancel";
			this.IdCancel.Size = new System.Drawing.Size(75, 23);
			this.IdCancel.TabIndex = 10;
			this.IdCancel.Text = "Annulla";
			this.IdCancel.UseVisualStyleBackColor = true;
			// 
			// FormTrasfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 195);
			this.Controls.Add(this.IdCancel);
			this.Controls.Add(this.IdOK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_R);
			this.Controls.Add(this.tb_Y);
			this.Controls.Add(this.tb_X);
			this.Name = "FormTrasfo";
			this.Text = "FormTrasfo";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.TextBox tb_X;
		private System.Windows.Forms.TextBox tb_Y;
		private System.Windows.Forms.TextBox tb_R;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button IdOK;
		private System.Windows.Forms.Button IdCancel;
		}
	}