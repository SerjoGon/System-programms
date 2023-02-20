using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System_programms
{
    internal class Program
    {
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
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassname, string lpwindowname);
        [DllImport("user32.dll")]
        public static extern long SendMessage(IntPtr Hwnd, uint Msg, int wParam, string lParam);
        const uint MB_ICONWARNING = 0x030;
        const uint MB_CANCELTRYCONTINUE = 0x06;
        const uint MB_DEFBUTTON2 = 0x0100;
        const int MB_YESNOCANCEL = 0x03;

       /* static int MyMessageBox(int numbtext)
        {
            return MessageBox(IntPtr.Zero, "YES - Number is RIGHT"
                + "NO - FALSE" + "CANCEL = Number is more than yours \n maybe this your number"
                + numbtext.ToString(), "Угадай число", MB_YESNOCANCEL | MB_DEFBUTTON2);
        }*/
        static int MyFirstMessageBox(string text)
        {
            return MessageBox(IntPtr.Zero, text, "Нажмите ДА", MB_YESNOCANCEL);
        }
        static void Main(string[] args)
        {
            #region Home
            string text = "Привет, меня зовут Сергей,\nя из группы ПВ111, \nэто мое первое ДЗ\nи я заслужил оценку 12!!!";
            int answer = 0;
            while ((answer = MyFirstMessageBox(text)) != 6)
            {
                if (answer == 2 || answer == 7)
                {
                    MessageBeep(0x030);
                    MyFirstMessageBox(text);
                }
            }
                #endregion
                #region Class
                //string caption = "";
                //IntPtr HWND = FindWindow("notepad",caption);
                //SendMessage(HWND, 0x000C, 0, "NEW TEXT");

                //Task1.2
                /*
                int minNumb = 0;
                int maxNumb = 10000000;
                Random random = new Random();
                int result = random.Next(minNumb, maxNumb);
                int answer = 0;
                while ((answer = MyMessageBox(result)) != 6)
                {
                    if (answer == 2)
                    {
                        minNumb = result;
                        result = random.Next(minNumb, maxNumb);
                    }
                    if (answer == 7)
                    {
                        maxNumb = result;
                        result = random.Next(minNumb, maxNumb);
                    }
                }
                MessageBeep((uint)0x00000040L);
                MessageBox(IntPtr.Zero, "Ура я читаю мысли!!!  Число = " + result.ToString(), "Число угадано", 0x0);
                */
                /*
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo("notepad.exe");
                process.Start();
                process.WaitForExit();
                //process.Kill();
                //process.CloseMainWindow();
                process.Close();
                Console.WriteLine("После закрытия ");
                Process[] processes = Process.GetProcesses();
                foreach(Process p in processes)
                {
                    Console.WriteLine("{0,-35 }{1,10}", p.ProcessName , p.Id);
                }
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo();
                Console.ReadLine();
                */
                #endregion

            
        }
    }
}
