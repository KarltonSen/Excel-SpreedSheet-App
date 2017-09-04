using OrderReceiptGUI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderReceiptGUI.Extensions
{
    public static class ListViewExtensions
    {
        private const uint SET_COLUMN_WIDTH = 4126;
        private const int AUTOSIZE_USEHEADER = -2;

        /// <summary>
        /// Automatically determines the correct column size on the the given listview.
        /// </summary>
        /// <param name="targetListView">The listview whose columns are to be autosized.</param>
        public static void AutosizeColumns(this ListView targetListView)
        {
            for (int lngColumn = 0; lngColumn <= (targetListView.Columns.Count - 1); lngColumn++)
            {
                NativeMethods.SendMessage(targetListView.Handle, SET_COLUMN_WIDTH, lngColumn, AUTOSIZE_USEHEADER);
            }
        }
    }
}
