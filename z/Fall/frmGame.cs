using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Fall
{
    public partial class frmGame : Form
    {
        Game game { get; set; }        
        public frmGame()
        {
            InitializeComponent();
            game = new Game();
            // setup players
            Player yellow = new Player() { Name = "zu1" };
            Player green = new Player() { Name = "ze1" };
            Player red = new Player() { Name = "cr1"};
            Player black = new Player() { Name = "c1" };
            game.lstPlayers = new List<Player>() { yellow, green, red, black };
            game.State = GameState.Start;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            foreach (Player x in game.lstPlayers)
            {
                game.ActivePlayer = x;
                switch (game.ActivePlayer.Name) {
                    case "zu1": { borderYellow.BorderStyle = BorderStyle.FixedSingle; DisableAllBorders("borderYellow"); } break;
                    case "ze1": { borderGreen.BorderStyle = BorderStyle.FixedSingle; DisableAllBorders("borderGreen"); } break;
                    case "cr1": { borderRed.BorderStyle = BorderStyle.FixedSingle; DisableAllBorders("borderRed"); } break;
                    case "c1" : { borderBlack.BorderStyle = BorderStyle.FixedSingle; DisableAllBorders("borderBlack"); } break;
                }
                game.RunCubeForActivePlayer(game.ActivePlayer);
                Thread.Sleep(50);
                lblCube.Text = game.ActivePlayer.LastNumber.ToString();
                DisplayFigureByPostion();
                switch (game.ActivePlayer.Name) {
                    case "zu1": { game.ActivePlayer.Name = "ze1"; } break;
                    case "ze1": { game.ActivePlayer.Name = "cr1"; } break;
                    case "cr1": { game.ActivePlayer.Name = "c1"; } break;
                    case "c1": { game.ActivePlayer.Name = "zu1"; } break;
                }
                break;
            }
        }
    }
}
