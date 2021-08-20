using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace piano.Piano
{
    public class MusicPiece
    {
        public String pieceName { get; set; }
        public List<Tile> tiles { get; set; }

        public MusicPiece() 
        {
            tiles = new List<Tile>();
        }
        public MusicPiece(String pieceName, List<Tile> tiles)
        {
            this.pieceName = pieceName;
            this.tiles = tiles;
        }

        public void PlayMusicPiece()
        {
            for(int i = 0; i < tiles.Count; i++)
            {
                int nextIndex = i + 1;
                long waitingTime = 0;
                if (nextIndex < tiles.Count)
                    waitingTime = tiles[nextIndex].executionTime - tiles[i].executionTime;
                tiles[i].PlaySound();
                Thread.Sleep(Convert.ToInt32(waitingTime));
            }
        }
    }
}
