namespace Ex04.Menus.Test
{
    using System;

    public class Program
    {
        public static void Main()
        {
            DelegateTest delegateTest = new DelegateTest();
            InterfaceTest interfaceTest = new InterfaceTest();
            delegateTest.Test();
            interfaceTest.Test();
        }
    }
}