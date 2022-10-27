using System;

namespace OOPractice
{
    public class Engine
    {
        //private readonly string type;
        private readonly int speed;

        public Engine(string type)
        {
            //this.type = type;
            if (type == "Gasoline")
            {
                this.speed = 30;
            }
        }

        public int Speed => speed;
    }
}