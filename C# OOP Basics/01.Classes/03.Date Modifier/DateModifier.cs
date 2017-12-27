using System;
class DateModifier
{
    public double CalculateDays(DateTime firstDate, DateTime secondDate)
    {
        double differenceBetWeenTotalDays = firstDate.Subtract(secondDate).TotalDays;
        return (Math.Abs(differenceBetWeenTotalDays));
    }

}

