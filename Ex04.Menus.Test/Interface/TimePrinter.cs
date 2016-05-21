namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;
    public class TimePrinter :  IDoable
    {

        public void Do()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("h:hh:ss tt"));
            Console.ReadLine();
        } 
    }
}