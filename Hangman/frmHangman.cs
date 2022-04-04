
using System;
using System.Windows.Forms;

namespace Hangman
{
	public partial class frmHangman : Form
	{
		public frmHangman()
		{
			InitializeComponent();
		}

		Hangman hangman;

		private void btnHangman_Click(object sender, EventArgs e)
		{
			string suchwort = txtSearch.Text;
			int anzahl = Convert.ToInt32(txtVersuche.Text);
			hangman = new Hangman(suchwort, anzahl);
			txtSearch.Clear();
			Show();
		}

		private void btnTipp_Click(object sender, EventArgs e)
		{
			try
			{
				char tipp = Convert.ToChar(txtTipp.Text);
				bool bereits_getippt;
				bool ok;

				ok = hangman.NeuerVersuch(tipp, out bereits_getippt);
				if (bereits_getippt == true)
				{
					MessageBox.Show("Der Buchstabe wurde früher schon einmal getippt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (ok == false)
				{
					MessageBox.Show("Der Buchstabe kommt im Suchwort nicht vor.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (hangman.MaxAnzahlErreicht)
				{
					MessageBox.Show("Die maximale Anzahl an Versuchen ist erreicht.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Super - ein richtiger Buchstabe", "Buchstabe erraten", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch(FormatException fex)
			{
				MessageBox.Show("Es dürfen keine 2 Buchstaben als Tipp abgegeben werden!", "Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			Show();
			
		}

		private void Show()
		{
			string wort;
			bool ok;

			ok = hangman.SuchbegriffVerschluesselt(out wort);
			txtGetippt.Text = hangman.Getippt;
			txtCode.Text = wort;
			txtAnzahlVersuche.Text = Convert.ToString(hangman.Versuche);
			txtMaxErreicht.Text = Convert.ToString(hangman.MaxAnzahlErreicht);
			if (hangman.MaxAnzahlErreicht)
			{
				MessageBox.Show("Die Maximale Anzahl an Versuchen ist erreicht worden!", "MAX Erreicht", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnTipp.Enabled = false;
			}
			if (ok)
			{
				MessageBox.Show("Super - Das Suchwort wurde gefunden! Anzahl der Versuche=" + hangman.Versuche.ToString(), "Wort gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				btnTipp.Enabled = false;

			}
		}
	}
}
