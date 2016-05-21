namespace Ex04.Menus.Test
{
    using System;

    using Ex04.Menus.Interfaces;
    using Ex04.Menus.Test.Interface;

    public class InterfaceTest
    {
        private string k_CharsCountTitle = "Chars Count";
        private string k_SpacesCountTitle = "Count Spaces";
        private string k_DateTimeMenuTitle = "Show Date/Time";
        private const string k_PrintTimeTitle = "Show time";
        private const string k_PrintDateTitle = "Show Date";
        private const string k_ActionsMenuTitle = "Actions";
        private const string k_SubMenuATitle = "Versions and Actions";
        private const string k_SubMenuAShowVersionItemName = "Show Version";
        private const string k_Version = "6.6.6";

        public void Test()
        {
            Console.WriteLine("Testing interface");
            MainMenu mainMenu = new MainMenu("Main");
            SubMenu versionActionsMenu = CreateVersionActionMenu();
            SubMenu dateTimeMenu = CreateDateTimeMenu();

            mainMenu.AddItem(versionActionsMenu);
            mainMenu.AddItem(dateTimeMenu);
            mainMenu.Show();
        }

        private SubMenu CreateVersionActionMenu()
        {
            VersionPrinter versionPrinter = new VersionPrinter(k_Version);
            ActionItem showVersionItem = new ActionItem(k_SubMenuAShowVersionItemName, versionPrinter);
            SubMenu actionSubMenu = CreateActionsMenu();

            SubMenu versionActionSubmenu = new SubMenu(k_SubMenuATitle);
            versionActionSubmenu.AddItem(showVersionItem);
            versionActionSubmenu.AddItem(actionSubMenu);

            return versionActionSubmenu;
        }

        private SubMenu CreateActionsMenu()
        {
            CharsCounter charsCounter = new CharsCounter();
            SpacesCounter spacesCounter = new SpacesCounter();
            ActionItem charsCountItem = new ActionItem(k_CharsCountTitle, charsCounter);
            ActionItem spacesCountItem = new ActionItem(k_SpacesCountTitle, spacesCounter);

            SubMenu actionSubMenu = new SubMenu(k_ActionsMenuTitle);
            actionSubMenu.AddItem(charsCountItem);
            actionSubMenu.AddItem(spacesCountItem);

            return actionSubMenu;
        }

        private SubMenu CreateDateTimeMenu()
        {
            TimePrinter timePrinter = new TimePrinter();
            DatePrinter datePrinter = new DatePrinter();
            ActionItem printTimeAction = new ActionItem(k_PrintTimeTitle,timePrinter);
            ActionItem printDateAction = new ActionItem(k_PrintDateTitle, datePrinter);

            SubMenu dateTimeMenu = new SubMenu(k_DateTimeMenuTitle);
            dateTimeMenu.AddItem(printDateAction);
            dateTimeMenu.AddItem(printTimeAction);

            return dateTimeMenu;
        }
    }
}