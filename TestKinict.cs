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


namespace WindowsFormsApp1
{
    public partial class K : Form
    {

        private KinectSensor KSensor;
        
        public K()
        {
            InitializeComponent();
        }

        private void lboConnectionID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e )
        {


            
            if (btnStream.Text == "Stream") {

                if (KinectSensor.KinectSensors.Count > 0) {

                    KSensor = KinectSensor.KinectSensors[0];
                    KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;


                }
                   
                Skeleton[] skeletons = new Skeleton[0];
                KSensor.Start();
                lboConnectionID.Text = KSensor.DeviceConnectionId;
                KSensor.SkeletonFrameReady +=new EventHandler<SkeletonFrameReadyEventArgs>(KSensor_SkeletonFrameReady);
                KSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                KSensor.ColorFrameReady += KSensor_ColorFrameReady;


            }
            else if (KSensor.IsRunning)
                {
                    KSensor.Stop();
                    this.pbstream = null;
                   
                }
            
        }

       

        int count = 0;
        

        private void KSensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            ++count;
            this.lboNumber.Text = ""+count;
        }

        private void KSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var Frame = e.OpenColorImageFrame())
            {
                pbstream.Image = CreateBitmapFromSensor(Frame);

            }

        }

        private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            this.lboStatus.Text = KSensor.Status.ToString();
        }

        private Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
        {
            var pixelData = new byte[frame.PixelDataLength];
            frame.CopyPixelDataTo(pixelData);

            return pixelData.ToBitmap(frame.Width, frame.Height);

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbstream_Click(object sender, EventArgs e)
        {

        }
    }
}
