
using Emgu.CV;
using Emgu.CV.Structure;
using RBot.Classes;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class fmMain : Form
    {
        fmFrame frame;
        public fmMain()
        {
            InitializeComponent();
            Params.SetDefaults();
            frame = new fmFrame();
            frame.Show();

            //trackBar1.DataBindings.Add(new Binding("Value", typeof(Parameters), "Edge_Th1"));

        }
        bool running = false;



        private void btnStop_Click(object sender, EventArgs e)
        {
            running = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            running = true;
            Task t = new Task(() =>
            {
                VideoCapture camera = new VideoCapture();
                while (running)
                {
                    DateTime dtStart = DateTime.Now;

                    Rectangle rec = new Rectangle(frame.DesktopLocation, new Size(imgBox.Width, imgBox.Height));
                    var bmpScreenshot = new Bitmap(rec.Width, rec.Height);
                    var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                    gfxScreenshot.CopyFromScreen(rec.Left, rec.Top, 0, 0, rec.Size, CopyPixelOperation.SourceCopy);

                    try
                    {
                        //var camera = OpenCV.Net.Capture.CreateCameraCapture(0);
                        Image<Bgr, Byte> imgScreen = new Image<Bgr, Byte>(bmpScreenshot);
                       

                        var videoImg = camera.QueryFrame().ToImage<Bgr, Byte>();

                        ProcessImage(videoImg);


                        Tuple<int, int> th = new Tuple<int, int>((int)tbEdge_1.GetPropertyThreadSafe("Value"), (int)tbEdge_2.GetPropertyThreadSafe("Value"));
                        lblInfo.SetPropertyThreadSafe("Text", string.Format("Size:{0}x{1}; {2:0.000} sec. {3}/{4}",
                         imgBox.Width, imgBox.Height, (DateTime.Now - dtStart).TotalSeconds,
                         th.Item1, th.Item2));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            });
            t.Start();
        }

        void ProcessImage(Image<Bgr, Byte> image)
        {
            Tuple<int, int> th = new Tuple<int, int>((int)tbEdge_1.GetPropertyThreadSafe("Value"), (int)tbEdge_2.GetPropertyThreadSafe("Value"));
            //125/240

            Image<Gray, Byte> imgEdges = image.Canny(th.Item1, th.Item2);

            //var cudaEdge = new CudaCannyEdgeDetector(100, 300);
            //cudaEdge.Detect(img, img2);
            Image<Gray, Byte> blurred = imgEdges.CopyBlank() ;
            CvInvoke.GaussianBlur(imgEdges, blurred, new Size(5, 5), 1.5, 1);

            Tuple<double, double> th_line = new Tuple<double, double>((int)tbMinLineLen.GetPropertyThreadSafe("Value"), (int)tbMaxLineGap.GetPropertyThreadSafe("Value"));
            var lines = CvInvoke.HoughLinesP(blurred, (int)tbMinLineLen.GetPropertyThreadSafe("Value") / 10, Params.Line_Theta, Params.Line_Thresh, th_line.Item1, th_line.Item2);

            var imgOut = image.CopyBlank();
            DrawLines(image, lines);
            imgBox.Image = imgOut;

            //if (tShow == null || tShow.Status != TaskStatus.Running)
            //{
            //    tShow = new Task(() => ShowImageOutput(new[] {
            //       // new Tuple<string, IImage>("Image", image),
            //       // new Tuple<string, IImage>("edges", imgEdges)
            //    }));
            //    tShow.Start();
            //}
        }
        Task tShow;

        static void ShowImageOutput(Tuple<string, IImage>[] images) 
        {
            foreach (var tuple in images)
            {
                CvInvoke.Imshow(tuple.Item1, tuple.Item2);
            }
            Thread.Sleep(1000);
        }

        void DrawLines(IImage image, LineSegment2D[] lines)
        {
            foreach (LineSegment2D line in lines)
            {
                CvInvoke.Line(image, line.P1, line.P2, new Bgr(Color.Green).MCvScalar, 2);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCapture camera = new VideoCapture();
            var videoImg = camera.QueryFrame().ToImage<Bgr, Byte>();
            CvInvoke.Imshow("Image", videoImg);
        }
    }
}
