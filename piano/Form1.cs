using NAudio.Wave;
using piano.Helpers;
using piano.Piano;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piano
{
    public partial class Form1 : Form
    {
        private List<MusicPiece> musicPieces;
        private MusicPiece musicPiece;

        public Form1()
        {
            musicPiece = new MusicPiece();
            musicPieces = new List<MusicPiece>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Tile is pressed
        private void tile_Click(object sender, EventArgs e)
        {
            // Clicked tile
            Button btn = sender as Button;
            
            //Played note convertion to enum
            NoteEnum playedNote = PianoHelper.StringNoteToEnum(btn.Text);

            //Get execution time for replay
            long executionTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Tile playedTile = new Tile(note: playedNote, executionTime: executionTime);
            PlayAndRecordSound(playedTile);

        }

        //Play sound and record
        private void PlayAndRecordSound(Tile playedTile)
        {
            //Play sound
            playedTile.PlaySound();

            //If Recording, add tile to music piece
            if (musicPiece != null) musicPiece.tiles.Add(playedTile);
        }

        //Manage record button
        private void btn_register_Click(object sender, EventArgs e)
        {
            Button registerButton = sender as Button;
            if (registerButton.Text == "start")
            {
                musicPiece = new MusicPiece();
                registerButton.Text = "stop";
            } else
            {
                if(musicPiece.tiles.Count > 0)
                {
                    String musicName = tb_musicname.Text;
                    if (!String.IsNullOrEmpty(musicName))
                    {
                        int pieceIndex = musicPieces.Count > 0 ? musicPieces.FindIndex(musicPiece => musicPiece.pieceName == musicName) : -1;
                        //This name is not used
                        if (pieceIndex == -1)
                        {
                            musicPiece.pieceName = musicName;
                            musicPieces.Add(musicPiece);
                            lb_playlist.Items.Add(tb_musicname.Text);
                            registerButton.Text = "start";
                            tb_error.Text = "";
                        }
                        else
                        {
                            tb_error.Text = "Ce nom de musique est déjà utilisé";
                        }
                    }
                    else
                    {
                        tb_error.Text = "Veuillez renseigner un nom pour la musique";
                    }
                } else
                {
                    registerButton.Text = "start";
                }
            }
        }

        //Keyboard key event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Tile playedTile;
            long executionTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            switch (keyData)
            {
                case Keys.A:
                    playedTile = new Tile(NoteEnum.DO, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.Z:
                    playedTile = new Tile(NoteEnum.RE, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.E:
                    playedTile = new Tile(NoteEnum.MI, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.R:
                    playedTile = new Tile(NoteEnum.FA, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.T:
                    playedTile = new Tile(NoteEnum.SOL, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.Y:
                    playedTile = new Tile(NoteEnum.LA, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.U:
                    playedTile = new Tile(NoteEnum.SI, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
                case Keys.I:
                    playedTile = new Tile(NoteEnum.DOO, executionTime);
                    PlayAndRecordSound(playedTile);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Replay a music
        private void btn_replay_Click(object sender, EventArgs e)
        {
            if(lb_playlist.Items.Count > 0)
            {
                String selectedMusicName = lb_playlist.SelectedItem.ToString();
                MusicPiece selectedMusicPiece = musicPieces.First(musicPiece => musicPiece.pieceName == selectedMusicName);
                selectedMusicPiece.PlayMusicPiece();
            } else
            {
                musicPiece.PlayMusicPiece();
            }
        }
    }
}
