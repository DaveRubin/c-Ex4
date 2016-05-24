namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private readonly DoablesNotifier m_Doables;

        public ActionItem(string i_Name, IDoable i_Doable)
            : base(i_Name)
        {
            m_Doables = new DoablesNotifier();
            AddDoable(i_Doable);
        }

        public void AddDoable(IDoable i_Doable)
        {
            m_Doables.AddDoable(i_Doable);
        }

        public void RemoveDoable(IDoable i_Doable)
        {
            m_Doables.RemoveDoable(i_Doable);
        }

        public override void OnSelection()
        {
            m_Doables.NotifyAll();
        }
    }
}