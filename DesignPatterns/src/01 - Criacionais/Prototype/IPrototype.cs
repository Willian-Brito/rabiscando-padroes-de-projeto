namespace DesignPatterns.Criacionais.Prototype;

public interface IPrototype
{
    public IPrototype Clone();
    public string ToString();
}