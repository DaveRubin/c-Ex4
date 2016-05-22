namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;

    public class VersionPrinter : ClearScreenDoActionWaitForUserDoableBase
    {
        private readonly string r_Version;

        public VersionPrinter(string i_Version)
        {
            r_Version = i_Version;
        }

        public override void DoAction()
        {
            PreActionClear();
            Console.WriteLine(string.Format(InterfaceTestTexts.k_VersionTemplate, r_Version));
            PostActionWait();
        }
    }
}