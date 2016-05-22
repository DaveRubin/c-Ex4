namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private readonly Menu r_InnerMenu;

        public SubMenu(string i_Name)
            : base(i_Name)
        {
            r_InnerMenu = new Menu(i_Name, InterfaceTexts.k_SubMenuBackText);
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            r_InnerMenu.AddItem(i_MenuItem);
        }

        public override void OnSelection()
        {
            r_InnerMenu.Show();
        }
    }
}