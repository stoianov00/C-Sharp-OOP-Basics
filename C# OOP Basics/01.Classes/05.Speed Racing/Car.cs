using System;
class Car
{
    public string model;
    public double fuelAmmount;
    public double fuelCost;
    public double distanceTravelled;

    public Car(string model, double fuelAmmount, double fuelCost)
    {
        this.model = model;
        this.fuelAmmount = fuelAmmount;
        this.fuelCost = fuelCost;
        this.distanceTravelled = 0;
    }

    public void Calculate(double distance)
    {
        if (this.fuelAmmount < distance * this.fuelCost)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.fuelAmmount -= distance * this.fuelCost;
            this.distanceTravelled += distance;
        }
    }
	

}

