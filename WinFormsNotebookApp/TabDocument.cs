using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsNotebookApp
{
    class TabDocument
    {
        public TabPage? Page { get; private set; }
        public System.Windows.Forms.TextBox EditBox { get; private set; }

        public string FileName { get; set; } = "";

        public bool IsSave { get; set; } = true;
        public bool IsNew { get; set; } = true;
        
        public TabDocument(TabPage page, System.Windows.Forms.TextBox editBox)
        {
            this.Page = page;
            this.EditBox = editBox;
        }
    }
}
