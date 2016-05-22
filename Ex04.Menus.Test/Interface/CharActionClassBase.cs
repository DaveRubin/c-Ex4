namespace Ex04.Menus.Test.Interface
{
    using System;

    public abstract class CharActionClassBase : InterfaceActionBase
    {
        protected string GetStringFromUser()
        {
            Console.WriteLine(InterfaceTestTexts.k_PleaseEnterStringMessage);
            return Console.ReadLine();
        }
    }
}