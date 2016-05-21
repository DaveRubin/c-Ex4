using System;

namespace Ex04.Menus.Interfaces
{

    internal class InputUtils
    {
        public const string k_GetBoundedIntFromConsoleTemplate = "Invalid input, please enter a number between {0} and {1} :";
        public const string k_GetIntFromConsoleInvalidMessage = "Invalid input, please enter a number";
        public const string k_GetSepcificCharsFromConsoleInvalidTemplate = "Please enter a charecter from these valid characters: '{0}' ";
        public const string k_GetSepcificCharsFromConsoleExceptionMessage = "Missing valid character params";
        public const string k_GetSingleCharFromConsoleInvalidInputMessage = "Invalid input, Please enter a single character:";
        public const string k_GetBoundedIntOrQuitFromConsoleInvalidTemplate = "Invalid input, please enter a number between {0} to {1} ,or {2} to quit";

        public static int GetBoundedIntFromConsole(int i_Min, int i_Max)
        {
            int result = GetIntFromConsole();

            while (!IntInBounds(result, i_Min, i_Max))
            {
                Console.WriteLine(
                    string.Format(k_GetBoundedIntFromConsoleTemplate, i_Min, i_Max));
                result = GetIntFromConsole();
            }

            return result;
        }

        public static int GetIntFromConsole()
        {
            string userInput = Console.ReadLine();
            int result;

            while (!int.TryParse(userInput, out result))
            {
                Console.WriteLine(k_GetIntFromConsoleInvalidMessage);
                userInput = Console.ReadLine();
            }

            return result;
        }

        /// <summary>
        /// Check if number is between min and max
        /// </summary>
        /// <param name="i_Number"></param>
        /// <param name="i_Min"></param>
        /// <param name="i_Max"></param>
        /// <returns></returns>
        private static bool IntInBounds(int i_Number, int i_Min, int i_Max)
        {
            return i_Min <= i_Number && i_Number <= i_Max;
        }
    }
}
