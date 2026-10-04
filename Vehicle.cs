namespace VECKA3övningar_Logik
{
    class Vehicle
    {
        // Fordonets årsmodell
        public int Year;

        // Anger om fordonet har giltig försäkring
        public bool HasInsurance;

        public string CheckInspection()
        {
            // Räknar ut hur gammalt fordonet är
            int age = DateTime.Now.Year - Year;

            // Äldre än 5 år OCH saknar giltig försäkring
            if (age > 5 && HasInsurance == false)
            {
                return "Ej godkänt";
            }

            // Yngre än 5 år OCH har giltig försäkring
            else if (age < 5 && HasInsurance == true)
            {
                return "Godkänt";
            }

            // Alla andra kombinationer
            else
            {
                return "Måste kompletteras";
            }
        }
    }
}
