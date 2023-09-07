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
    public abstract string CheckFluffiness();
} 