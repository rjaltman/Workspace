using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyOnGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getOutOfHere_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyThem()
        {
            //System.IO.FileInfo[] files = null;
            //System.IO.DirectoryInfo[] subDirs = null;


            //try
            //{
            //    files = initPath.GetFiles("*.*");
            //}
            //// MICROSOFT: "This is thrown if even one of the files requires permissions greater 
            //// than the application provides."
            //// Side question: Why did Microsoft create pseudo-folders to My Music, My Documents, and My Videos?

            //catch (UnauthorizedAccessException e)
            //{
            //    // For now, we will not report any unauthorized access exceptions. We could log it, as in the Microsoft example, but...well, nahhh. 
            //    // By that, this should be discussed with evaluators...and myself.
            //}

            //catch (System.IO.DirectoryNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //if (files != null)
            //{
            //    if (hiWhatNow == "Documents")
            //    {
            //        Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Documents\" + initPath.FullName.Replace(docsCopyPath, ""));
            //        arcadePanel_Reflektions.Text = "Creating Directory for User: " + @"\Documents\" + initPath.FullName.Replace(docsCopyPath, "");

            //        foreach (System.IO.FileInfo fi in files)
            //        {
            //            File.Copy(fi.FullName, @"C:\ProjectSnowshoes\User\" + formalName + @"\Documents\" + fi.FullName.Replace(docsCopyPath, ""));
            //            arcadePanel_Reflektions.Text = "Copying file: " + fi.FullName + " to Documents\\" + fi.FullName.Replace(docsCopyPath, "");
            //            this.Invalidate();
            //        }
            //    }
            //    else
            //    {
            //        Directory.CreateDirectory(@"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures\" + initPath.FullName.Replace(imgCopyPath, ""));
            //        arcadePanel_Reflektions.Text = "Creating Directory for User: " + @"\Pictures\" + initPath.FullName.Replace(imgCopyPath, "");

            //        foreach (System.IO.FileInfo fi in files)
            //        {
            //            File.Copy(fi.FullName, @"C:\ProjectSnowshoes\User\" + formalName + @"\Pictures\" + fi.FullName.Replace(imgCopyPath, ""));
            //            arcadePanel_Reflektions.Text = "Copying file: " + fi.FullName + " to Pictures\\" + fi.FullName.Replace(imgCopyPath, "");
            //            this.Invalidate();
            //        }
            //    }
            //    // "Now find all the subdirectories under this directory."
            //    subDirs = initPath.GetDirectories();

            //    foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            //    {
            //        // "Recursive call for each subdirectory."
            //        populateDirectories(dirInfo);
            //    }



            //}
        }

        private void getSetUp_Click(object sender, EventArgs e)
        {

            //Process.Start(@"ClientSide\System\Fonts\PSFontInstall.vbs");

            ProcessStartInfo s = new ProcessStartInfo();
            //s.CreateNoWindow = false;
            s.UseShellExecute = false;
            s.FileName = "xcopy";
            //s.WindowStyle = ProcessWindowStyle.Hidden;
            //Send the Source and destination as Arguments to the process
            s.Arguments = @"ClientSide C:\ProjectSnowshoes\ /s /y";
            Process.Start(s);

            while (!File.Exists(@"C:\ProjectSnowshoes\System\Fonts\PSFontInstall.vbs"))
            {
                // pls
            }
            Process.Start(@"C:\ProjectSnowshoes\System\Fonts\PSFontInstall.vbs");
            ////System.Diagnostics.Process.Start(@"xcopy ClientSide C:\ProjectSnowshoes\ /s");
            //Process.Start(@"C:\ProjectSnowshoes\System\Fonts\PSFontInstall.vbs");

            allDone.Visible = true;
            closeButton.Visible = true;
            robotoNotice.Visible = false;
            subtext.Visible = false;
            thanks.Visible = false;
            getSetUp.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
