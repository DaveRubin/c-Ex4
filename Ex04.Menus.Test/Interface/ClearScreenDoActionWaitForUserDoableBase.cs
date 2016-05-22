namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;

    public abstract class ClearScreenDoActionWaitForUserDoableBase : IDoable
    {
        public void Do()
        {
            PreActionClear();
            DoAction();
            PostActionWait();
        }

        protected void PreActionClear()
        {
            Console.Clear();
        }

        protected void PostActionWait()
        {
            Console.WriteLine(InterfaceTestTexts.k_PressEnterToContinueMessage);
            Console.ReadLine();
        }

        public abstract void DoAction();
    }
}