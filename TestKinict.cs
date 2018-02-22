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
        List<Vector4> joints;
        
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

                KSensor.SkeletonStream.Enable();
                KSensor.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(KSensor_SkeletonFrameReady);
                KinectSensor.KinectSensors.FirstOrDefault(s => s.Status == KinectStatus.Connected);
                KSensor.DepthStream.Range = DepthRange.Near; // Depth in near range enabled
                KSensor.SkeletonStream.EnableTrackingInNearRange = true; // enable returning skeletons while depth is in Near Range
               
              
              KSensor.Start();
              KSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
              KSensor.ColorFrameReady += KSensor_ColorFrameReady;
           
                
                lboConnectionID.Text = KSensor.DeviceConnectionId;


            }
            else if (KSensor.IsRunning)
                {
                    KSensor.Stop();
                    this.pbstream = null;
                   
                }
            
        }

       

       
        private void KSensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {



          
          
            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame()) // Open the Skeleton frame
            {
             // get the skeletal information in this frame
                    if (KSensor.SkeletonStream.TrackingMode == SkeletonTrackingMode.Default)
                    {
                    int n = skeletonFrame.SkeletonArrayLength;
                    lboNumber.Text = "" + ++n;
                    
                }
                    else
                    {
                    int n = skeletonFrame.SkeletonArrayLength;
                    lboNumber.Text = "" + --n;
                }
                }
            




            joints = new List<Vector4>();

          
           
            Microsoft.Kinect.Skeleton[] x = {};
            //   Skeleton[] SDK = x;
            //Frame.CopySkeletonDataTo(SDK);





            //  foreach (Skeleton data in SDK)
            { 
                 //   if (data.TrackingState == SkeletonTrackingState.Tracked)
                    {


                       // int n = Frame.SkeletonArrayLength;
                      //  lboNumber.Text = "" + n;


                    }
                }
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

        //private Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
        //{
        //    var pixelData = new byte[frame.PixelDataLength];
        //    frame.CopyPixelDataTo(pixelData);
       
        //    return pixelData.ToBitmap(frame.Width, frame.Height);

            
        //}

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
