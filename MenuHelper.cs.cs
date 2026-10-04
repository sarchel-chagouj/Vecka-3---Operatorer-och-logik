using System;

namespace VECKA3övningar_Logik
{
    // Statisk klass som används för att visa bankmenyn
    static class MenuHelper
    {
        // Metoden ShowMenu visar alla alternativ för användaren
        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("===== BANKKONTO =====");
            Console.WriteLine("1. Insättning");
            Console.WriteLine("2. Uttag");
            Console.WriteLine("3. Visa saldo");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj ett alternativ: ");
        }
    }
}
