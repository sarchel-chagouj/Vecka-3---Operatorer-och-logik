namespace VECKA3övningar_Logik
{
    class Thermometer
    {
        // Temperaturen börjar på 0 grader
        public double Temperature = 0;

        // Kontrollerar temperaturen
        public string CheckTemperature()
        {
            // Om temperaturen är under 0
            if (Temperature < 0)
            {
                return "Det är minusgrader";
            }
            // Om temperaturen är mellan 0 och 30
            else if (Temperature <= 30)
            {
                return "Normal temperatur";
            }
            // Om temperaturen är över 30
            else
            {
                return "Varning för hög värme";
            }
        }
    }
}
