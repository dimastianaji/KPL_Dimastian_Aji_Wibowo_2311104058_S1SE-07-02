using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GameAutomata
    public enum GameState
{ Menu,
Bermain,
GameOver
}

private GameState currentState;

public GameAutomata()
{
    currentState = GameState.Menu;
}

public void ChangeState(GameState newState)
{
    currentState = newState;
    Console.WriteLine("Berpindah ke state: {currentState}")
}
public void Run()
{
    while(true)
    { switch(currentState)}
        { case GameState.Menu:
                Console.WriteLine("Di Menu utama. Pilih 'Start' untuk memulai bermain.");
                Console.WriteLine("Tekan 'S untuk Start atau 'Q' untuk keluar.");
                var menuChoice = Console.ReadKey(true).Key;
                if (menuChoice == ConsoleKey.S)
                {
                    ChangeState(GameState.Bermain);
                }
                else if (menuChoice == ConsoleKey.Q)
                {
                    return;
                }
                break;
            case GameState.Bermain:
                Console.WriteLine("Bermain... Tekan 'G' untuk Game Over atau 'Q' untuk kelluar.");
                var gameChoice = Console.ReadKey(true).Key;
                if(gameChoice == ConsoleKey.G)
                {
                    ChangeState(GmaeState.GameOver);
                }
                else if(gameChoice == ConsoleKey.Q)
                { 
                    return
                }
                break;
            case GameState.GameOver:
                Console.WriteLine("Game Over! Tekan 'R' untuk kembali ke Menu atau 'Q' untuk keluar.");
                var gameOverChoice = Console.ReadKey(true.Key);
                if(gameOverChoice == ConsoleKey.R)
                {
                    ChangeState(GameState.Menu);
                }
                else if(gameOverChoice == ConsoleKey.Q)
                { return;
                }
                break;
            }
}
Public class Program
{
    public static void Main()
    {
        GameAutomata game = new GameAutomata();
        game.Run();
    }
}