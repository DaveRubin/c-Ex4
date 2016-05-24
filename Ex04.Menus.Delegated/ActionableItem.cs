using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionableItem : GeneralMenu
    {
        /// <summary>
		/// A nested delegeate class for called functions
		/// This delegate will be used to hold functions that the menu
		/// will activate when selected.
		/// </summary>
		public delegate bool MenuObjectFunctionToCallDelegate();
		
		private MenuObjectFunctionToCallDelegate m_functionToCall = null;
				
		/// <summary>
        /// Ctor for ActionableItem class.
		/// </summary>
		/// <param name="i_MenuItemTitle"> Menu title.</param>
		/// <param name="i_ParentMenu"> Parent menu.</param>
		/// <param name="i_FunctionToCall">  Delegate that holds the function to be called.</param>
		public ActionableItem(string i_MenuItemTitle, GeneralMenu i_ParentMenu, MenuObjectFunctionToCallDelegate i_FunctionToCall)
            : base(i_MenuItemTitle, i_ParentMenu)
        {
            m_functionToCall = i_FunctionToCall;
		}

		/// <summary>
		/// Set method for the delegate that holds the function that is called
		/// by this menu.
		/// </summary>
		public MenuObjectFunctionToCallDelegate FunctionToCall
		{
			get
			{
				return m_functionToCall;
			}

			set
			{
				m_functionToCall = value;
			}		
		}

		/// <summary>
		/// Show method for function menu item.
		/// </summary>
		/// <returns>The function returns always false (as an indicator the user
		/// did not request to quit menu while the function was called.</returns>
		public override bool Show()
		{	
			ShowTitle();

			return false;
		}

		/// <summary>
		/// This method is used to call the function this menu item holds.
		/// The function runs the function by calling the object that holds the function,
		/// with the FunctionNumber it should run.
		/// </summary>
		/// <exception c ="AnyException"> Any exception raised during the function ran will be caught
		/// here and an error message will be printed. The system will return to the calling
		/// menu.</exception>
		public void CallFunction()
		{
			bool functionRetVal = false;
			
			if (m_functionToCall != null)
			{
				try
				{
					functionRetVal = m_functionToCall();
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
                finally
                {
                    if (functionRetVal == false)
                    {
                        Console.WriteLine("The function failed.");
                    }
                }
			}			
		}
		
		/// <summary>
		/// This method is the main method used to activate menu item function 
		/// The method calls the CallFunction function.
		/// </summary>
		/// <returns>The function returns always false (as an indicator the user
		/// did not request to quit menu while the function was called.</returns>
		public override bool Do()
		{
			CallFunction();
	
			return false;
		}
    }
}
