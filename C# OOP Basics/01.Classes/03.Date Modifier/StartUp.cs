using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        var parseFirstDate = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var parseSecondDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            
        var date = new DateModifier();
        Console.WriteLine(date.CalculateDays(parseFirstDate, parseSecondDate));
    }
}

