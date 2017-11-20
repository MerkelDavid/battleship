using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Game
    {
        public void startGame()
        {
            Console.WriteLine("Welcome to Battleship \nPress any key to continue");
            Console.ReadLine();
            preGame();
        }

        public void preGame()
        {

            Player player1 = new Player();
            Player player2 = new Player();

            getNames(player1, player2);
            pickPiecePossitions(player1);
            pickPiecePossitions(player2);

            gameLoop(player1, player2, false);

        }

        public Player gameLoop(Player player, Player enemy,bool isWinner)
        {
            if (isWinner)
            {
                return whoIsWinner(player, enemy);
            }
            else
            {
                displayBoards(player);
                makeMove(player);
                isHit(player, enemy);

                return gameLoop(enemy, player, isWinner);
            }
        }

        public void getNames(Player player1, Player player2)
        {
            Console.WriteLine("What is your name player 1?");
            player1.setName(Console.ReadLine());

            Console.WriteLine("What is your name player 2?");
            player2.setName(Console.ReadLine());
        }

        public void pickPiecePossitions(Player player)
        {

        }

        public void displayBoards(Player player)
        {
            Console.WriteLine("Your Board");
            player.displayBoard(player.getPlayerBoard());


            Console.WriteLine("Their Board");
            player.displayBoard(player.getEnemyBoard());
        }

        public void makeMove(Player player)
        {
            Console.WriteLine("please enter the x-value of your move.");
            player.setXCoordinate(int.Parse(Console.ReadLine()));

            Console.WriteLine("please enter the y-value of your move.");
            player.setYCoordinate(int.Parse(Console.ReadLine()));
        }

        public bool isHit(Player player, Player enemy)
        {
            if()
        }

        public Player whoIsWinner(Player player1,Player player2)
        {
            if (player1.getWinner())
            {
                return player1;
            }

            return player2;
        }

    }
}
