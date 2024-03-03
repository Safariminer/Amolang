using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Linq;
using System.Numerics;

namespace AmongUsLanguage
{
    class Program
    {
        static string filename = "script";

        static Dictionary<string, int> values = new Dictionary<string, int>();

        static List<string> lines = new List<string>();

        static int currentLine = 0;
        static void Main(string[] args)
        {
            string filePath = Process.GetCurrentProcess().MainModule.FileName;
            string finalFolderPath = System.IO.Path.GetDirectoryName(filePath);
            TextReader tr = new StreamReader(finalFolderPath + @"\" + @filename + ".amolang");
            string code = tr.ReadLine();
            while (code != null)
            {
                lines.Add(code);
                code = tr.ReadLine();
            }
            while (currentLine < lines.Count)
            {
                RunLine(lines[currentLine]);
            
            }
            while(true) { Console.ReadKey(); }
        }
        static void RunLine(string code)
        {
            // System.Console.WriteLine(code);
            string[] args = code.Split(" ");
            if(code.Contains("WAIT A SEC "))
            {
                if (args[0] == "WAIT" && args[1] == "A" && args[2] == "SEC")
                {
                    currentLine++;
                    return;
                }
            }
            if(code.Contains("GUYS GUYS GUYS "))
            {
                for(int i = 3; i < args.Length; i++)
                {
                    Console.Write(args[i] + " ");
                }
                Console.Write("\n");
                currentLine++;
                return;
            }
            if(code.Contains("I SAW ") && code.Contains(" WITH ") && code.Contains(" IN MEDBAY"))
            {
                string player1 = args[2];
                string player2 = args[4];
                int value1 = 0;
                int value2 = 0;
                if (player1.All(char.IsDigit))
                {
                    value1 = int.Parse(player1);
                }
                else if (values.ContainsKey(player1))
                {
                    value1 = values[player1];
                }

                if (player2.All(char.IsDigit))
                {
                    value2 = int.Parse(player2);
                }
                else if (values.ContainsKey(player2))
                {
                    value2 = values[player2];
                }

                if(value1 != value2) { currentLine++; }
            }
            if(code.Contains("HOLY MOLY GUYS REWIND TO"))
            {
                string player = args[5];
                if (player.All(char.IsDigit)) {
                    currentLine = int.Parse(player) - 2;
                }
                else if (values.ContainsKey(player))
                {
                    currentLine = values[player] - 2;
                }
            }
            if (code.Contains("GUYS I CAN VOUCH") && code.Contains(" IS "))
            {
                string player = args[4];
                int value = int.Parse(args[6]);

                if (values.ContainsKey(player)) {
                    values[player] = value;
                    currentLine += 1;
                    return;
                }

                values.Add(player, value);
            }
            if (code.Contains("CAN VOUCH GO AND TELL THEM COME ON"))
            {
                string player = args[0];
                if (values.ContainsKey(player))
                {
                    Console.Write(Encoding.ASCII.GetString(new byte[] { (byte)(values[player]) }));
                }
            }
            if (code.Contains("HOW MANY BODIES"))
            {
                string player = args[0];
                if (values.ContainsKey(player))
                {
                    Console.Write(values[player]);
                }
            }
            if (code.Contains("IS JUST LIKE"))
            {
                string player = args[0];
                string sussyplayer = args[4];


                
                if (values.ContainsKey(player) && values.ContainsKey(sussyplayer))
                {
                    values[player] = values[sussyplayer];
                    currentLine += 1;
                    return;
                } else if (values.ContainsKey(sussyplayer))
                {
                    values.Add(player, values[sussyplayer]);
                }
                
            }
            if (code.Contains("IF ITS NOT ") && code.Contains(" THEN VOTE ME"))
            {
                string player = args[3];

                if (values.ContainsKey(player))
                {
                    if (values[player] == 0)
                    {
                        currentLine += 1;
                    }
                }
            }
            if (code.Contains("IDK WHAT ") && code.Contains(" IS BUT ITS BETWEEN ") && code.Contains(" AND "))
            {
                Random ran = new Random();
                string player = args[2];
                int first = int.Parse(args[7]);
                int second = int.Parse(args[9]);
                int value = ran.Next(first, second + 1);

                if (values.ContainsKey(player))
                {
                    values[player] = value;
                    currentLine += 1;
                    return;
                }
                values.Add(player, value);
                // System.Console.WriteLine(value);
            }
            if (code.Contains("WAS THE IMPOSTOR"))
            {
                if (values[args[0]] != 0) {
                    currentLine += lines.Count;
                }    
            }
            if (code.Contains("GOES UP"))
            {
                string player = args[0];
                if (values.ContainsKey(player))
                {
                    values[player] += 1;
                }
            }
            if (code.Contains("GOES DOWN"))
            {
                string player = args[0];
                if (values.ContainsKey(player))
                {
                    values[player] -= 1;
                }
            }
            if (code.Contains("HOW MANY TASKS DID YOU DO"))
            {
                string player = args[0];
                int value = int.Parse(Console.ReadLine());
                if (values.ContainsKey(player))
                {
                    values[player] = value;
                    currentLine += 1;
                    return;
                }
                values.Add(player, value);
            }
            if (code.Contains("WHO ARE YOU"))
            {
                string player = args[0];
                int value;
                try
                {
                    try
                    {
                        value = (int) Console.ReadLine()[0];
                    } catch (ArgumentNullException)
                    {
                        value = 69;
                    }
                } catch (FormatException)
                {
                    value = 69;
                }
                if (values.ContainsKey(player))
                {
                    values[player] = value;
                    currentLine += 1;
                    return;
                }
                values.Add(player, value);
            }
            if(code.Contains(" WHERE WAS THE BODY"))
            {
                string player = args[0];
                int value = currentLine;
                if (values.ContainsKey(player))
                {
                    values[player] = value;
                    currentLine += 1;
                    return;
                }
                values.Add(player, value);
            }
            if(code.Contains("YOU WERE EJECTED"))
            {
                Environment.Exit(0);
            }
            if(code.Contains("WAS EJECTED"))
            {
                string player = args[0];
                int exitCode = 0;
                if (player.All(char.IsDigit))
                {
                    exitCode = int.Parse(player);
                }
                else if (values.ContainsKey(player))
                {
                    exitCode = values[player];
                }
                Environment.Exit(exitCode);
            }
            currentLine += 1;
        }
    }
}
