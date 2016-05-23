using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class GeneralMenu
    {
		protected string		m_Title = null;
		protected GeneralMenu	m_ParentMenu = null;
		protected GeneralMenu	m_RootMenu = null;

		/// <summary>
		/// Ctor for root menu.
		/// </summary>
		/// <param name="i_MenuItemTitle"> Menu name.</param>
		public GeneralMenu(string i_MenuItemTitle) 
            : this(i_MenuItemTitle, null)
        {
        }

		/// <summary>
		/// Ctor for sub menu.
		/// </summary>
		/// <param name="i_MenuItemTitle">Menu name. </param>
		/// <param name="i_ParentMenu">Parent menu pointer.</param>
		public GeneralMenu(string i_MenuItemTitle, GeneralMenu i_ParentMenu)
		{
			m_Title			= i_MenuItemTitle;
			m_ParentMenu	= i_ParentMenu;
			
			if (m_ParentMenu != null)
			{
				m_RootMenu = i_ParentMenu.m_RootMenu;
			}
		}
		
		/// <summary>
		/// Abstract method to show the menu properties and actionables
		/// </summary>
		/// <returns>Return value is TRUE if the user requested to quit.</returns>
		public abstract bool Show();

		/// <summary>
		/// Run the menu actionable (show or activate function).
		/// </summary>
		/// <returns>Return value is TRUE if the user requested to quit.</returns>
		public abstract bool Do();
		
		public void ShowTitle()
		{
			Console.WriteLine(m_Title);
		}

		/// <summary>
		/// Property for ParentMenu variable.
		/// </summary>
		public GeneralMenu ParentMenu
		{
			get 
			{
				return m_ParentMenu;
			}

			set
			{
				m_ParentMenu = value;
			}
		}

		/// <summary>
		/// Property for RootMenu variable.
		/// </summary>
		public GeneralMenu RootMenu
		{
			get 
			{
				return m_RootMenu;
			}

			set
			{
				m_RootMenu = value;
			}
		}

		/// <summary>
		/// Proprty for MenuTitle variable.
		/// </summary>
		public string MenuTitle
		{
			get
			{
				return m_Title;
			}

			set
			{
				m_Title = value;
			}
		}
	}	
}
