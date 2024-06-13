using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall
{
    public partial class frmGame
    {
        public void DisableAllBorders(string unless) {
            if (borderYellow.Name == unless) borderGreen.BorderStyle = borderRed.BorderStyle = borderBlack.BorderStyle = BorderStyle.None;
            if (borderGreen.Name == unless) borderYellow.BorderStyle = borderRed.BorderStyle = borderBlack.BorderStyle = BorderStyle.None;
            if (borderRed.Name == unless) borderBlack.BorderStyle = borderYellow.BorderStyle = borderGreen.BorderStyle = BorderStyle.None;
            if (borderBlack.Name == unless) borderYellow.BorderStyle = borderGreen.BorderStyle = borderRed.BorderStyle = BorderStyle.None;
        }
        public void DisplayFigureByPostion() {            
            if (game.lstOfActivePositions.Count > 0) {
                foreach (Position x in game.lstOfActivePositions) {
                    switch (x.NumInGame.ToString())
                    {
                        case "1": { lbl1.Text = "Y1"; } break;
                        case "9": { lbl9.Text = "Y9"; } break;
                        case "19": { lbl19.Text = "Y19"; } break;
                        case "29": { lbl29.Text = "Y29"; } break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
