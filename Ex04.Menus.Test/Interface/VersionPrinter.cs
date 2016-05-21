namespace Ex04.Menus.Test.Interface
{
    using System;
    using Ex04.Menus.Interfaces;

    public class VersionPrinter : IDoable
    {
        private const string k_VersionTemplate = @"Current version is : {0}

Press 'Enter' to continue.";
        private readonly string r_Version;

        public VersionPrinter(string i_Version)
        {
            r_Version = i_Version;
        }

        public void Do()
        {
            Console.Clear();
            Console.WriteLine(string.Format(k_VersionTemplate,r_Version));
            Console.ReadLine();
        }
    }
}