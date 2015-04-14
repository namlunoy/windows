using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SepateSpriteSheet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        unsafe
        private void Click_CUT(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(path.Text);
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);

            int bb = bitmap.PixelFormat == PixelFormat.Format24bppRgb ? 3 : 4;

            int pWidth = int.Parse(p_width.Text);
            int pHeight = int.Parse(p_height.Text);

            int n_W = bitmap.Width / pWidth;
            int n_H = bitmap.Height / pHeight;
            int stt = 0 ;
            for (int i = 0; i < n_H; i++)
            {
                for (int j = 0; j < n_W; j++)
                {
                    stt++;
                    string fileName = "test" + stt.ToString() + ".png";
                    Bitmap newImage = new Bitmap(pWidth, pHeight, PixelFormat.Format32bppArgb);
                    BitmapData newData = newImage.LockBits(new Rectangle(0, 0, pWidth, pHeight), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                    //Copy
                    int hang_start = i * pHeight;
                    int hang_end = hang_start + pHeight;
                    int cot_start = j * pWidth;
                    int cot_end = cot_start + pWidth;
                    byte* p1 =(byte*) bmData.Scan0;
                    byte* p2 = (byte*)newData.Scan0;
                    int stride = bmData.Stride;
                    int index_1, index_2 = 0;
                    for (int hang = hang_start; hang < hang_end; hang++)
                    {
                        for (int cot = cot_start; cot < cot_end; cot++)
                        {
                            index_1 = hang * stride + cot * bb;

                            if (bb == 3)
                            {
                                p2[index_2 + 0] = 0;
                                p2[index_2 + 1] = p1[index_1 + 0];
                                p2[index_2 + 2] = p1[index_1 + 1];
                                p2[index_2 + 3] = p1[index_1 + 2];
                            }
                            else
                            {
                                p2[index_2 + 0] = p1[index_1 + 0];
                                p2[index_2 + 1] = p1[index_1 + 1];
                                p2[index_2 + 2] = p1[index_1 + 2];
                                p2[index_2 + 3] = p1[index_1 + 3];
                            }

                            index_2 += 4;
                        }
                    }
                    newImage.UnlockBits(newData);
                    newImage.Save(fileName);
                   // bitmap.
                }
            }
            bitmap.UnlockBits(bmData);
        }
    }
}
