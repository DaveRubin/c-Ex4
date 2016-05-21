namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class MenuView
    {
        private const string k_MenuItemTemplate = "{0} - {1}";
        private const string k_MenuGetSelectionMessage = "Please enter your selection";
        private const string k_MenuHeaderTemplate = @"=====================
{0}
=====================";

        public static void PrintMenu(string i_Header, string i_BackWord, List<MenuItem> i_Items)
        {
            Console.Clear();
            PrintHeader(i_Header);
            PrintMenuItems(i_Items,i_BackWord);
            PrintUserSelectionPrompt();
        }

        /// <summary>
        /// Print user selection prompt
        /// </summary>
        private static void PrintUserSelectionPrompt()
        {
            Console.WriteLine(k_MenuGetSelectionMessage);
        }

        /// <summary>
        /// Prints all items from base of 1 
        /// at the end print the item for back option
        /// </summary>
        /// <param name="i_Items"></param>
        /// <param name="i_BackWord"></param>
        private static void PrintMenuItems(List<MenuItem> i_Items, string i_BackWord)
        {
            int index = 1;

            foreach (MenuItem menuItem in i_Items)
            {
                PrintMenuItem(index, menuItem.r_Name);
                index++;
            }

            PrintMenuItem(0, i_BackWord);
        }

        /// <summary>
        /// Print header from template
        /// </summary>
        /// <param name="i_Title"></param>
        private static void PrintHeader(string i_Title)
        {
            Console.WriteLine(string.Format(k_MenuHeaderTemplate, i_Title));
        }

        /// <summary>
        /// Print a single menu item by template
        /// </summary>
        /// <param name="i_Index"></param>
        /// <param name="i_MenuItem"></param>
        private static void PrintMenuItem(int i_Index, string i_MenuItem)
        {
            Console.WriteLine(string.Format(k_MenuItemTemplate, i_Index, i_MenuItem));
        }
    }
}