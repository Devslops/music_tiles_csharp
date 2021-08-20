using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piano.Piano
{
    public class Tile
    {
        private NoteEnum note;
        public long executionTime { get; set; }


        public Tile(NoteEnum note)
        {
            this.note = note;
        }

        public Tile(NoteEnum note, long executionTime)
        {
            this.note = note;
            this.executionTime = executionTime;
        }

        public void PlaySound()
        {
            WaveOutEvent outputDevice = new WaveOutEvent();
            AudioFileReader audioFile = new AudioFileReader(@"Sounds/" + note + ".wav");
            outputDevice.Init(audioFile);
            outputDevice.Play();

        }
    }
}
