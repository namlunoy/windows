using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondBackground
{
    public class namlunoy
    {
        private static string file = "";
        public static List<String> getAllImages(String dir)
        {
            List<String> list = new List<String>();
            String[] allfiles = Directory.GetFiles(dir, "", SearchOption.AllDirectories);
            foreach (String file in allfiles)
            {
                if (file.Contains(".png") || file.Contains(".jpg"))
                    list.Add(file);
            }
            return list;
        }

        /// <summary>
        /// thực hiện nhiệm vụ, kiểm tra xem file config đã có chưa, nếu chưa có thì tạo ra 1 cái!
        /// </summary>
        public static void DoCheckFile()
        {

        }
    }
}
