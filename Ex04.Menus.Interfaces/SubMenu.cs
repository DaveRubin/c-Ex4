namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private readonly Menu r_innerMenu;

        public SubMenu(string i_Name)
            : base(i_Name)
        {
            r_innerMenu = new Menu(i_Name, "back");
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            r_innerMenu.AddItem(i_MenuItem);
        }

        public override void OnSelection()
        {
            r_innerMenu.Show();
        }
    }
}