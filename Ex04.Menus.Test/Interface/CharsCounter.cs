namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;
    public class CharsCounter : CharActionClassBase, IDoable
    {
        private string k_CharsCountMessageTemplate = @"The inserted string have {0} chars in it
Press 'Enter' to continue";

        public void Do()
        {
            Console.Clear();
            string userInput = GetStringFromUser();
            Console.WriteLine(k_CharsCountMessageTemplate, userInput.Length);
            Console.ReadLine();
        }
    }
}