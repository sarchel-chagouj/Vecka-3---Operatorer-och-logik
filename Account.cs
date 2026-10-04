
namespace VECKA3övningar_Logik
{
    // Klassen Account representerar ett användarkonto
    class Account
    {
        // Användarens användarnamn
        public string Username = "";

        // Användarens lösenord
        public string Password = "";

        // Registrerar ett nytt konto
        public bool Register(string username, string password)
        {
            // Kontrollerar om lösenordet uppfyller kraven
            if (CheckPasswordStrength(password))
            {
                // Sparar användarnamnet
                Username = username;

                // Sparar lösenordet
                Password = password;

                // Registreringen lyckades
                return true;
            }

            // Registreringen misslyckades
            return false;
        }

        // Kontrollerar om användaren har skrivit rätt uppgifter
        public bool Login(string username, string password)
        {
            // Jämför användarnamn OCH lösenord
            if (Username == username && Password == password)
            {
                // Uppgifterna stämmer
                return true;
            }

            // Uppgifterna stämmer inte
            return false;
        }

        // Kontrollerar om lösenordet är tillräckligt starkt
        public bool CheckPasswordStrength(string password)
        {
            // Lösenordet måste innehålla minst 6 tecken
            if (password.Length < 6)
            {
                return false;
            }

            // Dessa variabler håller reda på
            // vilka krav lösenordet uppfyller
            bool hasNumber = false;
            bool hasUppercase = false;
            bool hasSpecialCharacter = false;

            // Går igenom varje tecken i lösenordet
            foreach (char character in password)
            {
                // Kontrollerar om tecknet är en siffra
                if (char.IsDigit(character))
                {
                    hasNumber = true;
                }

                // Kontrollerar om tecknet är en stor bokstav
                if (char.IsUpper(character))
                {
                    hasUppercase = true;
                }

                // Kontrollerar om tecknet är ett specialtecken
                if (!char.IsLetterOrDigit(character))
                {
                    hasSpecialCharacter = true;
                }
            }

            // Alla tre krav måste vara uppfyllda
            if (hasNumber && hasUppercase && hasSpecialCharacter)
            {
                return true;
            }

            // Om något krav saknas
            return false;
        }
    }
}
