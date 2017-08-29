using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }
    }
    public static class Params
    {
        /// <summary>
        /// Edge detection: Threshold 1
        /// </summary>
        public static int Edge_Th1 { get; set; }
        public static int Edge_Th2 { get; set; }


        /// <summary>
        /// Line detection: The resolution of the parameter r in pixels. We use 1 pixel.
        /// </summary>
        public static double Line_Rho { get; set; }

        /// <summary>
        ///Line detection: The resolution of the parameter θ in radians. We use 1 degree (CV_PI/180)
        /// </summary>
        public static double Line_Theta { get; set; }
        /// <summary>
        ///Line detection: The minimum number of intersections to "*detect*" a line
        /// </summary>
        public static int Line_Thresh { get; set; }
        /// <summary>
        ///Line detection:  The minimum number of points that can form a line. Lines with less than this number of points are disregarded.
        /// </summary>
        public static double Line_MinLength { get; set; }
        /// <summary>
        ///Line detection: The maximum gap between two points to be considered in the same line.
        /// </summary>
        public static double Line_MaxGap { get; set; }

        public static void SetDefaults()
        {
            Edge_Th1 = 100;
            Edge_Th2 = 200;


            Line_Rho = 1;
            Line_Theta = Math.PI / 180;//One degree.
            Line_Thresh = 100;
            Line_MinLength = 10;
            Line_MaxGap = 5;
        }

    }

}
