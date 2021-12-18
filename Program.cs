using System;

namespace CelciusToFarhenheit
{
    class Program
    {/// <summary>
    /// Hier füren wir die 2 Funktione aus
    /// 1. GetInput um Start und endwert zu erfassen
    /// 2. C2F um Celcius Werte in Fahrenheit umzuwandeln
    /// Im ersten do while loop benutzen wir Getinput und wir prüfen ob Start > ende, fals ja wiederholen wir die eingabe von Start und Ende 
    /// Im Zweiten loop wandeln wir mit hilfe von C2F alle Celciuswerte (start : ende) in Fahrenheit um.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {     
            float F;
            int start;
            int ende;

            do
            {
                start = GetInput("Startwert");
                ende = GetInput("Endwert");
            }
            while (start > ende);

            while (start <= ende)
            { 
                 F = C2F(start);
                Console.WriteLine($"Cecius = {start} Farhenheit = {F}");
                start++;
            }

        }
/// <summary>
/// Die Funktion wandelt einen Celcius Wert in Fahrenheit um.
/// </summary>
/// <param name="celcius"></param>
/// <returns></returns>
        static float C2F(int celcius)

        {
            Convert.ToSingle(celcius);
            float F = ((9f * celcius + 160f) / 5f);
            return F;
        }

/// <summary>
/// Hier benutzen wir die Funktion um Start und Endwert einzugeben.
/// Die Funktion nimmt eine eingabe von der Tastatur entgegen und prüft ob der String aus Ziffern besteht. 
/// Falls ja wird der string in einen Int umgewandelt und zurückgegeben.
/// </summary>
/// <param name="message"></param>
/// <returns></returns>        
        static int GetInput(string message)
        {
            
            int value;
            string eingabe;
            do
            {
                Console.WriteLine(message);
                eingabe = Console.ReadLine();
            }
            while (int.TryParse(eingabe, out value) == false);

            value = Convert.ToInt16(eingabe);
            return value;
        }
    }
}
