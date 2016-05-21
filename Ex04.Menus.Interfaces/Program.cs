namespace Ex04.Menus.Interfaces
{
    public class Program
    {
        public static void Main()
        {
            Doable1 d1 = new Doable1();
            Doable2 d2 = new Doable2();
            Doable3 d3 = new Doable3();
            
            MainMenu main = new MainMenu("Main menu");
            ActionItem a1 = new ActionItem("Do 1",d1);
            ActionItem a2 = new ActionItem("Do 2",d2);
            ActionItem a3 = new ActionItem("Do 3",d3);

            SubMenu s1 = new SubMenu("SubMenu");

            s1.AddItem(a2);
            s1.AddItem(a3);
            main.AddItem(a1);
            main.AddItem(a2);
            main.AddItem(a3);
            main.AddItem(s1);
            main.Show();
        } 
    }
}