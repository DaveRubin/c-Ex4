namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private Menu m_innerMenu;

        public SubMenu(string i_Name)
            : base(i_Name)
        {
            m_innerMenu = new Menu(i_Name, "back");
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            m_innerMenu.AddItem(i_MenuItem);
        }

        public override void OnSelection()
        {
            m_innerMenu.Show();
        }
    }
}