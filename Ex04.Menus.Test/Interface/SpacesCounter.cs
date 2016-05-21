namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;
    public class SpacesCounter : CharActionClassBase, IDoable
    {
        private string k_SpacesCountMessageTemplate = @"The inserted string have {0} spaces in it
Press 'Enter' to continue";

        public void Do()
        {
            Console.Clear();
            string userInput = GetStringFromUser();
            int spaceCount = CountSpaces(userInput);
            Console.WriteLine(k_SpacesCountMessageTemplate, spaceCount);
            Console.ReadLine();
        }

        private int CountSpaces(string i_String)
        {
            int result = 0;

            foreach (char c in i_String)
            {
                if (c == ' ')
                {
                    result++;
                }
            }

            return result;
        }
    }
}