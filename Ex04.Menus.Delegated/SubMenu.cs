using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Ex04.Menus.Delegates
{
    /// <summary>
    /// This class implements the sub menu.
    /// </summary>
    public class SubMenu : GeneralMenu
    {
        private ArrayList m_menu = new ArrayList();

        /// <summary>
        /// Ctor for SubMenu class. The Ctor calls GeneralMenu Ctor. 
        /// </summary>
        /// <param name="i_menuItemTitle"> The title (GeneralMenu datamember).</param>
        /// <param name="i_parentMenu"> The Parent menu (GeneralMenu datamember).</param>
        public SubMenu(string i_menuItemTitle, GeneralMenu i_parentMenu) :
            base(i_menuItemTitle, i_parentMenu) 
        {
        }

        /// <summary>
        /// Ctor for SubMenu class. The Ctor calls GeneralMenu Ctor. 
        /// </summary>
        /// <param name="i_menuItemTitle"> The title (GeneralMenu datamember).</param>
        public SubMenu(string i_menuItemTitle) :
            base(i_menuItemTitle) 
        {
        }

        /// <summary>
        /// This method adds a new FUNCTION item to the current menu.
        /// </summary>
        /// <param name="i_functionTitle"> The name (title) of the function.</param>
        /// <param name="i_functionToCall"> A delegate to the function that will activate it.</param>
        public void AddMenuItemFunction(string i_functionTitle, ActionableItem.MenuObjectFunctionToCallDelegate i_functionToCall)
        {
            GeneralMenu newMenuItem = new ActionableItem(i_functionTitle, this, i_functionToCall);
            m_menu.Add(newMenuItem);
        }

        /// <summary>
        /// This method adds a new sub menu to the current menu.
        /// </summary>
        /// <param name="i_menuTitle"> The new sub menu name.</param>
        public void AddMenuItemMenu(string i_menuTitle)
        {
            GeneralMenu newMenuItem = new SubMenu(i_menuTitle, this);
            m_menu.Add(newMenuItem);
        }

        /// <summary>
        /// This method returns a reference to a selected sub menu or option.
        /// </summary>
        /// <param name="i_requestedSubMenuNum">The number of the menu object to retrive.</param>
        /// <returns>GeneralMenu object  erence to the item selected.</returns>
        /// <exception c ="IndexOutOfRangeException"> Trow an exception if the requested index does not exist (index out of range).</exception>
        public GeneralMenu GetMenuItem(int i_requestedSubMenuNum)
        {
            int maxMenuItem = m_menu.Count;
            GeneralMenu returnedMenu = null;

            i_requestedSubMenuNum = i_requestedSubMenuNum - 1;

            if (i_requestedSubMenuNum < maxMenuItem)
            {
                returnedMenu = m_menu[i_requestedSubMenuNum] as GeneralMenu;
            }
            else
            {
                throw new IndexOutOfRangeException("Requested sub menu does not exist");
            }

            return returnedMenu;
        }

        /// <summary>
        /// This Method runs the current menu in a loop, until
        /// a sub menu/function is selected, or the user requests to
        /// quit or move to a higher menu
        /// </summary>
        /// <returns> The function returns True is the user chose to quit program</returns>
        public override bool Show()
        {
            const string upSign = "0";
            string userSelectionString;
            int userSelectionNum;
            int maxMenuItemNum = m_menu.Count;
            bool wasQuitSelected = false;
            bool wasUpSelected = false;

            while ((wasQuitSelected == false) && (wasUpSelected == false))
            {
                Console.Clear();

                // Show menu items and options
                this.ShowMenuItems();
                if (ParentMenu == null)
                {
                    Console.WriteLine("{0} - Exit", upSign);
                }
                else
                {
                    Console.WriteLine("{0} - Back ", upSign);
                }

                // Get user selection
                Console.WriteLine("Please select from menu above");
                Console.Write("> ");
                userSelectionString = Console.ReadLine();

                // Check input validity and setting quit and up flags
                while ((ValidateIdentifyMenuSelection(userSelectionString, maxMenuItemNum, out userSelectionNum) == false)
                    && (userSelectionString.ToUpper() != upSign))
                {
                    userSelectionString = Console.ReadLine();
                }

                userSelectionString = userSelectionString.ToUpper();
                if (userSelectionString == upSign)
                {
                    wasUpSelected = true;
                }
                else
                {
                    wasQuitSelected = (m_menu[userSelectionNum - 1] as GeneralMenu).Do();
                }
            }

            return wasQuitSelected;
        }

        /// <summary>
        /// This method checks if the user's input is valid.
        /// The method checks that the input consists of digits
        /// and transforms it into a number, and checks that it is between
        /// 1 and the max allowed value.
        /// </summary>
        /// <param name="i_userSelectionString">The read input string </param>
        /// <param name="i_maxAllowedValue">The max allowed value</param>
        /// <param name="o_userSelectionNum">The pharsed input (out parametr)</param>
        /// <returns></returns>
        private bool ValidateIdentifyMenuSelection(string i_userSelectionString, int i_maxAllowedValue, out int o_userSelectionNum)
        {
            bool wasInputValid = true;
            int userSelectionStringLen = i_userSelectionString.Length;
            int i = 0;

            while ((i < userSelectionStringLen) && (wasInputValid == true))
            {
                if ((i_userSelectionString[i] < '0') || (i_userSelectionString[i] > '9'))
                {
                    wasInputValid = false;
                }

                i++;
            }

            if (i_userSelectionString == string.Empty)
            {
                wasInputValid = false;
            }

            if (wasInputValid == true)
            {
                o_userSelectionNum = int.Parse(i_userSelectionString);

                if ((o_userSelectionNum > i_maxAllowedValue) && (o_userSelectionNum > 0))
                {
                    wasInputValid = false;
                }
            }
            else
            {
                // Set error value for out parameter
                o_userSelectionNum = 0;
            }

            return wasInputValid;
        }

        /// <summary>
        /// This method shows the current menu. The assistes the Show method
        /// and is not mentioned to be used by itself.
        /// </summary>
        private void ShowMenuItems()
        {
            int titleLen = m_Title.Length;
            int subMenuLen = m_menu.Count;

            ShowTitle();

            for (int i = 0; i < titleLen; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < subMenuLen; i++)
            {
                Console.Write("{0} - ", i + 1);
                (m_menu[i] as GeneralMenu).ShowTitle();
            }
        }

        /// <summary>
        /// Activate the current menu (show it).
        /// </summary>
        /// <returns></returns>
        public override bool Do()
        {
            return Show();
        }
    }
}
