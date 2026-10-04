using System;

namespace VECKA3övningar_Logik
{
    // Klassen BankAccount representerar ett bankkonto
    class BankAccount
    {
        // Kontots saldo börjar på 0 kronor
        public double Balance = 0;

        // Metoden Deposit används för att sätta in pengar
        public void Deposit(double amount)
        {
            // Lägger det insatta beloppet till saldot
            Balance = Balance + amount;
        }

        // Metoden Withdraw används för att ta ut pengar
        public void Withdraw(double amount)
        {
            // Kontrollerar att det finns tillräckligt med pengar
            if (amount <= Balance)
            {
                // Tar bort beloppet från saldot
                Balance = Balance - amount;
            }
            else
            {
                // Visar felmeddelande om uttaget är för stort
                Console.WriteLine("Du kan inte ta ut mer pengar än saldot.");
            }
        }

        // Visar det aktuella saldot
        public void ShowBalance()
        {
            Console.WriteLine("Ditt saldo är: " + Balance + " kr");
        }
    }
}
