using System;

public class Kaffee
{
	public double Wasser { get; private set; }
	public double Bohnen { get; private set; }
	public double gesamtMengeKaffeeProduziert { get; private set; }

    private static double maxWasser()
    {
        maxWasser = 2.5;
    }

    private static double maxBohnen()
	{
		maxBohnen = 2.5;
	}


	public Kaffee(double wasser, double bohnen, double gesamtMengeKaffeProduiert)
    {
		Wasser = wasser;
		Bohnen = bohnen;
		gesamtMengeKaffeeProduziert = gesamtMengeKaffeProduiert;
    }

	public double WasserAuffuellen(double menge)
    {
		wasser = (wasser + menge) > maxWasser;
		return Wasser;
    }
	public double BohnenAuffuellen(double menge)
    {
		bohnen = (bohnen + menge) > maxBohnen;
			return bohnen;
    }

	public class 
    {
		
    }
}
