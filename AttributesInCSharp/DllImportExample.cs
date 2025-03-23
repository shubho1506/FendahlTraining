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

        public void ShowMessageBox()
        {
            MessageBox(0, "Hello from C#", "Interop Demo", 0);
        }
    }
}
