namespace Ex04.Menus.Test.Interface
{
    using System;

    public abstract class InterfaceActionBase
    {
        protected void PreAction()
        {
            Console.Clear();
        }

        protected void PostAction()
        {
            Console.WriteLine(InterfaceTestTexts.k_PressEnterToContinueMessage);
            Console.ReadLine();
        }
    }
}