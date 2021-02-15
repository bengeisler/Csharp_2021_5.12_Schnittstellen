using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_5._12_Schnittstellen
{
	// Die Klasse Fahrzeug implementiert die Schnittstelle ICloneable
	// => Die Klasse Fahrzeug MUSS die Methode Clone() enthalten
	class Fahrzeug : ICloneable
	{
		private int geschwindigkeit;

		public void Beschleunigen(int wert) => geschwindigkeit += wert;

		// Clone() wird in der Schnittstelle ICloneable definiert
		public object Clone()
		{
			// Gibt ein neues Fahrzeug zurück, das die 
			// Eigenschaften des bestehenden Fahrzeugs besitzt

			// Neues Fahrzeug erstellen
			Fahrzeug neuesFahrzeug = new Fahrzeug();

			// Alle Eigenschaften des aktuellen Fahrzeugs übernehmen
			// this: optional
			neuesFahrzeug.geschwindigkeit = this.geschwindigkeit;

			// Neues Fahrzeug zurückgeben
			return neuesFahrzeug;
		}

		public override string ToString()
		{
			return "Geschwindigkeit: " + geschwindigkeit + "\n";	
		}
	}
}
