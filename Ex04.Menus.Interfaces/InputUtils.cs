using System;

namespace Ex04.Menus.Interfaces
{

    internal class InputUtils
    {
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
