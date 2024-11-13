// () = etw. konfigurieren oder eine Wert zu etwas zuweisen
// {} = immer wenn ein Codeblock ausgeführt werden soll
// [] = immer wenn man eine Auflistung von Elementen haben möchte

using System;

//Namespace -> Name von unserem Programm
namespace Goofy
{
    //internal = Zugriffsebene, Was wir machen wollen = class, Name = Programm
    //Intitialisierung der Klasse
    internal class Programm
    {
        //Methode initialisiert
        static void Main(string[] args)
        {
            //Ausführbare Code
            
            //Variableninitialisierung
            string input = "Hallo";
            string unsereCooleZahl = "null";
            int zahlInt = 0;
            
            //Ausgabe mit Variable
            Console.WriteLine(input);
            //Ausgabe mit manuellem Text
            Console.WriteLine("Hallo Welt");
            //Ausgabe mit manuellem Text und Variablen
            Console.WriteLine($"Unsere Ausgabe: {input}");
            
            //For-Schleifen, bzw. Zählschleifen
            int Zähler = 2; //Wie oft soll die Schleife ausgeführt werden
            //i = aktueller Zählerstand
            //i++ entspricht i = i + 1
            for (int i = 0; i < Zähler; i++)
            {
                Console.WriteLine($"Aktueller Run: {i}");
            }
            
            //Neue Variable vom Typ Mensch mit Name Schüler1 --> nach Gleichzeichen wird das Objekt erstellt
            // Mensch Schüler1 = new Mensch();
            // Schüler1.Name = "Adrian";
            // Schüler1.Age = 12;
            //
            // Mensch Schüler2 = new Mensch();
            // Schüler2.Name = "Joost";
            // Schüler2.Age = 40;
            //
            // Console.WriteLine($"{Schüler1.Name} --> Alter: {Schüler1.Age}");
            // Console.WriteLine($"{Schüler2.Name} --> Alter: {Schüler2.Age}");
            
            //Liste -> List<> und in <> den Typ vom Element das in die Liste soll, z.B. string/int/Klassenname
            // new List<> um Liste wirklich zu erstellen
            List<Mensch> schüler = new List<Mensch>();
            List<string> namen = ["Adrian", "Luca", "Joost", "David"];
            for (int i = 0; i < namen.Count; i++)
            {
                //Neues Objekt vom Typ Mensch zur Liste Schüler hinzufügen --> Neues Element erstellen --> in geschweiften Klammern Variablen Name = Wert,
                //den wir zu zu diesem neuen Objekt zuweisen wollen. In diesem Fall nehmen wir das i'te Element aus der Liste namen und geben anschließend
                //das Element aus der neuen Liste Schüler aus. Beispiel:
                //i = 0
                //In der Liste Schüler wird an der Position 0, weil noch keine Elemte in der Liste sind und in der Informatik man bei 0 anfängt zu zählen, 
                //ein neuer Schüler hinzugefügt und der Name wird aus der jeweiligen Stelle, definiert durch i, in der Liste namen genommen. Anschließend
                //wird das neue Element ausgegeben aus der Liste schüler.
                
                Random zufall = new Random();
                //Erste Zahl, die enthalten sein soll (12) und erste Zahl, die nicht mehr enthalten soll (16) ==> Zufallszahl zwischen 12 und 15
                int unsererZufall = zufall.Next(12, 16);

                Console.Clear();
                Console.WriteLine("Gib dein Namen ein:");
                //Eingabe in der Konsole wird ausgelesen
                string name = Console.ReadLine(); 
                
                //Wir brauchen hier eine Liste, um die neuen Elemente zu speichern
                schüler.Add(new Mensch{Name = name, Age = unsererZufall});
                // Console.WriteLine($"Schüler: {schüler[i].Name}, Alter: {schüler[i].Age}");
            }
            
            //Integer = ganze Zahl --> Wenn man zwei integer teilt, dann kommt trotzdem ein Integer, also eine ganze Zahl aus.
            //Beispiel: 1(integer) / 2(integer) = 0 (integer)
            //Beispiel: 1f(floating point number) / 2f(floating point number) = 0,5(floating point number)
            Console.WriteLine(1f/2f);
            
            schüler.ForEach(s =>
            {
                Console.WriteLine($"Aktueller Schüler: {s.Name} {s.Age}");
            });
        }
    }

    public class Mensch
    {
        //Variablen in Vorlage definieren mit Zugriffseben(public) und Schreibberechtigungen ( {get;set;} )
        //--> Wir brauchen die Berechtigungen um Optionen offen zu halten
        
        public string Name { get; set; }
        public int Age { get; set; }
        public int Größe { get; set; }
    }
    
}