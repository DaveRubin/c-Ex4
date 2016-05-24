namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Delegates;
    using Ex04.Menus.Test.Interface;

    public class DelegateTest
    {
        public void Test()
        {
            MainMenu mainMenu = new MainMenu(InterfaceTestTexts.k_MainMenuTitle);
            SubMenu showDateTime;
            SubMenu actionsSubMenu;
            SubMenu versionAndActionsSubMenu;
            ActionableItem.MenuObjectFunctionToCallDelegate callCharsCount;
            ActionableItem.MenuObjectFunctionToCallDelegate callCountSpaces;
            ActionableItem.MenuObjectFunctionToCallDelegate callShowTime;
            ActionableItem.MenuObjectFunctionToCallDelegate callShowDate;
            ActionableItem.MenuObjectFunctionToCallDelegate callShowVersion;
            callShowVersion = new ActionableItem.MenuObjectFunctionToCallDelegate(ShowVersion);
            callCharsCount = new ActionableItem.MenuObjectFunctionToCallDelegate(CharsCount);
            callCountSpaces = new ActionableItem.MenuObjectFunctionToCallDelegate(CountSpaces);
            callShowTime = new ActionableItem.MenuObjectFunctionToCallDelegate(ShowTime);
            callShowDate = new ActionableItem.MenuObjectFunctionToCallDelegate(ShowDate);

            // Create the main menu
            mainMenu.AddMenuItemMenu("Version and Actions");
            mainMenu.AddMenuItemMenu("Show Date/Time");

            // Create Version and Actions sub menu
            versionAndActionsSubMenu = (SubMenu)mainMenu.GetMenuItem(1);
            versionAndActionsSubMenu.AddMenuItemFunction("Show Version", callShowVersion);
            versionAndActionsSubMenu.AddMenuItemMenu("Actions");

            // Create the Actions sub sub menu
            actionsSubMenu = (SubMenu)versionAndActionsSubMenu.GetMenuItem(2);
            actionsSubMenu.AddMenuItemFunction("Chars Count", callCharsCount);
            actionsSubMenu.AddMenuItemFunction("Count Spaces", callCountSpaces);
            
            // create the Show Date/Time sub menu
            showDateTime = (SubMenu)mainMenu.GetMenuItem(2);
            showDateTime.AddMenuItemFunction("Show Time", callShowTime);
            showDateTime.AddMenuItemFunction("Show Date", callShowDate);

            mainMenu.Show();
        }
     
        private bool ShowTime()
        {
            PreActionClear();
            DateTimePrinter timePrinter = new DateTimePrinter(DateTimePrinter.ePrintDateTimeType.Time);
            timePrinter.DoAction();

            return true;
        }
            
        private bool ShowDate()
        {
            PreActionClear();
            DateTimePrinter datePrinter = new DateTimePrinter(DateTimePrinter.ePrintDateTimeType.Date);
            datePrinter.DoAction();

            return true;
        }

        private string GetStringFromUser()
        {
            Console.WriteLine(InterfaceTestTexts.k_PleaseEnterStringMessage);
            return Console.ReadLine();
        }

        private bool CharsCount()
        {
            PreActionClear();
            string userInput = GetStringFromUser();
            Console.WriteLine(InterfaceTestTexts.k_CharsCountMessageTemplate, userInput.Length);
            PostActionWait();

            return true;
        }

        private bool ShowVersion()
        {
            PreActionClear();
            Console.WriteLine(string.Format(InterfaceTestTexts.k_VersionTemplate, "Version: 16.2.4.0"));
            PostActionWait();

            return true;
        }

        protected void PostActionWait()
        {
            Console.WriteLine(InterfaceTestTexts.k_PressEnterToContinueMessage);
            Console.ReadLine();
        }

        protected void PreActionClear()
        {
            Console.Clear();
        }

        private bool CountSpaces()
        {
            PreActionClear();
            string userInput = GetStringFromUser();
            int spaceCount = CountSpacesInt(userInput);
            Console.WriteLine(InterfaceTestTexts.k_SpacesCountMessageTemplate, spaceCount);
            PostActionWait();

            return true;
        }

        private int CountSpacesInt(string i_String)
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
