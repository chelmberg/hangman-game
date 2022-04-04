using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
	class Hangman
	{
		string suchwort;		// gesuchtes Wort
		string getippt="";			// bereits getippte Buchstaben
		int maximaleVersuche;	// Anzahl maximale Versuche
		int versuche = 0;			// Anzahl bereits getätigter Versuche

		/// <summary>
		/// Erstellt ein neues Hangman-Objekt
		/// </summary>
		/// <param name="_suchwort">gesuchtes Wort</param>
		/// <param name="_maxVersuche">Anzahl maximaler Versuche</param>
		public Hangman(string _suchwort, int _maxVersuche)
		{
			suchwort = _suchwort.ToUpper();
			maximaleVersuche = _maxVersuche;
		}

		/// <summary>
		/// Fügt einen getippten Buchstaben zu der Liste der bereits
		/// getippten Buchstaben dazu (Parameter Buchstabe hat Datentyp char)
		/// </summary>
		/// <param name="ch">getippter Buchstabe (Eingabeparameter)</param>
		/// <param name="bereits_getippt">true ... wenn Buchstabe bereits getippt
		/// wurde (Ausgabeparamter)</param>
		/// <returns>true ... wenn getippter Buchstabe im Suchwort vorkommt</returns>
		public bool NeuerVersuch(char ch, out bool bereits_getippt)
		{
			bool ok = false;
			bereits_getippt = false;
			ch = char.ToUpper(ch);

			versuche++;

			if (!MaxAnzahlErreicht)
			{

				if (getippt.Contains(ch))
				{
					bereits_getippt = true;
				}
				else
				{
					getippt = getippt.Insert(0, ch.ToString());
					if (suchwort.Contains(ch))
					{
						ok = true;
					}
				}
			}
			
			return ok;
		}

		/// <summary>
		/// Liefert das Suchwort wobei die bereits getippten Buchstaben im Wort
		/// aufgedeckt werden und die noch nicht getippten mit "*" gekennzeichnet 
		/// werden.
		/// </summary>
		/// <param name="wort">verschlüsselter Suchbegriff
		/// (Ausgabeparameter)</param>
		/// <returns>true ... wenn alle Buchstaben des Suchwortes aufgedeckt
		/// sind, d.h. Wort wurde richtig erraten</returns>
		public bool SuchbegriffVerschluesselt(out string wort)
		{
			bool erraten = true;
			wort = suchwort;

			foreach (char buchstabe in wort.ToUpper())
			{
				if (!getippt.Contains(buchstabe))
				{
					wort = wort.Replace(buchstabe, '*');
					erraten = false;
				}
			}

			return erraten;
		}

		// Eigenschaften
		public string Getippt
		{
			get
			{
				return getippt;
			}
		}
		public int Versuche
		{
			get
			{
				return versuche;
			}
		}
		public bool MaxAnzahlErreicht
		{
			get
			{
				if (versuche >= maximaleVersuche)
					return true;
				else
					return false;
			}
		}
	}
}
