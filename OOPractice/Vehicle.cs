namespace OOPractice;

public class Vehicle
{
    public string Name;
    public int Speed;

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public virtual string SpeedUp()
    {
        return $"{Name}: speed up {Speed} km/h";
    }
}