using System.Runtime.InteropServices;
namespace WinApiMessageBeepDZ1
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
        const uint MB_ICONWARNING = 0x030;
        const uint MB_CANCELTRYCONTINUE = 0x06;
        const uint MB_DEFBUTTON2 = 0x0100;
        const int MB_YESNOCANCEL = 0x03;
        public enum beepType
        {
            SimpleBeep = -1,
            OK = 0x00,
            Question = 0x20,
            Exclamation = 0x30,
            Asterisk = 0x40,
        }

        [DllImport("User32.dll")]
        private static extern bool MessageBeep(uint type);

        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "lalalala", "lolololo", 0x030);
            beep(beepType.Asterisk);
            Thread.Sleep(1000);
            beep(beepType.Exclamation);
            Thread.Sleep(1000);
            beep(beepType.OK);
            Thread.Sleep(1000);
            beep(beepType.Question);
            Thread.Sleep(1000);
        }
        public static void beep(beepType type)
        {
            MessageBeep((uint)type);
        }
       

    }
}
