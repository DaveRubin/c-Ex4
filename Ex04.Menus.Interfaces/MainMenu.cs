namespace Ex04.Menus.Interfaces
{

    public class MainMenu : Menu
    {
        private static string k_MainMenuBackString = "Exit";

        public MainMenu(string i_Title)
            : base(i_Title, k_MainMenuBackString)
        {
        }

    }
}