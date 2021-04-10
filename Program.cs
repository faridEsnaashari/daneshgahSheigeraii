using System;

namespace gameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            // Movable objectes
            Enemy soldier1 = new Enemy();
            Enemy soldier2 = new Enemy();

            MovableLaser laser1 = new MovableLaser();

            // Movable objectes
            UnMovableLaser laser2 = new UnMovableLaser();

            Trap trap1 = new Trap();
            Trap trap2 = new Trap();
        }
    }
}
