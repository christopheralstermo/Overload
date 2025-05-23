namespace Overload;

public class TheApp
{
    OverloadClass overloadClass = new OverloadClass();
    public void Run()
    {
        overloadClass.Greetings();
        overloadClass.Greetings("Hva skjer nå");
        overloadClass.Greetings("noe mer her?", "med");
        overloadClass.Greetings("noe mer her?", "med");
        overloadClass.Greetings("noe mer her?", "med", "en testing");
    }
}