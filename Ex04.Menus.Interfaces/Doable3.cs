namespace Ex04.Menus.Interfaces
{
    using System;

    public class Doable3 : IDoable
    {
        public void Do()
        {
            Console.WriteLine("Doing Doable3");
            Console.ReadLine();
        }
    }
}