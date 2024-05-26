using System;

public class PersonalInfo
{
    public static void Main(string[] args)
    {
        // Person's information
        string name = "Lucinda Potter";
        string birthdate = "6/24/1992";
        string workPhone = "000-000-0101";
        string cellPhone = "000-000-0189";

        // Displaying the information
        Console.WriteLine(name);
        Console.WriteLine(birthdate);
        Console.WriteLine("work " + workPhone);
        Console.WriteLine("cell " + cellPhone);
    }
}
