namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class Menu
    {

        public readonly string k_Title;
        private List<MenuItem> m_MenuItems;
        private const string k_MenuItemTemplate = "{0} - {1}";
        protected MenuItem m_backItem;
        protected string m_Title;
        private string k_MenuGetSelectionMessage = "Please enter your selection";
        private string k_MenuHeaderTemplate = @"=====================
{0}
=====================";

        internal Menu(string i_Title, string i_backWord)
        {
            m_Title = i_Title;
            m_backItem = new BackItem(i_backWord);
            m_MenuItems = new List<MenuItem>();
        }

        public void Show()
        {
            Console.Clear();
            PrintHeader();
            PrintMenuItems();
            GetInput();
        }

        private void GetInput()
        {
            int min = 0;
            int max = m_MenuItems.Count;
            int userSelection = InputUtils.GetBoundedIntFromConsole(min, max);

            // if non "back" item was selected
            if (userSelection > 0)
            {
                MenuItem selectedMenuItem = m_MenuItems[userSelection - 1];
                selectedMenuItem.OnSelection();
                Show();
            }

        }


        private void PrintMenuItems()
        {
            int index = 1;

            foreach (MenuItem menuItem in m_MenuItems)
            {
                PrintMenuItem(index, menuItem);
                index++;
            }

            PrintMenuItem(0, m_backItem);
        }

        private void PrintHeader()
        {
            Console.WriteLine(string.Format(k_MenuHeaderTemplate,m_Title));
        }

        /// <summary>
        /// Add new item to list
        /// </summary>
        /// <param name="i_MenuItem"></param>
        public void AddItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        private void PrintMenuItem(int i_Index, MenuItem i_MenuItem)
        {
            Console.WriteLine(string.Format(k_MenuItemTemplate,i_Index,i_MenuItem.r_Name));
        }
    }
}