namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;

    public class CharsCounter : CharActionClassBase, IDoable
    {
        public void Do()
        {
            PreAction();
            string userInput = GetStringFromUser();
            Console.WriteLine(InterfaceTestTexts.k_CharsCountMessageTemplate, userInput.Length);
            PostAction();
        }
    }
}