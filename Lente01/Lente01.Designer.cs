namespace Lente01
	{
	partial class Lente01
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
			this.barraMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificaLenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuovaLenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aggiungiLenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancellaTuttoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aggiungiRaggiECalcolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sorgenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificaSorgenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuovaSorgenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aggiungiSorgenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancellaTuttoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.calcolaRaggiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaNomiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calcolaRaggitestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fitZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scaleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.isotropicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anisotropicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.singoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.completoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test6RaggiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test7TrasfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test8RifrazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test9MatOtticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.openDialog = new System.Windows.Forms.OpenFileDialog();
			this.gradiprimi = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.percdiam = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.barraMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradiprimi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.percdiam)).BeginInit();
			this.SuspendLayout();
			// 
			// barraMenu
			// 
			this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sorgenteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.tESTToolStripMenuItem});
			this.barraMenu.Location = new System.Drawing.Point(0, 0);
			this.barraMenu.Name = "barraMenu";
			this.barraMenu.Size = new System.Drawing.Size(684, 24);
			this.barraMenu.TabIndex = 0;
			this.barraMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaLenteToolStripMenuItem,
            this.nuovaLenteToolStripMenuItem,
            this.aggiungiLenteToolStripMenuItem,
            this.cancellaTuttoToolStripMenuItem,
            this.aggiungiRaggiECalcolaToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.editToolStripMenuItem.Text = "Lente";
			// 
			// modificaLenteToolStripMenuItem
			// 
			this.modificaLenteToolStripMenuItem.Name = "modificaLenteToolStripMenuItem";
			this.modificaLenteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.modificaLenteToolStripMenuItem.Text = "Modifica lente";
			this.modificaLenteToolStripMenuItem.Click += new System.EventHandler(this.modificaLenteToolStripMenuItem_Click);
			// 
			// nuovaLenteToolStripMenuItem
			// 
			this.nuovaLenteToolStripMenuItem.Name = "nuovaLenteToolStripMenuItem";
			this.nuovaLenteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.nuovaLenteToolStripMenuItem.Text = "Nuova lente";
			this.nuovaLenteToolStripMenuItem.Click += new System.EventHandler(this.nuovaLenteToolStripMenuItem_Click);
			// 
			// aggiungiLenteToolStripMenuItem
			// 
			this.aggiungiLenteToolStripMenuItem.Name = "aggiungiLenteToolStripMenuItem";
			this.aggiungiLenteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.aggiungiLenteToolStripMenuItem.Text = "Aggiungi lente";
			this.aggiungiLenteToolStripMenuItem.Click += new System.EventHandler(this.aggiungiLenteToolStripMenuItem_Click);
			// 
			// cancellaTuttoToolStripMenuItem
			// 
			this.cancellaTuttoToolStripMenuItem.Name = "cancellaTuttoToolStripMenuItem";
			this.cancellaTuttoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.cancellaTuttoToolStripMenuItem.Text = "Cancella lente";
			this.cancellaTuttoToolStripMenuItem.Click += new System.EventHandler(this.cancellaTuttoToolStripMenuItem_Click);
			// 
			// aggiungiRaggiECalcolaToolStripMenuItem
			// 
			this.aggiungiRaggiECalcolaToolStripMenuItem.Name = "aggiungiRaggiECalcolaToolStripMenuItem";
			this.aggiungiRaggiECalcolaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.aggiungiRaggiECalcolaToolStripMenuItem.Text = "Aggiungi raggi e calcola";
			this.aggiungiRaggiECalcolaToolStripMenuItem.Click += new System.EventHandler(this.aggiungiRaggiECalcolaToolStripMenuItem_Click);
			// 
			// sorgenteToolStripMenuItem
			// 
			this.sorgenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaSorgenteToolStripMenuItem,
            this.nuovaSorgenteToolStripMenuItem});
			this.sorgenteToolStripMenuItem.Name = "sorgenteToolStripMenuItem";
			this.sorgenteToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
			this.sorgenteToolStripMenuItem.Text = "Sorgente collimata";
			// 
			// modificaSorgenteToolStripMenuItem
			// 
			this.modificaSorgenteToolStripMenuItem.Name = "modificaSorgenteToolStripMenuItem";
			this.modificaSorgenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.modificaSorgenteToolStripMenuItem.Text = "Modifica sorgente";
			this.modificaSorgenteToolStripMenuItem.Click += new System.EventHandler(this.modificaSorgenteToolStripMenuItem_Click);
			// 
			// nuovaSorgenteToolStripMenuItem
			// 
			this.nuovaSorgenteToolStripMenuItem.Name = "nuovaSorgenteToolStripMenuItem";
			this.nuovaSorgenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.nuovaSorgenteToolStripMenuItem.Text = "Nuova sorgente";
			this.nuovaSorgenteToolStripMenuItem.Click += new System.EventHandler(this.nuovaSorgenteToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.aggiungiSorgenteToolStripMenuItem,
            this.cancellaTuttoToolStripMenuItem1,
            this.calcolaRaggiToolStripMenuItem,
            this.listaNomiToolStripMenuItem,
            this.calcolaRaggitestToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
			this.toolStripMenuItem1.Text = "Ambiente";
			// 
			// aggiungiToolStripMenuItem
			// 
			this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
			this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.aggiungiToolStripMenuItem.Text = "Aggiungi lente";
			this.aggiungiToolStripMenuItem.Click += new System.EventHandler(this.aggiungiToolStripMenuItem_Click);
			// 
			// aggiungiSorgenteToolStripMenuItem
			// 
			this.aggiungiSorgenteToolStripMenuItem.Name = "aggiungiSorgenteToolStripMenuItem";
			this.aggiungiSorgenteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.aggiungiSorgenteToolStripMenuItem.Text = "Aggiungi sorgente";
			this.aggiungiSorgenteToolStripMenuItem.Click += new System.EventHandler(this.aggiungiSorgenteToolStripMenuItem_Click);
			// 
			// cancellaTuttoToolStripMenuItem1
			// 
			this.cancellaTuttoToolStripMenuItem1.Name = "cancellaTuttoToolStripMenuItem1";
			this.cancellaTuttoToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
			this.cancellaTuttoToolStripMenuItem1.Text = "Cancella tutto";
			this.cancellaTuttoToolStripMenuItem1.Click += new System.EventHandler(this.cancellaTuttoToolStripMenuItem1_Click);
			// 
			// calcolaRaggiToolStripMenuItem
			// 
			this.calcolaRaggiToolStripMenuItem.Name = "calcolaRaggiToolStripMenuItem";
			this.calcolaRaggiToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.calcolaRaggiToolStripMenuItem.Text = "Calcola raggio";
			this.calcolaRaggiToolStripMenuItem.Click += new System.EventHandler(this.calcolaRaggiToolStripMenuItem_Click);
			// 
			// listaNomiToolStripMenuItem
			// 
			this.listaNomiToolStripMenuItem.Name = "listaNomiToolStripMenuItem";
			this.listaNomiToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.listaNomiToolStripMenuItem.Text = "Lista nomi";
			this.listaNomiToolStripMenuItem.Click += new System.EventHandler(this.listaNomiToolStripMenuItem_Click);
			// 
			// calcolaRaggitestToolStripMenuItem
			// 
			this.calcolaRaggitestToolStripMenuItem.Name = "calcolaRaggitestToolStripMenuItem";
			this.calcolaRaggitestToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.calcolaRaggitestToolStripMenuItem.Text = "Calcola raggi (test)";
			this.calcolaRaggitestToolStripMenuItem.Click += new System.EventHandler(this.calcolaRaggitestToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitZoomToolStripMenuItem,
            this.scaleModeToolStripMenuItem,
            this.singoloToolStripMenuItem,
            this.completoToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// fitZoomToolStripMenuItem
			// 
			this.fitZoomToolStripMenuItem.Name = "fitZoomToolStripMenuItem";
			this.fitZoomToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.fitZoomToolStripMenuItem.Text = "Fit zoom";
			this.fitZoomToolStripMenuItem.Click += new System.EventHandler(this.fitZoomToolStripMenuItem_Click);
			// 
			// scaleModeToolStripMenuItem
			// 
			this.scaleModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isotropicoToolStripMenuItem,
            this.anisotropicoToolStripMenuItem});
			this.scaleModeToolStripMenuItem.Name = "scaleModeToolStripMenuItem";
			this.scaleModeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.scaleModeToolStripMenuItem.Text = "Scale mode";
			// 
			// isotropicoToolStripMenuItem
			// 
			this.isotropicoToolStripMenuItem.Name = "isotropicoToolStripMenuItem";
			this.isotropicoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.isotropicoToolStripMenuItem.Text = "Isotropico";
			this.isotropicoToolStripMenuItem.Click += new System.EventHandler(this.isotropicoToolStripMenuItem_Click);
			// 
			// anisotropicoToolStripMenuItem
			// 
			this.anisotropicoToolStripMenuItem.Enabled = false;
			this.anisotropicoToolStripMenuItem.Name = "anisotropicoToolStripMenuItem";
			this.anisotropicoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.anisotropicoToolStripMenuItem.Text = "Anisotropico";
			this.anisotropicoToolStripMenuItem.Click += new System.EventHandler(this.anisotropicoToolStripMenuItem_Click);
			// 
			// singoloToolStripMenuItem
			// 
			this.singoloToolStripMenuItem.Name = "singoloToolStripMenuItem";
			this.singoloToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.singoloToolStripMenuItem.Text = "Singolo";
			this.singoloToolStripMenuItem.Click += new System.EventHandler(this.singoloToolStripMenuItem_Click);
			// 
			// completoToolStripMenuItem
			// 
			this.completoToolStripMenuItem.Name = "completoToolStripMenuItem";
			this.completoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.completoToolStripMenuItem.Text = "Completo";
			this.completoToolStripMenuItem.Click += new System.EventHandler(this.completoToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// tESTToolStripMenuItem
			// 
			this.tESTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.test3ToolStripMenuItem,
            this.test4ToolStripMenuItem,
            this.test5ToolStripMenuItem,
            this.test6RaggiToolStripMenuItem,
            this.test7TrasfoToolStripMenuItem,
            this.test8RifrazioneToolStripMenuItem,
            this.test9MatOtticiToolStripMenuItem});
			this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
			this.tESTToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.tESTToolStripMenuItem.Text = "TEST";
			// 
			// test1ToolStripMenuItem
			// 
			this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
			this.test1ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test1ToolStripMenuItem.Text = "Test1: geometria";
			this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
			// 
			// test2ToolStripMenuItem
			// 
			this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
			this.test2ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test2ToolStripMenuItem.Text = "Test2: rifrazione e riflessione";
			this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
			// 
			// test3ToolStripMenuItem
			// 
			this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
			this.test3ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test3ToolStripMenuItem.Text = "Test3: corpo ottico";
			this.test3ToolStripMenuItem.Click += new System.EventHandler(this.test3ToolStripMenuItem_Click);
			// 
			// test4ToolStripMenuItem
			// 
			this.test4ToolStripMenuItem.Name = "test4ToolStripMenuItem";
			this.test4ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test4ToolStripMenuItem.Text = "Test4: intersezioni corpo ottico";
			this.test4ToolStripMenuItem.Click += new System.EventHandler(this.test4ToolStripMenuItem_Click);
			// 
			// test5ToolStripMenuItem
			// 
			this.test5ToolStripMenuItem.Name = "test5ToolStripMenuItem";
			this.test5ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test5ToolStripMenuItem.Text = "Test5: raggio";
			this.test5ToolStripMenuItem.Click += new System.EventHandler(this.test5ToolStripMenuItem_Click);
			// 
			// test6RaggiToolStripMenuItem
			// 
			this.test6RaggiToolStripMenuItem.Name = "test6RaggiToolStripMenuItem";
			this.test6RaggiToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test6RaggiToolStripMenuItem.Text = "Test6: raggi";
			this.test6RaggiToolStripMenuItem.Click += new System.EventHandler(this.test6RaggiToolStripMenuItem_Click);
			// 
			// test7TrasfoToolStripMenuItem
			// 
			this.test7TrasfoToolStripMenuItem.Name = "test7TrasfoToolStripMenuItem";
			this.test7TrasfoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test7TrasfoToolStripMenuItem.Text = "Test7: trasfo";
			this.test7TrasfoToolStripMenuItem.Click += new System.EventHandler(this.test7TrasfoToolStripMenuItem_Click);
			// 
			// test8RifrazioneToolStripMenuItem
			// 
			this.test8RifrazioneToolStripMenuItem.Name = "test8RifrazioneToolStripMenuItem";
			this.test8RifrazioneToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test8RifrazioneToolStripMenuItem.Text = "Test8: rifrazione";
			this.test8RifrazioneToolStripMenuItem.Click += new System.EventHandler(this.test8RifrazioneToolStripMenuItem_Click);
			// 
			// test9MatOtticiToolStripMenuItem
			// 
			this.test9MatOtticiToolStripMenuItem.Name = "test9MatOtticiToolStripMenuItem";
			this.test9MatOtticiToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.test9MatOtticiToolStripMenuItem.Text = "Test9: mat ottici";
			this.test9MatOtticiToolStripMenuItem.Click += new System.EventHandler(this.test9MatOtticiToolStripMenuItem_Click);
			// 
			// openDialog
			// 
			this.openDialog.FileName = "openFileDialog1";
			// 
			// gradiprimi
			// 
			this.gradiprimi.Location = new System.Drawing.Point(64, 27);
			this.gradiprimi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.gradiprimi.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.gradiprimi.Name = "gradiprimi";
			this.gradiprimi.Size = new System.Drawing.Size(101, 20);
			this.gradiprimi.TabIndex = 0;
			this.gradiprimi.TabStop = false;
			this.gradiprimi.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "gradi primi";
			// 
			// percdiam
			// 
			this.percdiam.Location = new System.Drawing.Point(64, 53);
			this.percdiam.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.percdiam.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.percdiam.Name = "percdiam";
			this.percdiam.Size = new System.Drawing.Size(101, 20);
			this.percdiam.TabIndex = 3;
			this.percdiam.TabStop = false;
			this.percdiam.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.percdiam.ValueChanged += new System.EventHandler(this.percdiam_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "% diametro";
			// 
			// Lente01
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 664);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.percdiam);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gradiprimi);
			this.Controls.Add(this.barraMenu);
			this.MainMenuStrip = this.barraMenu;
			this.Name = "Lente01";
			this.Text = "Lente";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Lente01_Load);
			this.ResizeEnd += new System.EventHandler(this.Lente01_ResizeEnd);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Lente01_Paint);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lente01_KeyPress);
			this.barraMenu.ResumeLayout(false);
			this.barraMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradiprimi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.percdiam)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

			


		private System.Windows.Forms.MenuStrip barraMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificaLenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuovaLenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openDialog;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fitZoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test5ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scaleModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem isotropicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anisotropicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aggiungiLenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancellaTuttoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aggiungiRaggiECalcolaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test6RaggiToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown gradiprimi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown percdiam;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem test7TrasfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem singoloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem completoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancellaTuttoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem calcolaRaggiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test8RifrazioneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test9MatOtticiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sorgenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificaSorgenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuovaSorgenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aggiungiSorgenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listaNomiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calcolaRaggitestToolStripMenuItem;
		}
	}

