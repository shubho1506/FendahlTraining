using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // 2. DllImport Attribute Example (Calling Windows API)
    class DllImportExample
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, string text, string caption, int options);

        //int hWnd → Handle to the window (0 means no parent window).
        //string text → Message to display inside the MessageBox.
        //string caption → Title of the MessageBox window.
        //int options → Defines button & icon types (e.g., 0 = OK button).
        //1 → OK button clicked
        //2 → Cancel button clicked
        //3 → Abort button clicked
        public void ShowMessageBox()
        {
            MessageBox(0, "Hello from C#", "Interop Demo", 0);
            MessageBox(0, "Do you want to continue?", "Confirm", 1);  // OK & Cancel
            MessageBox(0, "Critical Error!", "Error", 16);  // Red Error Icon
            MessageBox(0, "Warning!", "Warning", 48);  // Yellow Warning Icon
        }
    }
}
