namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;
    using Ex04.Menus.Test.Interface;

    public class InterfaceTest
    {
        public void Test()
        {
            MainMenu mainMenu = new MainMenu(InterfaceTestTexts.k_MainMenuTitle);
            SubMenu versionActionsMenu = CreateVersionActionMenu();
            SubMenu dateTimeMenu = CreateDateTimeMenu();

            mainMenu.AddItem(versionActionsMenu);
            mainMenu.AddItem(dateTimeMenu);
            mainMenu.Show();
        }

        private SubMenu CreateVersionActionMenu()
        {
            VersionPrinter versionPrinter = new VersionPrinter(InterfaceTestTexts.k_Version);
            ActionItem showVersionItem = new ActionItem(InterfaceTestTexts.k_ShowVersionTitle, versionPrinter);
            SubMenu actionSubMenu = CreateActionsMenu();

            SubMenu versionActionSubmenu = new SubMenu(InterfaceTestTexts.k_VersionActionsMenuTitle);
            versionActionSubmenu.AddItem(showVersionItem);
            versionActionSubmenu.AddItem(actionSubMenu);

            return versionActionSubmenu;
        }

        private SubMenu CreateActionsMenu()
        {
            CharsCounter charsCounter = new CharsCounter();
            SpacesCounter spacesCounter = new SpacesCounter();
            ActionItem charsCountItem = new ActionItem(InterfaceTestTexts.k_CharsCountTitle, charsCounter);
            ActionItem spacesCountItem = new ActionItem(InterfaceTestTexts.k_SpacesCountTitle, spacesCounter);

            SubMenu actionSubMenu = new SubMenu(InterfaceTestTexts.k_ActionsMenuTitle);
            actionSubMenu.AddItem(charsCountItem);
            actionSubMenu.AddItem(spacesCountItem);

            return actionSubMenu;
        }

        private SubMenu CreateDateTimeMenu()
        {
            DateTimePrinter timePrinter = new DateTimePrinter(DateTimePrinter.ePrintDateTimeType.Time);
            DateTimePrinter datePrinter = new DateTimePrinter(DateTimePrinter.ePrintDateTimeType.Date);
            ActionItem printTimeAction = new ActionItem(InterfaceTestTexts.k_PrintTimeTitle, timePrinter);
            ActionItem printDateAction = new ActionItem(InterfaceTestTexts.k_PrintDateTitle, datePrinter);

            SubMenu dateTimeMenu = new SubMenu(InterfaceTestTexts.k_DateTimeMenuTitle);
            dateTimeMenu.AddItem(printDateAction);
            dateTimeMenu.AddItem(printTimeAction);

            return dateTimeMenu;
        }
    }
}