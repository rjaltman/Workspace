using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PartOfTheProc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        // Member Vars
        int currentCountProc = 0;
        
        // Def constructor
        public MainWindow()
        {
            InitializeComponent();
            //currentCountProc = 0;
            goGenerateProcessesFriendship();
        }

        delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn,
        IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        private IEnumerable<IntPtr> getHandles(Process proc)
        {
            // This is my first work with handles on Windows in a while, so 
            // please be kind...also, thanks to Stack Overflow (Spirin, K) for posting 
            // an elegant solution that handles this...a lot of what you see ahead 
            // is basically a re-transcription of his response!

            var h = new List<IntPtr>(); // Seriously, match this line. It's nearly identical.

            foreach (ProcessThread t in proc.Threads)
            {
                EnumThreadWindows(t.Id, (hWnd, lParam) => { h.Add(hWnd); return true; }, IntPtr.Zero);
            }

            return h;

        }


        private void goGenerateProcessesFriendship()
        {
            int artOfficial = 0;
            foreach (var theProcess in Process.GetProcesses())
            {
                if (theProcess.MainWindowTitle != "" && theProcess.MainWindowTitle != "Space") { artOfficial++; }
            }
            if (artOfficial != currentCountProc)
            {
                spaceForProcesses.Text = "";
                int procCount = 0;
                foreach (var theProcess in Process.GetProcesses())
                {
                    if (procCount != 0 && procCount != 4)
                    {
                        if ((theProcess.MainWindowTitle != "" && theProcess.Modules[0].FileName != "ProjectSnowshoes.exe") && theProcess.MainWindowHandle != null)
                        {
                            foreach (var h in getHandles(theProcess))
                            {
                                if (IsWindowVisible(h))
                                {
                                    //StringBuilder sb = new StringBuilder(GetWindowTextLength(h) + 1);
                                    //GetWindowText(h, sb, sb.Capacity);
                                    Console.WriteLine(theProcess.MainWindowTitle + "\n");
                                    spaceForProcesses.AppendText(theProcess.MainWindowTitle + "\n");
                                }
                            }
                        }

                    }
                    procCount++;
                }

            }

            currentCountProc = artOfficial;


        }

        private void spaceForProcesses_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}

