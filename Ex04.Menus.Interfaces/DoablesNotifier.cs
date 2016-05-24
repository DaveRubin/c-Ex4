namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class DoablesNotifier
    {
        private List<IDoable> m_doables;

        public DoablesNotifier()
        {
            m_doables = new List<IDoable>();
        }

        public void NotifyAll()
        {
            foreach (IDoable doable in m_doables)
            {
                doable.Do();
            }
        }

        public void AddDoable(IDoable i_DoableToAdd)
        {
            m_doables.Add(i_DoableToAdd);
        }

        public void RemoveDoable(IDoable i_DoableToRemove)
        {
            m_doables.Remove(i_DoableToRemove);
        }
    }
}