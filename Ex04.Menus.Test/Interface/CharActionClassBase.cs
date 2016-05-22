namespace Ex04.Menus.Test.Interface
{
    using System;

    public abstract class CharActionClassBase : ClearScreenDoActionWaitForUserDoableBase
    {
        protected string GetStringFromUser()
        {
            Console.WriteLine(InterfaceTestTexts.k_PleaseEnterStringMessage);
            return Console.ReadLine();
        }
    }
}