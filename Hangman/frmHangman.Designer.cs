namespace Hangman
{
	partial class frmHangman
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnHangman = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblMax = new System.Windows.Forms.Label();
			this.txtVersuche = new System.Windows.Forms.TextBox();
			this.txtTipp = new System.Windows.Forms.TextBox();
			this.lblTipp = new System.Windows.Forms.Label();
			this.btnTipp = new System.Windows.Forms.Button();
			this.txtGetippt = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.txtAnzahlVersuche = new System.Windows.Forms.TextBox();
			this.txtMaxErreicht = new System.Windows.Forms.TextBox();
			this.lblGetippt = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.lblAnzahlVersuche = new System.Windows.Forms.Label();
			this.lblMaxErreicht = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnHangman
			// 
			this.btnHangman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHangman.Location = new System.Drawing.Point(325, 134);
			this.btnHangman.Name = "btnHangman";
			this.btnHangman.Size = new System.Drawing.Size(281, 42);
			this.btnHangman.TabIndex = 0;
			this.btnHangman.Text = "Hangmanobjekt erstellen";
			this.btnHangman.UseVisualStyleBackColor = true;
			this.btnHangman.Click += new System.EventHandler(this.btnHangman_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(325, 70);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(223, 26);
			this.txtSearch.TabIndex = 1;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(239, 73);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(80, 20);
			this.lblSearch.TabIndex = 2;
			this.lblSearch.Text = "Suchwort:";
			// 
			// lblMax
			// 
			this.lblMax.AutoSize = true;
			this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMax.Location = new System.Drawing.Point(148, 105);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(171, 20);
			this.lblMax.TabIndex = 3;
			this.lblMax.Text = "max. Anzahl Versuche:";
			// 
			// txtVersuche
			// 
			this.txtVersuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVersuche.Location = new System.Drawing.Point(325, 102);
			this.txtVersuche.Name = "txtVersuche";
			this.txtVersuche.Size = new System.Drawing.Size(98, 26);
			this.txtVersuche.TabIndex = 4;
			// 
			// txtTipp
			// 
			this.txtTipp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipp.Location = new System.Drawing.Point(325, 239);
			this.txtTipp.Name = "txtTipp";
			this.txtTipp.Size = new System.Drawing.Size(98, 26);
			this.txtTipp.TabIndex = 5;
			// 
			// lblTipp
			// 
			this.lblTipp.AutoSize = true;
			this.lblTipp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipp.Location = new System.Drawing.Point(209, 242);
			this.lblTipp.Name = "lblTipp";
			this.lblTipp.Size = new System.Drawing.Size(110, 20);
			this.lblTipp.TabIndex = 6;
			this.lblTipp.Text = "Tipp abgeben:";
			// 
			// btnTipp
			// 
			this.btnTipp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTipp.Location = new System.Drawing.Point(429, 223);
			this.btnTipp.Name = "btnTipp";
			this.btnTipp.Size = new System.Drawing.Size(119, 42);
			this.btnTipp.TabIndex = 7;
			this.btnTipp.Text = "Tippen!";
			this.btnTipp.UseVisualStyleBackColor = true;
			this.btnTipp.Click += new System.EventHandler(this.btnTipp_Click);
			// 
			// txtGetippt
			// 
			this.txtGetippt.Enabled = false;
			this.txtGetippt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGetippt.Location = new System.Drawing.Point(325, 271);
			this.txtGetippt.Name = "txtGetippt";
			this.txtGetippt.Size = new System.Drawing.Size(370, 26);
			this.txtGetippt.TabIndex = 8;
			// 
			// txtCode
			// 
			this.txtCode.Enabled = false;
			this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCode.Location = new System.Drawing.Point(325, 303);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(223, 26);
			this.txtCode.TabIndex = 9;
			// 
			// txtAnzahlVersuche
			// 
			this.txtAnzahlVersuche.Enabled = false;
			this.txtAnzahlVersuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnzahlVersuche.Location = new System.Drawing.Point(325, 335);
			this.txtAnzahlVersuche.Name = "txtAnzahlVersuche";
			this.txtAnzahlVersuche.Size = new System.Drawing.Size(223, 26);
			this.txtAnzahlVersuche.TabIndex = 10;
			// 
			// txtMaxErreicht
			// 
			this.txtMaxErreicht.Enabled = false;
			this.txtMaxErreicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaxErreicht.Location = new System.Drawing.Point(325, 367);
			this.txtMaxErreicht.Name = "txtMaxErreicht";
			this.txtMaxErreicht.Size = new System.Drawing.Size(98, 26);
			this.txtMaxErreicht.TabIndex = 11;
			// 
			// lblGetippt
			// 
			this.lblGetippt.AutoSize = true;
			this.lblGetippt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGetippt.Location = new System.Drawing.Point(205, 274);
			this.lblGetippt.Name = "lblGetippt";
			this.lblGetippt.Size = new System.Drawing.Size(114, 20);
			this.lblGetippt.TabIndex = 12;
			this.lblGetippt.Text = "bereits getippt:";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCode.Location = new System.Drawing.Point(158, 306);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(161, 20);
			this.lblCode.TabIndex = 13;
			this.lblCode.Text = "codierter Suchbegriff:";
			// 
			// lblAnzahlVersuche
			// 
			this.lblAnzahlVersuche.AutoSize = true;
			this.lblAnzahlVersuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnzahlVersuche.Location = new System.Drawing.Point(185, 338);
			this.lblAnzahlVersuche.Name = "lblAnzahlVersuche";
			this.lblAnzahlVersuche.Size = new System.Drawing.Size(134, 20);
			this.lblAnzahlVersuche.TabIndex = 14;
			this.lblAnzahlVersuche.Text = "Anzahl Versuche:";
			// 
			// lblMaxErreicht
			// 
			this.lblMaxErreicht.AutoSize = true;
			this.lblMaxErreicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaxErreicht.Location = new System.Drawing.Point(143, 370);
			this.lblMaxErreicht.Name = "lblMaxErreicht";
			this.lblMaxErreicht.Size = new System.Drawing.Size(176, 20);
			this.lblMaxErreicht.TabIndex = 15;
			this.lblMaxErreicht.Text = "max. Versuche getätigt:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 564);
			this.Controls.Add(this.lblMaxErreicht);
			this.Controls.Add(this.lblAnzahlVersuche);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.lblGetippt);
			this.Controls.Add(this.txtMaxErreicht);
			this.Controls.Add(this.txtAnzahlVersuche);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.txtGetippt);
			this.Controls.Add(this.btnTipp);
			this.Controls.Add(this.lblTipp);
			this.Controls.Add(this.txtTipp);
			this.Controls.Add(this.txtVersuche);
			this.Controls.Add(this.lblMax);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnHangman);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHangman;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblMax;
		private System.Windows.Forms.TextBox txtVersuche;
		private System.Windows.Forms.TextBox txtTipp;
		private System.Windows.Forms.Label lblTipp;
		private System.Windows.Forms.Button btnTipp;
		private System.Windows.Forms.TextBox txtGetippt;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.TextBox txtAnzahlVersuche;
		private System.Windows.Forms.TextBox txtMaxErreicht;
		private System.Windows.Forms.Label lblGetippt;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Label lblAnzahlVersuche;
		private System.Windows.Forms.Label lblMaxErreicht;
	}
}

