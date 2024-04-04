using System.Runtime.InteropServices;

namespace Pluralsight.CShPlaybook.Interop;

public class NativeMsgBox
{
    [DllImport("user32.dll")]
    private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

    const uint MB_YESNO = 0x4;

    public static void DisplayMsgBox() =>
        MessageBox(
            IntPtr.Zero, "Do you like this native message box?", "Native Message Box", MB_YESNO);
}