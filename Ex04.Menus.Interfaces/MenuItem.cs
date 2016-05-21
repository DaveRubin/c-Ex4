namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        public readonly string r_Name;

        protected MenuItem(string i_Name)
        {
            r_Name = i_Name;
        }

        public abstract void OnSelection();
    }
}