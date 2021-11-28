using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangQuanAo.DAO
{
    class Sound
    {
        private static Sound instance;

        public static Sound Instance
        {
            get { if (instance == null) instance = new Sound(); return instance; }
            private set => instance = value;
        }
        public void sound_Click()
        {
            using (var soundPlayer = new SoundPlayer(@"..\..\Resources\ES_Switch Click 1 - SFX Producer.wav"))
            {
                soundPlayer.Play();
            }
        }

        internal void tada()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\Media\tada.wav"))
            {
                soundPlayer.PlaySync();
                
                
            }
        }
        internal void cancel()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav"))
            {
                soundPlayer.PlaySync();
            }
        }
    }
}
