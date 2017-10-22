using System;

class DateModifier
{
    public static double GetDifference(string firstDateToString, string secondDateToString)
    {
        DateTime firstDate = DateTime.ParseExact(firstDateToString, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondDateToString, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

        var result = Math.Abs((firstDate - secondDate).TotalDays);
        return result;
    }
}
