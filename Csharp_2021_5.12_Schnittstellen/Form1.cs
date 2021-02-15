using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_5._12_Schnittstellen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Ein Objekt vom Typ Fahrzeug erstellen
			Fahrzeug meinFahrzeug = new Fahrzeug();
			meinFahrzeug.Beschleunigen(10);
			Console.WriteLine(meinFahrzeug);

			// Objekt "meinFahrzeug" kopieren
			// - Methode Clone() wird auf "meinFahrzeug" angewandt => "meinFahrzeug" wird kopiert
			// - (Fahrzeug) : Das ist ein Cast (eine Umwandlung). Clone() liefert als Rückgabe
			//                object => Das muss noch explizit in den Datentyp "Fahrzeug" umgewandelt 
			//							  werden
			// - Diese neu erzeugte Kopie wird der Variablen "meinZweitesFahrzeug" zugewiesen
			Fahrzeug meinZweitesFahrzeug = (Fahrzeug)meinFahrzeug.Clone();

			// Nach der Kopie
			Console.WriteLine("Nach der Kopie:");
			Console.WriteLine("Erstes Fahrzeug: " + meinFahrzeug);
			Console.WriteLine("Kopiertes Fahrzeug: " + meinZweitesFahrzeug);

			// Beide Fahrzeuge beschleunigen
			meinFahrzeug.Beschleunigen(10);
			meinZweitesFahrzeug.Beschleunigen(50);
			Console.WriteLine("Nach dem Beschleunigen");
			Console.WriteLine("Erstes Fahrzeug: " + meinFahrzeug);
			Console.WriteLine("Kopiertes Fahrzeug: " + meinZweitesFahrzeug);
		}
	}
}
