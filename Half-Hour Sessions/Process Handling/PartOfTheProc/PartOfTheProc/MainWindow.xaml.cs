using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
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
                spaceForProcesses.Controls.Clear();
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
                                    PictureBox hmGreatJobFantasticAmazing = new PictureBox();
                                    StringBuilder sb = new StringBuilder(GetWindowTextLength(h) + 1);
                                    GetWindowText(h, sb, sb.Capacity);




                                    hmGreatJobFantasticAmazing.Margin = new Padding(6, 0, 6, 0);
                                    hmGreatJobFantasticAmazing.Visible = true;
                                    hmGreatJobFantasticAmazing.SizeMode = PictureBoxSizeMode.CenterImage;
                                    hmGreatJobFantasticAmazing.BackgroundImageLayout = ImageLayout.Zoom;

                                    Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap().Save(@"C:\ProjectSnowshoes\temptaskico.png");

                                    ImageFactory grayify = new ImageFactory();
                                    grayify.Load(@"C:\ProjectSnowshoes\temptaskico.png");
                                    Size sizeeeee = new System.Drawing.Size();
                                    sizeeeee.Height = 20;
                                    sizeeeee.Width = 20;
                                    ImageProcessor.Imaging.ResizeLayer reLay = new ImageProcessor.Imaging.ResizeLayer(sizeeeee);
                                    grayify.Resize(reLay);

                                    hmGreatJobFantasticAmazing.Image = grayify.Image;
                                    hmGreatJobFantasticAmazing.Click += (sender, args) =>
                                    {

                                        ShowWindow(theProcess.MainWindowHandle, 5);
                                        ShowWindow(theProcess.MainWindowHandle, 9);
                                    };
                                    hmGreatJobFantasticAmazing.MouseHover += (sender, args) =>
                                    {
                                        Properties.Settings.Default.stayHere = true;
                                        Properties.Settings.Default.Save();
                                        int recordNao = hmGreatJobFantasticAmazing.Left;

                                        hmGreatJobFantasticAmazing.Image.Save(@"C:\ProjectSnowshoes\TheyNeedToKeepOriginalAlbums.png");
                                        Size sizeeeeeA = new System.Drawing.Size();
                                        sizeeeeeA.Height = 100;
                                        sizeeeeeA.Width = 100;
                                        ImageProcessor.Imaging.ResizeLayer reLayA = new ImageProcessor.Imaging.ResizeLayer(sizeeeeeA);
                                        ImageProcessor.Imaging.GaussianLayer gauLay = new ImageProcessor.Imaging.GaussianLayer();
                                        gauLay.Sigma = 2;
                                        gauLay.Threshold = 10;
                                        gauLay.Size = 20;
                                        ImageFactory backify = new ImageFactory();
                                        backify.Load(@"C:\ProjectSnowshoes\TheyNeedToKeepOriginalAlbums.png");
                                        backify.Brightness(-30);
                                        backify.Resize(reLayA);
                                        backify.GaussianBlur(gauLay);
                                        ImageProcessor.Imaging.CropLayer notAsLongAsOriginalName = new ImageProcessor.Imaging.CropLayer(90, 0, 0, 0, ImageProcessor.Imaging.CropMode.Percentage);
                                        backify.Crop(new Rectangle(25, (100 - this.Height) / 2, 50, this.Height));
                                        hmGreatJobFantasticAmazing.BackgroundImage = backify.Image;
                                        grayify.Save(@"C:\ProjectSnowshoes\TheyStillNeedToKeepOriginalAlbums.png");
                                        ImageFactory grayifyA = new ImageFactory();
                                        grayifyA.Load(@"C:\ProjectSnowshoes\TheyStillNeedToKeepOriginalAlbums.png");
                                        grayifyA.Saturation(44);
                                        grayifyA.Brightness(42);
                                        hmGreatJobFantasticAmazing.Image = grayifyA.Image;
                                        // Yeahhhhhhhhh I'm going to have to do this another way
                                        // panel1.Controls.Add(areYouSeriouslyStillDoingThisLetItGo);
                                        // Oh
                                        // I can just make another form to draw over and go have turnips with parameters
                                        // Also credits to Microsoft Word's "Sentence Case" option as this came out in all caps originally
                                        // Measuring string turnt-up-edness was guided by an answer on Stack Overflow by Tom Anderson.
                                        String keepThisShortWeNeedToOptimize = sb.ToString().Replace("&", "&&");
                                        Graphics heyGuessWhatGraphicsYeahThatsRight = Graphics.FromImage(new Bitmap(1, 1));
                                        SizeF sure = heyGuessWhatGraphicsYeahThatsRight.MeasureString(keepThisShortWeNeedToOptimize, new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular, GraphicsUnit.Point));
                                        Size sureAgain = sure.ToSize();
                                        int recordThatJim;
                                        if (sureAgain.Width >= 300)
                                        {
                                            recordThatJim = sureAgain.Width + 10;
                                        }
                                        else
                                        {
                                            recordThatJim = 300;
                                        }
                                        CanWeMakeAHoverFormLikeThisIsThisLegal notAsLongInstanceName = new CanWeMakeAHoverFormLikeThisIsThisLegal(recordNao + 150, this.Height, recordThatJim, keepThisShortWeNeedToOptimize);
                                        notAsLongInstanceName.Show();
                                        notAsLongInstanceName.BringToFront();
                                        //hmGreatJobFantasticAmazing.BringToFront();
                                        //panel1.Controls.Add(hmGreatJobFantasticAmazing);
                                        //hmGreatJobFantasticAmazing.Top = this.Top - 40;
                                        //hmGreatJobFantasticAmazing.Left = recordNao + 150;
                                        //hmGreatJobFantasticAmazing.BringToFront();
                                        //hmGreatJobFantasticAmazing.Invalidate();
                                        /*hmGreatJobFantasticAmazing.Height = 100;
                                        hmGreatJobFantasticAmazing.Width = 100;*/
                                    };
                                    hmGreatJobFantasticAmazing.MouseLeave += (sender, args) =>
                                    {
                                        /*hmGreatJobFantasticAmazing.ImageAlign = ContentAlignment.MiddleCenter;
                                        hmGreatJobFantasticAmazing.AutoEllipsis = false;
                                        hmGreatJobFantasticAmazing.Width = 40;
                                        hmGreatJobFantasticAmazing.BackColor = Color.Transparent;
                                        //hmGreatJobFantasticAmazing.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 14, FontStyle.Regular);
                                        //hmGreatJobFantasticAmazing.ForeColor = Color.White;
                                        hmGreatJobFantasticAmazing.TextAlign = ContentAlignment.MiddleLeft;
                                        hmGreatJobFantasticAmazing.Text = "";*/
                                        try
                                        {
                                            Application.OpenForms["CanWeMakeAHoverFormLikeThisIsThisLegal"].Close();
                                        }
                                        catch (Exception exTurnip) { }
                                        hmGreatJobFantasticAmazing.BackgroundImage = null;
                                        hmGreatJobFantasticAmazing.Invalidate();
                                        Properties.Settings.Default.stayHere = false;
                                        Properties.Settings.Default.Save();
                                        hmGreatJobFantasticAmazing.Image = grayify.Image;
                                    };
                                    //openFileToolTip.SetToolTip(hmGreatJobFantasticAmazing, theProcess.MainWindowTitle);
                                    //hmGreatJobFantasticAmazing.BackgroundImage = Icon.ExtractAssociatedIcon(theProcess.Modules[0].FileName).ToBitmap();
                                    hmGreatJobFantasticAmazing.Height = this.Height;
                                    hmGreatJobFantasticAmazing.Width = 50;
                                    spaceForProcesses.Controls.Add(hmGreatJobFantasticAmazing);
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

