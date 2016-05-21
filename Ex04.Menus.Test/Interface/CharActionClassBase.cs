namespace Ex04.Menus.Test.Interface
{
    using System;

    public class CharActionClassBase
    {
        private string k_PleaseEnterStringMessage = "Please enter a string: ";

        protected string GetStringFromUser()
        {
            Console.WriteLine(k_PleaseEnterStringMessage);
            return Console.ReadLine();
        }
    }
}