using VECKA3övningar_Logik;

// Skapar ett konto
Account account = new Account();

// Bestämmer om programmet ska fortsätta
bool running = true;

// Loopen fortsätter tills användaren väljer 3
while (running)
{
    // Visar huvudmenyn
    Console.WriteLine();
    Console.WriteLine("===== HUVUDMENY =====");
    Console.WriteLine("1. Registrera");
    Console.WriteLine("2. Logga in");
    Console.WriteLine("3. Avsluta");
    Console.Write("Välj ett alternativ: ");

    // Läser in användarens val
    string choice = Console.ReadLine() ?? "";

    // Kontrollerar vilket alternativ användaren valde
    switch (choice)
    {
        case "1":
            // Användaren väljer registrering
            Console.Write("Ange användarnamn: ");
            string username = Console.ReadLine() ?? "";

            Console.Write("Ange lösenord: ");
            string password = Console.ReadLine() ?? "";

            // Försöker registrera användaren
            bool registered = account.Register(username, password);

            if (registered)
            {
                Console.WriteLine("Registrering lyckades!");
            }
            else
            {
                Console.WriteLine("Lösenordet uppfyller inte kraven.");
                Console.WriteLine("Lösenordet måste ha minst 6 tecken,");
                Console.WriteLine("minst 1 siffra, 1 stor bokstav");
                Console.WriteLine("och 1 specialtecken.");
            }

            break;

        case "2":
            // Användaren väljer inloggning
            Console.Write("Ange användarnamn: ");
            string loginUsername = Console.ReadLine() ?? "";

            Console.Write("Ange lösenord: ");
            string loginPassword = Console.ReadLine() ?? "";

            // Kontrollerar om uppgifterna stämmer
            bool loggedIn = account.Login(loginUsername, loginPassword);

            if (loggedIn)
            {
                Console.WriteLine("Inloggning lyckades!");
            }
            else
            {
                Console.WriteLine("Felaktiga uppgifter.");
            }

            break;

        case "3":
            // Avslutar programmet
            Console.WriteLine("Programmet avslutas.");
            running = false;
            break;

        default:
            // Om användaren skriver något annat än 1, 2 eller 3
            Console.WriteLine("Ogiltigt val.");
            break;
    }
}
