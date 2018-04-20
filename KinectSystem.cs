using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Kinect;
using Coding4Fun.Kinect.WinForm;
using System.Data.SqlClient;

namespace Measurement_System
{
    public partial class KinectSystem : Form
    {
        private KinectSensor KSensor;
        string username="";
        Skeleton[] skeletonData = new Skeleton[0];
       private static string Tsize = "";
        private static string Psize = "";


        public KinectSystem()
        {
             
            
    }
        public KinectSystem(string user)
        {
            InitializeComponent();
            username = user;

        }

        private void KinectSystem_Load(object sender, EventArgs e)
        {
            
            if (KinectSensor.KinectSensors.Count > 0)
            {

                KSensor = KinectSensor.KinectSensors[0];
               
            }
            
           
            KinectSensor.KinectSensors.FirstOrDefault(s => s.Status == KinectStatus.Connected);
            KSensor.Start();
            KSensor.SkeletonStream.Enable();
            KSensor.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(KSensor_SkeletonFrameReady);

            KSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
            KSensor.ColorFrameReady += KSensor_ColorFrameReady;



        }

        private void KSensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {    
            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame()) // Open the Skeleton frame
            {
                if (skeletonFrame != null || this.skeletonData != null) // check that a frame is available
                {
                    skeletonData = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(this.skeletonData); // get the skeletal information in this frame
                   
                    foreach (Skeleton skeleton in this.skeletonData)
                    {
                        
                        if (skeleton.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            KSensor.SkeletonStream.Disable();
                            Start(skeleton);
                        }

                    }

                }

            }

        }


        public static void Start(Skeleton skeleton)
        {

             
 
           
            var SR = skeleton.Joints[JointType.ShoulderRight];
            var SL = skeleton.Joints[JointType.ShoulderLeft];
            var hipLeft = skeleton.Joints[JointType.HipLeft];
            var hipRight = skeleton.Joints[JointType.HipRight];
            

            var TS = S_Width(SL, SR) + 0.12f;
            var PS = S_Width(hipLeft, hipRight)*2.5;


            if (TS >= 0.41 && TS <= 0.43)
            {
                Tsize = "SMALL";
            }
            else if (TS >= 0.43 && TS <= 0.45)
            {
                Tsize = "MEDIUM";
              

            }
            else if (TS >= 0.46 && TS <= 0.48)
            {
                Tsize = "LARGE";
                

            }
            else if (TS >= 0.49 && TS <= 0.51)
            {
                Tsize = "X-LARGE";
               

            }
            else if (TS >= 0.52 && TS <= 0.54)
            {
                Tsize = "XX-LARGE";
               

            }
            else if (TS >= 0.55 )
            {
                Tsize = "XXX-LARGE";
               

            }
            else { }


            ///////////////////////P-Size///////////////////////////////////////
            if (PS >= 0.31 && PS <= 0.36)
            {
                Psize = "SMALL";


            }
            else if (PS >= 0.38 && PS <= 0.42)
            {
                Psize = "MEDIUM";


            }
            else if (PS >= 0.43 && PS <= 0.46)
            {
                Psize = "LARGE";


            }
            else if (PS >= 0.47 && PS <= 0.50)
            {
                Psize = "X-LARGE";


            }
            else if (PS >= 0.51 && PS <= 0.54)
            {
                Psize = "XX-LARGE";


            }
            else if (PS >= 0.55)
            {
                Psize = "XXX-LARGE";
            }
            else {}

            if (!Psize.Equals("") && !Tsize.Equals(""))
            {
                MessageBox.Show("YOUR T-shirt Size : " + Tsize + "\n   YOUR Pants Size : " + Psize);
            }
            else { MessageBox.Show("Do the Sizing Agen"); }

           
           
           
        }


        private static double S_Width(Joint p1, Joint p2)
        {
            return Math.Sqrt(
                Math.Pow(p1.Position.X - p2.Position.X, 2) +
                Math.Pow(p1.Position.Y - p2.Position.Y, 2) +
                Math.Pow(p1.Position.Z - p2.Position.Z, 2)
                );
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
            byte []pixelData = new byte[0] ;
            try
            {
                pixelData = new byte[frame.PixelDataLength];
                frame.CopyPixelDataTo(pixelData);

                
            }catch(System.NullReferenceException) { }

            return pixelData.ToBitmap(frame.Width, frame.Height);
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            KSensor.Dispose();
            this.Hide();
            Choosing ch = new Choosing(username);
            ch.Show();
        }

        private void Done_Click(object sender, EventArgs e)
        {

            string connectionString;
            connectionString = "Data Source=AHC-5-2-2017\\sqlexpress;Initial Catalog=SProject;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand command = new SqlCommand("update emp  set [T-size] ='" + Tsize+ "' , [P-size] = '" + Psize + "'  where username = '" + username + "' ;", conn);

            command.ExecuteNonQuery();

            MessageBox.Show("Sizes added");

            KSensor.Dispose();
            this.Hide();
            UserMain2 us = new UserMain2(username);
            us.Show();
        }

        private void CameraStream_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
