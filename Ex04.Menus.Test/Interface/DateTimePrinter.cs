namespace Ex04.Menus.Test.Interface
{
    using System;
    using System.Collections.Generic;

    using Ex04.Menus.Interfaces;

    public class DateTimePrinter : InterfaceActionBase, IDoable
    {
        private const string k_DateTimeEnumValueForDate = "d";
        private const string k_DateTimeEnumValueForTime = "t";
        private static readonly Dictionary<ePrintDateTimeType, string> sr_DateTimeToStringDict;
        private string m_SelectedDateTimeFormat;

        /// <summary>
        /// static constructor to build the enum dictionary
        /// </summary>
        static DateTimePrinter()
        {
            sr_DateTimeToStringDict = new Dictionary<ePrintDateTimeType, string>()
                                          {
                                              {
                                                  ePrintDateTimeType.Date,
                                                  k_DateTimeEnumValueForDate
                                              },
                                              {
                                                  ePrintDateTimeType.Time,
                                                  k_DateTimeEnumValueForTime
                                              }
                                          };
        }

        /// <summary>
        /// Contructor to set the proper format
        /// </summary>
        /// <param name="i_Type"></param>
        public DateTimePrinter(ePrintDateTimeType i_Type)
        {
            m_SelectedDateTimeFormat = sr_DateTimeToStringDict[i_Type];
        }

        /// <summary>
        /// Print Now in the selected format
        /// </summary>
        public void Do()
        {
            PreAction();
            Console.WriteLine(DateTime.Now.ToString(m_SelectedDateTimeFormat));
            PostAction();
        }

        public enum ePrintDateTimeType
        {
            Date,
            Time
        }
    }
}