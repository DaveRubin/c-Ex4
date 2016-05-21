namespace Ex04.Menus.Interfaces
{
    using System;

    public class Doable1 : IDoable
    {
        public void Do()
        {
            Console.WriteLine("Doing Doable1");
            Console.ReadLine();
        } 
    }
}