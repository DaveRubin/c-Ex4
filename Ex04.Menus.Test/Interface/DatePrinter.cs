namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;
    public class DatePrinter : IDoable
    {
        public void Do()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("dd-mm-yyyy"));
            Console.ReadLine();
        }
    }
}