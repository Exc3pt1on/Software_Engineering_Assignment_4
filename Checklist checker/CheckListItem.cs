using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checklist_checker
{
    internal class CheckListItem
    {
        // Class for check list items
        public string Text { get; set; }
        public string Position { get; set; }
        public bool IsChecked { get; set; }
        public CheckListItem(string text, string position)
        {
            this.Text = text;
            this.IsChecked = false;
            this.Position = position;
        }
    }
}
