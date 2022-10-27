namespace OOPractice
{
    using System;
    public class Car
    {
        public string Name;
        public int Speed;

        public Car(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string SpeedUp()
        {
            return $"{Name}: speed up {Speed} km/h";
        }
    }
}
