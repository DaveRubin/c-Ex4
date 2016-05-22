namespace Ex04.Menus.Test.Interface
{
    using System;

    using Ex04.Menus.Interfaces;

    public class SpacesCounter : CharActionClassBase, IDoable
    {
        public void Do()
        {
            PreAction();
            string userInput = GetStringFromUser();
            int spaceCount = CountSpaces(userInput);
            Console.WriteLine(InterfaceTestTexts.k_SpacesCountMessageTemplate, spaceCount);
            PostAction();
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