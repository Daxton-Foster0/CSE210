using System;
using System.Collections.Generic;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string game = "True";
            List<string> words = new List<string>();
            words.Add("1");
            words.Add("2");
            words.Add("3");
            words.Add("4");
            words.Add("5");
            words.Add("6");
            words.Add("7");
            words.Add("8");
            words.Add("9");
            string turn = "o";
            while(game == "True")
                {
                if (words[0] == "1" || words[1] == "2" || words[2] == "3" || words[3] == "4" || words[4] == "5" || words[5] == "6" || words[0] == "7" || words[1] == "8" || words[2] == "9")
                {
                    turn = switchturn(turn);
                    string correct = "False";
                    while (correct == "False")
                    {
                        printboard(words);
                        Console.WriteLine($"{turn}'s turn to choose a square (1-9): ");
                        string input = Console.ReadLine();
                        int number = int.Parse(input);
                        number = number - 1;
                        if (words[number] != "x" && words[number] != "o")
                        {
                            words[number] = turn;
                            correct = "True";
                        }
                        else
                        {
                            correct = "False";
                        }
                    }
                    game = gameend(words, game, turn);
                    }
                else
                {
                    game = "False";
                }
                }
            Console.WriteLine($"Good game. Thanks for playing!");
        }
        static void printboard(List<string> words)
        {
        Console.WriteLine($"{words[0]}|{words[1]}|{words[2]}");
        Console.WriteLine($"- + -");
        Console.WriteLine($"{words[3]}|{words[4]}|{words[5]}");
        Console.WriteLine($"- + -");
        Console.WriteLine($"{words[6]}|{words[7]}|{words[8]}");
        }
        static string switchturn(string turn)
        {
            if (turn == "x")
            {
                turn = "o";
            }
            else if (turn == "o")
            {
                turn = "x";
            }
            return turn;
        }
        static string gameend(List<string> words,string game,string turn)
        {
            if (words[0] == turn && words[1] == turn && words[2] == turn)
            {  
                game = turn;
            }
            else if (words[0] == turn && words[4] == turn && words[8] == turn)
            {
                game = turn;
            }
            else if (words[0] == turn && words[3] == turn && words[6] == turn)
            {
                game = turn;
            }
            else if (words[1] == turn && words[4] == turn && words[7] == turn)
            {
                game = turn;
            }
            else if (words[2] == turn && words[4] == turn && words[6] == turn)
            {
                game = turn;
            }
            else if (words[3] == turn && words[4] == turn && words[5] == turn)
            {
                game = turn;
            }
            else if (words[6] == turn && words[7] == turn && words[8] == turn)
            {
                game = turn;
            }
            else
                game = "True";
            return game;
        }
    }
}