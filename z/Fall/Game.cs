using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fall
{
    public static class GameState
    {
        public const string Start = "Start";
        public const string End = "End";
    }
    internal class Game
    {
        public string State { get; set; }
        public bool Bingo { get; set; }
        public Player ActivePlayer { get; set; }
        
        public int RandomNumber { get; set; }
        public List<Player> lstPlayers = new List<Player>();

        public List<Position> lstOfActivePositions = new List<Position>();

        public int GenerateRandomNumber() {
            Random rand = new Random();
            int tempNumber = rand.Next(1, 7);
            Bingo = false;
            if (tempNumber == 6) Bingo = true;
            return tempNumber;
        }

        // set Active player


        // insert player for new game after getting Bingo

        // repeat with same Player if Bingo is setted
        public Player RunCubeForActivePlayer(Player activePlayer) {
            activePlayer.LastNumber = GenerateRandomNumber();
            activePlayer.IsBingo = Bingo;
            MoveFigureToNewPosition(activePlayer);
            /*
            while (Bingo) {
                activePlayer.LastNumber = GenerateRandomNumber();
                MoveFigureToNewPosition(activePlayer);
                // Movement
                // with active Player move active Figure on Position
                // set active Player and set active Figure change and save Position property if already some Figure is there
                // save Position property - figureOnPosition
                // Movement - if non active figure in player -- do nothing
            }
            */
            return activePlayer;
        }

        public Figure MoveFigureToNewPosition(Player player) {
            // choose active figure and move it 
            // if other figure is behind them move those figure -- read oponent figure from position - which is near
            Figure figure = new Figure();
            Position position = new Position(new Position[0]);

            // if (player.ActiveFigures.Count == 0) {
                if (player.IsBingo) {
                    // put First figure to the board (position)
                    if (player.Name == "zu1") { position.NumInGame = 1; }
                    else if (player.Name == "ze1") { position.NumInGame = 9; }
                    else if (player.Name == "c1") { position.NumInGame = 19; }
                    else if (player.Name == "cr1") { position.NumInGame = 29; }
                    figure.Name = player.Name + "1"; player.ActiveFigures.Add(figure);
                    lstOfActivePositions.Add(position);
                }
            // }
            // Display figure move
            if (player.ActiveFigures.Count > 0)
            {
                // player.ActiveFigures[0].Position = new Position() { Name };                
            }
            // Display figure over ActivePosition from Game object
            if (lstOfActivePositions.Count > 0) { 
                
            }

            return figure; // player.figurefigure;
        }
    }
}
