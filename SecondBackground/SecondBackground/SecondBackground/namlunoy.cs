using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SecondBackground
{
    public class LocationAndSize
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Heigh { get; set; }
        public double Width { get; set; }
    }
    public class Config
    {
        public Config()
        {
            Directory = "";
            Time = 30;
            AutoResize = false;
        }
        public String Directory { get; set; }
        public int Time { get; set; }
        public bool AutoResize { get; set; }
        public LocationAndSize PosSize { get; set; }
    }

    public class namlunoy
    {

        public static Config config = null;
        private static string fileName = "config";
        public static List<String> images;
        public static List<String> GetImages(String dir)
        {
            images = new List<String>();
        
           // dir = Path.Combine(dir);
            String[] allfiles = Directory.GetFiles(dir);
            foreach (String file in allfiles)
            {
                if (file.EndsWith(".png") || file.EndsWith(".jpg") || file.EndsWith(".JPG") || file.EndsWith(".PNG"))
                    images.Add(file);
            }
            return images;
        }

        /// <summary>
        /// thực hiện nhiệm vụ, kiểm tra xem file config đã có chưa, nếu chưa có thì tạo ra 1 cái!
        /// </summary>
        public static void LoadConfigFile()
        {
            if (!File.Exists(fileName))
            {
                //Tạo file mới
                config = new Config();
                SaveConfig();
            }
            else
            {
                //Đọc dữ liệu ra config
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(fileName));
            }
        }

        public static void SaveConfig()
        {
            string text = JsonConvert.SerializeObject(config);
            File.WriteAllText(fileName, text);
        }
        private static int index = 0;
        public static Uri GetNextImage()
        {

            if ((index + 1) <= (images.Count - 1))
                index++;
            else
                index = 0;
            return new Uri(images[index]);
        }
    }
}
