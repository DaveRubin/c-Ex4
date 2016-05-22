namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;

    public class CharsCounter : CharActionClassBase
    {
        public override void DoAction()
        {
            string userInput = GetStringFromUser();
            Console.WriteLine(InterfaceTestTexts.k_CharsCountMessageTemplate, userInput.Length);
        }
    }
}