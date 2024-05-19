using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheList
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            this.Multiline = true; // Ensure the TextBox is multiline
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEWHEEL = 0x020A;

            if (m.Msg == WM_MOUSEWHEEL && this.Multiline)
            {
                // Forward the mouse wheel message to the parent control
                if (this.Parent is ScrollableControl scrollableControl)
                {
                    Message parentMessage = Message.Create(this.Parent.Handle, m.Msg, m.WParam, m.LParam);
                    base.WndProc(ref parentMessage);
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}
