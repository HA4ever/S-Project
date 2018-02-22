using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using Coding4Fun.Kinect.WinForm;

namespace Measurement_System
{
    public partial class KinectSystem : Form
    {
        private KinectSensor KSensor;
        public KinectSystem()
        {
            InitializeComponent();
            
    }

        private void KinectSystem_Load(object sender, EventArgs e)
        {




            if (KinectSensor.KinectSensors.Count > 0)
            {

                KSensor = KinectSensor.KinectSensors[0];
              
                

            }

            Skeleton[] skeletons = new Skeleton[0];

           // KSensor.SkeletonStream.Enable();
          //  KSensor.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(KSensor_SkeletonFrameReady);
            KinectSensor.KinectSensors.FirstOrDefault(s => s.Status == KinectStatus.Connected);
          //  KSensor.DepthStream.Range = DepthRange.Near; // Depth in near range enabled
            //KSensor.SkeletonStream.EnableTrackingInNearRange = true; // enable returning skeletons while depth is in Near Range


            KSensor.Start();
            KSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
            KSensor.ColorFrameReady += KSensor_ColorFrameReady;



        }
        private void KSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var Frame = e.OpenColorImageFrame())
            {
                CameraStream.Image = CreateBitmapFromSensor(Frame);

            }

        }

        private Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
        {
            var pixelData = new byte[frame.PixelDataLength];
            frame.CopyPixelDataTo(pixelData);

            return pixelData.ToBitmap(frame.Width, frame.Height);


        }

        private void BACK_Click(object sender, EventArgs e)
        {
            KSensor.Dispose();
            this.Hide();
            UserMain1 UM = new UserMain1();
            UM.Show();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            KSensor.Dispose();
            this.Hide();
            UserMain2 us = new UserMain2();
            us.Show();
        }
    }
}
