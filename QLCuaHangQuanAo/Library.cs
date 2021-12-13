using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace QLCuaHangQuanAo
{
    public class Library
    {
        static public Image ConvertoImage(byte[] data)
        {
            if (data != null)
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            else
                return null;
        }

        static public byte[] ConvertoByte(Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Chưa có ảnh");
            }
            return null;
     
        }

        static public void LoadFromDialog(PictureBox picture)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(ofd.FileName);
            }
            picture.SizeMode = PictureBoxSizeMode.Zoom;
        }
        static SoundPlayer SoundPlayer;
        static public void sound_Click()
        {
            SoundPlayer = new SoundPlayer(@"..\..\Resources\ES_Switch Click 1 - SFX Producer.wav");
            SoundPlayer.Stop();
            SoundPlayer.Play();
        }
        static public void load_click()
        {
            SoundPlayer = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            SoundPlayer.Stop();
            SoundPlayer.Play();
        }
        static public void Noload_click()
        {
            SoundPlayer = new SoundPlayer(@"C:\Windows\Media\Windows Hardware Fail.wav");
            SoundPlayer.Stop();
            SoundPlayer.Play();

        }

        static public void tada()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\Media\tada.wav"))
            {
                soundPlayer.PlaySync();

            }
        }
        static public void cancel()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav"))
            {
                soundPlayer.PlaySync();
            }
        }
    }
}
