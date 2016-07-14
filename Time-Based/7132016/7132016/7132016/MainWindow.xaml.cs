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
using System.Windows.Interop;


namespace _7132016
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int currentCountProc = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.Left = 0;
            this.Top = SystemParameters.WorkArea.Height - 2;
            this.Width = SystemParameters.WorkArea.Width;
            this.Topmost = true;
            System.Diagnostics.Process.Start("taskkill.exe", "/F /IM explorer.exe");
            goGenerateProcessesFriendship();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern void ShowWindow(IntPtr hWnd, int nCmdShow);

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
                if (theProcess.MainWindowTitle != "" && theProcess.MainWindowTitle != "Space")
                {
                    artOfficial++;
                }
            }

            if (artOfficial != currentCountProc)
            {
                appGrid.Children.Clear();
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
                                    System.Windows.Controls.Image hmGreatJobFantasticAmazing = new System.Windows.Controls.Image(); // My goodness, these old variable names are horrifying.
                                    StringBuilder sb = new StringBuilder(GetWindowTextLength(h) + 1);
                                    GetWindowText(h, sb, sb.Capacity);
                                    
                                    hmGreatJobFantasticAmazing.Visibility = Visibility.Visible;
                                    hmGreatJobFantasticAmazing.Stretch = Stretch.Fill;
                                    //hmGreatJobFantasticAmazing.BackgroundImageLayout = ImageLayout.Zoom;

                                    //System.Drawing.Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();

                                    //ImageFactory grayify = new ImageFactory();
                                    //grayify.Load(@"C:\ProjectSnowshoes\temptaskico.png");
                                    //Size sizeeeee = new System.Drawing.Size();
                                    //sizeeeee.Height = 20;
                                    //sizeeeee.Width = 20;
                                    //ImageProcessor.Imaging.ResizeLayer reLay = new ImageProcessor.Imaging.ResizeLayer(sizeeeee);
                                    //grayify.Resize(reLay);
                                    
                                    BitmapImage bimg = new BitmapImage(new Uri(@"C:\ProjectSnowshoes\temptaskico.png"));
                                    //bimg = System.Drawing.Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName);
                                    hmGreatJobFantasticAmazing.Source = bimg;
                                    hmGreatJobFantasticAmazing.MouseUp += (sender, args) =>
                                    {

                                        ShowWindow(theProcess.MainWindowHandle, 5);
                                        ShowWindow(theProcess.MainWindowHandle, 9);
                                    };
                                    //hmGreatJobFantasticAmazing.MouseHover += (sender, args) =>
                                    //{
                                    //    Properties.Settings.Default.stayHere = true;
                                    //    Properties.Settings.Default.Save();
                                    //    int recordNao = hmGreatJobFantasticAmazing.Left;

                                    //    hmGreatJobFantasticAmazing.Image.Save(@"C:\ProjectSnowshoes\TheyNeedToKeepOriginalAlbums.png");
                                    //    Size sizeeeeeA = new System.Drawing.Size();
                                    //    sizeeeeeA.Height = 100;
                                    //    sizeeeeeA.Width = 100;
                                    //    ImageProcessor.Imaging.ResizeLayer reLayA = new ImageProcessor.Imaging.ResizeLayer(sizeeeeeA);
                                    //    ImageProcessor.Imaging.GaussianLayer gauLay = new ImageProcessor.Imaging.GaussianLayer();
                                    //    gauLay.Sigma = 2;
                                    //    gauLay.Threshold = 10;
                                    //    gauLay.Size = 20;
                                    //    ImageFactory backify = new ImageFactory();
                                    //    backify.Load(@"C:\ProjectSnowshoes\TheyNeedToKeepOriginalAlbums.png");
                                    //    backify.Brightness(-30);
                                    //    backify.Resize(reLayA);
                                    //    backify.GaussianBlur(gauLay);
                                    //    ImageProcessor.Imaging.CropLayer notAsLongAsOriginalName = new ImageProcessor.Imaging.CropLayer(90, 0, 0, 0, ImageProcessor.Imaging.CropMode.Percentage);
                                    //    backify.Crop(new Rectangle(25, (100 - this.Height) / 2, 50, this.Height));
                                    //    hmGreatJobFantasticAmazing.BackgroundImage = backify.Image;
                                    //    grayify.Save(@"C:\ProjectSnowshoes\TheyStillNeedToKeepOriginalAlbums.png");
                                    //    ImageFactory grayifyA = new ImageFactory();
                                    //    grayifyA.Load(@"C:\ProjectSnowshoes\TheyStillNeedToKeepOriginalAlbums.png");
                                    //    grayifyA.Saturation(44);
                                    //    grayifyA.Brightness(42);
                                    //    hmGreatJobFantasticAmazing.Image = grayifyA.Image;
                                    //    // Yeahhhhhhhhh I'm going to have to do this another way
                                    //    // panel1.Controls.Add(areYouSeriouslyStillDoingThisLetItGo);
                                    //    // Oh
                                    //    // I can just make another form to draw over and go have turnips with parameters
                                    //    // Also credits to Microsoft Word's "Sentence Case" option as this came out in all caps originally
                                    //    // Measuring string turnt-up-edness was guided by an answer on Stack Overflow by Tom Anderson.
                                    //    String keepThisShortWeNeedToOptimize = sb.ToString().Replace("&", "&&");
                                    //    Graphics heyGuessWhatGraphicsYeahThatsRight = Graphics.FromImage(new Bitmap(1, 1));
                                    //    SizeF sure = heyGuessWhatGraphicsYeahThatsRight.MeasureString(keepThisShortWeNeedToOptimize, new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular, GraphicsUnit.Point));
                                    //    Size sureAgain = sure.ToSize();
                                    //    int recordThatJim;
                                    //    if (sureAgain.Width >= 300)
                                    //    {
                                    //        recordThatJim = sureAgain.Width + 10;
                                    //    }
                                    //    else
                                    //    {
                                    //        recordThatJim = 300;
                                    //    }

                                    //    CanWeMakeAHoverFormLikeThisIsThisLegal notAsLongInstanceName = new CanWeMakeAHoverFormLikeThisIsThisLegal(recordNao + 150, this.Height, recordThatJim, keepThisShortWeNeedToOptimize);
                                    //    notAsLongInstanceName.Show();
                                    //    notAsLongInstanceName.BringToFront();


                                    //    //hmGreatJobFantasticAmazing.BringToFront();
                                    //    //panel1.Controls.Add(hmGreatJobFantasticAmazing);
                                    //    //hmGreatJobFantasticAmazing.Top = this.Top - 40;
                                    //    //hmGreatJobFantasticAmazing.Left = recordNao + 150;
                                    //    //hmGreatJobFantasticAmazing.BringToFront();
                                    //    //hmGreatJobFantasticAmazing.Invalidate();
                                    //    /*hmGreatJobFantasticAmazing.Height = 100;
                                    //    hmGreatJobFantasticAmazing.Width = 100;*/
                                    //};
                                    //hmGreatJobFantasticAmazing.MouseLeave += (sender, args) =>
                                    //{
                                    //    /*hmGreatJobFantasticAmazing.ImageAlign = ContentAlignment.MiddleCenter;
                                    //    hmGreatJobFantasticAmazing.AutoEllipsis = false;
                                    //    hmGreatJobFantasticAmazing.Width = 40;
                                    //    hmGreatJobFantasticAmazing.BackColor = Color.Transparent;
                                    //    //hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                                    //    //hmGreatJobFantasticAmazing.ForeColor = Color.White;
                                    //    hmGreatJobFantasticAmazing.TextAlign = ContentAlignment.MiddleLeft;
                                    //    hmGreatJobFantasticAmazing.Text = "";*/
                                    //    try
                                    //    {
                                    //        Application.OpenForms["CanWeMakeAHoverFormLikeThisIsThisLegal"].Close();
                                    //    }
                                    //    catch (Exception exTurnip) { }
                                    //    hmGreatJobFantasticAmazing.BackgroundImage = null;
                                    //    hmGreatJobFantasticAmazing.Invalidate();
                                    //    Properties.Settings.Default.stayHere = false;
                                    //    Properties.Settings.Default.Save();
                                    //    hmGreatJobFantasticAmazing.Image = grayify.Image;
                                    //};
                                    //openFileToolTip.SetToolTip(hmGreatJobFantasticAmazing, theProcess.MainWindowTitle);
                                    //hmGreatJobFantasticAmazing.BackgroundImage = Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();
                                    hmGreatJobFantasticAmazing.Height = 12; // or this.height
                                    hmGreatJobFantasticAmazing.Width = 12;
                                    appGrid.Children.Add(hmGreatJobFantasticAmazing);
                                }
                            }
                        }

                    }
                    procCount++;
                }

            }

            currentCountProc = artOfficial;


        }
    }
}
