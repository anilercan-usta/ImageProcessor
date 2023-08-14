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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;
using System.Linq.Expressions;
using System.Data.SqlTypes;

namespace ImageProcessor
{
    public class Coordinate
    {
        public double x { get; set; }
        public double y { get; set; }
        public double width { get; set; }
        public double height { get; set; }
    }

    public class Annotation
    {
        public string label { get; set; }
        public Coordinate coordinates { get; set; }
    }

    public class JsonData
    {
        public string image { get; set; }
        public List<Annotation> annotations { get; set; }
    }


    public partial class MainForm : Form
    {
        private List<string> ProcessedList;
        private List<string> WorkList;
        private string WorkFolder;
        private string CurrentFileName;

        private Image Source;
        private Image SourceMini;
        private int Angle;

        public MainForm()
        {
            InitializeComponent();
        }

        public Image RotateImage(Image img, float angle)
        {
            double radian = angle * Math.PI / 180;
            double cos = Math.Abs(Math.Cos(radian));
            double sin = Math.Abs(Math.Sin(radian));
            int newWidth = (int)(img.Width * cos + img.Height * sin);
            int newHeight = (int)(img.Width * sin + img.Height * cos);


            Bitmap bmp = new Bitmap(newWidth, newHeight);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(newWidth / 2, newHeight / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);
                g.DrawImage(img, new Point(0, 0));
            }

            return bmp;
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            // Get the image current width
            int sourceWidth = imgToResize.Width;
            // Get the image current height
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            // Calculate width and height with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return b;
        }

        private RotateFlipType GetRotationFromExifOrientation(int orientation)
        {
            switch (orientation)
            {
                case 1:
                    return RotateFlipType.RotateNoneFlipNone;
                case 3:
                    return RotateFlipType.Rotate180FlipNone;
                case 6:
                    return RotateFlipType.Rotate90FlipNone;
                case 8:
                    return RotateFlipType.Rotate270FlipNone;
                default:
                    return RotateFlipType.RotateNoneFlipNone;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderName.Text = dialog.SelectedPath;
            }
    
            WorkFolder = txtFolderName.Text;

            if (!System.IO.Directory.Exists(WorkFolder))
            {
                MessageBox.Show("Folder Not Found");
                return;
            }
            if (!System.IO.Directory.Exists(Path.Combine(WorkFolder, "Original")))
            {
                MessageBox.Show("Folder  -Original- Not Found");
                return;
            }



            Directory.CreateDirectory(Path.Combine(WorkFolder, "Processed"));
            Directory.CreateDirectory(Path.Combine(WorkFolder, "Deleted"));

            WorkList = Directory.GetFiles(Path.Combine(WorkFolder, "Original")).Select(s=> Path.GetFileName(s)).ToList<string>();
            ProcessedList = Directory.GetFiles(Path.Combine(WorkFolder, "Processed")).Select(s => Path.GetFileName(s)).ToList<string>();
            WorkList.RemoveAll(q => ProcessedList.Contains(q));

            ProcessNext();
        }

        private void ProcessNext()
        {
            if (WorkList.Count > 0)
                ProcessFile(Path.Combine(WorkFolder, "Original", WorkList.First()));
            else
                MessageBox.Show("Completed");
        }

        private void ProcessFile(string sourcefile)
        {
            CurrentFileName = Path.GetFileName(sourcefile);
            tbAngleSelector.Value = 0;
            Source = Image.FromFile(sourcefile);

            int orientationValue = 1;

            try
            {
                orientationValue = Source.GetPropertyItem(0x0112).Value[0];
            }
            catch {}
            RotateFlipType rotation = GetRotationFromExifOrientation(orientationValue);
            Source.RotateFlip(rotation);

            SourceMini = ResizeImage(Source, new Size(400, 400));
            pbSource.Image = SourceMini;
            pbTarget.Image = SourceMini;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var target = RotateImage(Source, Angle);
            var targetfilename = Path.Combine(WorkFolder, "Processed", CurrentFileName);
            target.Save(targetfilename, ImageFormat.Png);

            var dataFile = Path.Combine(WorkFolder, "data.txt");
            using (StreamWriter writer = File.AppendText(dataFile))
            {

                writer.WriteLine(CurrentFileName + ";" + Angle.ToString()); // Write the new line of text
            }

            WorkList.Remove(CurrentFileName);
            ProcessNext();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            tbAngleSelector.Value = tbAngleSelector.Value -1;
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            tbAngleSelector.Value = tbAngleSelector.Value + 1;
        }

        private void tbAngleSelector_ValueChanged(object sender, EventArgs e)
        {
            Angle = tbAngleSelector.Value;
            lblAngle.Text = Angle.ToString();
            pbTarget.Image = RotateImage(SourceMini, Angle);
        }

        private void btnIncrementLarge_Click(object sender, EventArgs e)
        {
            tbAngleSelector.Value = tbAngleSelector.Value + 10;
        }

        private void btnDecrementLarge_Click(object sender, EventArgs e)
        {
            tbAngleSelector.Value = tbAngleSelector.Value - 10;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Source.Dispose();

            var s = Path.Combine(WorkFolder, "Original", CurrentFileName);
            var d = Path.Combine(WorkFolder, "Deleted", CurrentFileName);

            File.Move(s, d);
            WorkList.Remove(CurrentFileName);
            ProcessNext();
        }
        
        


        private void cropImages(string jsonContents, string image_input_folder_path, string cropped_sayac_folder_path, string cropped_endeks_folder_path )
        {
            
            
            try
            {
                // Parse the JSON array into a List<JsonData>
                List<JsonData> dataList = JsonConvert.DeserializeObject<List<JsonData>>(jsonContents);


                Console.WriteLine("length: " + dataList.Count());

                
                string image_output_folder_path = "";
                foreach (var item in dataList)
                {
                    Console.WriteLine("Image: " + item.image);
                    Console.WriteLine(Path.Combine(image_input_folder_path, item.image));

                    string image_name = item.image;
                    int index = image_name.IndexOf("_jpeg");
                    string modifiedString = image_name.Substring(0, index) + ".jpeg";

                    



                    using (Image img = Image.FromFile(Path.Combine(image_input_folder_path, modifiedString)))
                    {
                        bool sayac_cropped= false;
                        bool endeks_cropped = false;
                        
                        foreach (var annotation in item.annotations)
                        {
                                if (sayac_cropped && endeks_cropped) break;
                            
                                

                                int x = (int) annotation.coordinates.x;
                                int y = (int) annotation.coordinates.y;
                                int width = (int) annotation.coordinates.width;
                                int height = (int) annotation.coordinates.height;


                                Console.WriteLine("Label: " + annotation.label);
                                Console.WriteLine("Coordinates: X=" + annotation.coordinates.x +
                                                  " Y=" + annotation.coordinates.y +
                                                  " Width=" + annotation.coordinates.width +
                                                  " Height=" + annotation.coordinates.height);


                                int left = x - (width / 2);
                                int top = y - (height / 2);

                                // Define the cropping rectangle
                                Rectangle cropRect = new Rectangle(left, top, width, height);

                                // Create a new bitmap to hold the cropped image
                                using (Bitmap croppedBitmap = new Bitmap(cropRect.Width, cropRect.Height))
                                {
                                    // Copy the specified portion of the original image to the new bitmap
                                    using (Graphics graphics = Graphics.FromImage(croppedBitmap))
                                    {
                                        graphics.DrawImage(img, new Rectangle(0, 0, croppedBitmap.Width, croppedBitmap.Height), cropRect, GraphicsUnit.Pixel);
                                    }

                                // Save the cropped image (replace "output.jpg" with the desired output path)
                                if( string.Equals(annotation.label, "sayac", StringComparison.Ordinal) && !sayac_cropped )
                                {
                                        image_output_folder_path = cropped_sayac_folder_path;
                                        sayac_cropped = true;
                                }
                                else if(string.Equals(annotation.label, "endeks", StringComparison.Ordinal) && !endeks_cropped)
                                {
                                    image_output_folder_path = cropped_endeks_folder_path;
                                    endeks_cropped = true;

                                }
                                else
                                {
                                    break;
                                }
                                string outputPath = Path.Combine(image_output_folder_path, modifiedString);
                                
                                /*
                                if (File.Exists(outputPath))
                                {
                                    try
                                    {
                                        File.Delete(outputPath);
                                        Console.WriteLine("Existing file deleted: " + outputPath);
                                    }
                                    catch (IOException ex)
                                    {
                                        // Handle the case where the file cannot be deleted, if necessary
                                        Console.WriteLine("Error deleting existing file: " + ex.Message);
                                        continue;
                                    }
                                }
                                */

                                croppedBitmap.Save(outputPath, ImageFormat.Png);

                                Console.WriteLine("Image cropped and saved.");
                                }
                            

                            


                        }
                        
                        img.Dispose();
                    
                    }
                   
                    
                }
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        private void btnCrop_Click(object sender, EventArgs e)
        {
            

            string working_directory_path = "";
            string input_images_path = "";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                working_directory_path = dialog.SelectedPath;
            }

            FolderBrowserDialog dialog2 = new FolderBrowserDialog();
            if (dialog2.ShowDialog() == DialogResult.OK)
            {
                input_images_path = dialog2.SelectedPath;
            }

            //Console.WriteLine(input_images_path);

            string cropped_sayac_folder_path = Path.Combine(working_directory_path, "cropped_sayac");
            string cropped_endeks_folder_path = Path.Combine(working_directory_path, "cropped_endeks");

            Directory.CreateDirectory(cropped_sayac_folder_path);
            Directory.CreateDirectory(cropped_endeks_folder_path);

            //string image_input_folder_path = Path.Combine(working_directory_path, "train");
            Console.WriteLine(Path.Combine(working_directory_path, "train"));
            string[] jsonFiles_paths = Directory.GetFiles(Path.Combine(working_directory_path, "train"), "*.json");
            string jsonFile_path = jsonFiles_paths[0];

            /*
            Console.WriteLine(jsonFile_path);
            Console.WriteLine(image_input_folder_path);
            Console.WriteLine(cropped_sayac_folder_path);
            Console.WriteLine(cropped_endeks_folder_path);
            */

            string jsonContents = File.ReadAllText(jsonFile_path);


            cropImages(jsonContents, input_images_path, cropped_sayac_folder_path, cropped_endeks_folder_path);



        }
    }
}
