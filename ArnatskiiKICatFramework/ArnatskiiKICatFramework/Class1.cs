namespace ArnatskiiKICatFramework;

public class CatException : ArgumentException
{
    public CatException(string message) : base(message) {}
}
public abstract class Cat
{
    public abstract int Fluffiness
    {
        get;
    }

    public abstract string FluffinessCheck();
    public abstract string CheckFluffiness();
    public override string ToString()
    {
        return $"A cat with fluffiness: {this.Fluffiness}";
    }
    
} 