using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster master = new SoulMaster("Loki", 65);
            Console.WriteLine(master);
        }
    }
}