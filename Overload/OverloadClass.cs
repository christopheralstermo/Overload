namespace Overload;

public class OverloadClass
{
    public void Greetings(string inputten = "du er helt ålreit...")
    {
        Console.WriteLine($"Ikke bare eru grei, {inputten}");
    }    
    public void Greetings(string inputten, string inputten2)
    {
        Console.WriteLine($"Ikke bare eru grei, {inputten} og {inputten2}");
    }
    public void Greetings(string inputten, string inputten2, string inputten3)
    {
        Console.WriteLine($"Ikke bare eru grei, {inputten} og {inputten2} og enda en {inputten3}");
    }
}