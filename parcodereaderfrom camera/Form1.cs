using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using ZXing;
using System.Threading;
//using functioneissasql;
using System.Data.SqlClient;



namespace parcodereaderfrom_camera
{
    public partial class Form1 : Form
    {
        //functioneissa eissa = new functioneissa();

        private VideoCaptureDevice finalframe;
        private FilterInfoCollection capturedevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /////////////



            //////// the camera frame
            capturedevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in capturedevice)
            {
                comboBoxCameras.Items.Add(device.Name);
                comboBoxCameras.SelectedIndex = 0;
                finalframe = new VideoCaptureDevice();


                ////////////////start

                finalframe = new VideoCaptureDevice(capturedevice[comboBoxCameras.SelectedIndex].MonikerString);
                finalframe.NewFrame += finalframe_NewFrame;
                finalframe.Start();
                //////////////////////////


               
                
            }

        }
        void finalframe_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Image)eventArgs.Frame.Clone();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finalframe.IsRunning == true)
            {
                finalframe.SignalToStop();
                finalframe.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                capturedevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);


                if (pictureBox2.Image != null)
                {
                    pictureBox1.Image = (Image)pictureBox2.Image.Clone();
                }
                else
                {
                    MessageBox.Show("check the camera");
                }


                ////////////////////


                IBarcodeReader reader = new BarcodeReader();
                // load a bitmap
                var barcodeBitmap = (Bitmap)pictureBox1.Image;
                // detect and decode the barcode inside the bitmap
                var result = reader.Decode(barcodeBitmap);
                // do something with the result
                if (result != null)
                {
                    txtDecoderType.Text = result.BarcodeFormat.ToString();
                    txtDecoderContent.Text = result.Text;
                Console.Beep();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var content = "6221032111111";
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.EAN_13,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 100,
                    Width = 200,
                    Margin = 2
                }
                

            };
            pictureBox1.Image = writer.Write(content);
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            //MemoryStream mem = new MemoryStream();
            //pictureBox3.Image.Save(mem,ImageFormat.Jpeg);
            //byte[] image = mem.ToArray();

            ////eissa.InitiatConnection("barcode");
            //string sql = "insert into barcode(barcode,photo)values(@barcode,@photo)";
            ////SqlCommand cmd = new SqlCommand(sql,eissa.conn);
            //cmd.Parameters.AddWithValue("@barcode",txtDecoderContent.Text);
            //cmd.Parameters.AddWithValue("@photo",image);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("added");
        }

        private void brousebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            op.ShowDialog();
            pictureBox3.Image = Image.FromFile(op.FileName);
        }

        private void txtDecoderContent_TextChanged(object sender, EventArgs e)
        {
            ///////retreive image
            //eissa.InitiatConnection("barcode");
            //string sql = "select photo from barcode where barcode like'%"+txtDecoderContent.Text+"%'";
            //SqlCommand cmd = new SqlCommand(sql, eissa.conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    pictureBox3.Image = Image.FromStream(new MemoryStream((byte[])dr.GetValue(0)));
            //}
        }
    }
}
