namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;

    public class VersionPrinter : InterfaceActionBase, IDoable
    {
        private readonly string r_Version;

        public VersionPrinter(string i_Version)
        {
            r_Version = i_Version;
        }

        public void Do()
        {
            PreAction();
            Console.WriteLine(string.Format(InterfaceTestTexts.k_VersionTemplate, r_Version));
            PostAction();
        }
    }
}