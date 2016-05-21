namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private readonly IDoable r_Doable;

        public ActionItem(string i_Name, IDoable i_Doable)
            : base(i_Name)
        {
            r_Doable = i_Doable;
        }

        public override void OnSelection()
        {
            r_Doable.Do();
        }
    }
}