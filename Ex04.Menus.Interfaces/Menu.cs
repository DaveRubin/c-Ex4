namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class Menu
    {
        public readonly string r_Title;
        private List<MenuItem> m_MenuItems;
        protected string m_BackText;
        protected string m_Title;

        internal Menu(string i_Title, string i_backWord)
        {
            m_Title = i_Title;
            m_BackText = i_backWord;
            m_MenuItems = new List<MenuItem>();
        }

        public void Show()
        {
            MenuView.PrintMenu(m_Title, m_BackText, m_MenuItems);
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

        /// <summary>
        /// Add new item to list
        /// </summary>
        /// <param name="i_MenuItem"></param>
        public void AddItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }
    }
}