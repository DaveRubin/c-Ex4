namespace Ex04.Menus.Interfaces
{
    using System;

    public class Doable2 : IDoable
    {
        public void Do()
        {
            Console.WriteLine("Doing Doable2");
            Console.ReadLine();
        }
    }
}