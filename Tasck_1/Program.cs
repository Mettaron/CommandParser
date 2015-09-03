using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasck_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arg;
            //arg = System.Environment.GetCommandLineArgs();
            string[] commands = new string[3] { "-k", "-ping", "-print" };
            string command = null;
            if (args.Contains("/?") || args.Contains("/help") || args.Contains("-help") || args.Length==0)
            {
                Console.WriteLine("[/?] [/help] [-help] [-k key value] [-ping] [-print <print a value>]");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (commands.Contains(args[i]))
                    {
                        if(command=="-print")
                            Console.WriteLine("");
                        command = args[i];
                        if (command == "-ping")
                        {
                            Console.Beep();
                            Console.WriteLine("Pinging ...");
                        }
                    }
                    else
                    {
                        switch (command)
                        {
                            case "-k":
                                if (!commands.Contains(args[i]))
                                {
                                    if (args.Length > (i + 1) && !commands.Contains(args[i + 1]))
                                    {
                                        Console.WriteLine(args[i] + " - " + args[i + 1]);
                                        i += 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine(args[i] + " - <null>");
                                    }
                                }
                                break;
                            case "-print":
                                Console.Write(args[i]+" ");
                                break;
                            default:
                                Console.WriteLine("Command <" + args[i] + "]> is not supported, use CommandParser.exe /? to see set of allowed commands");
                                break;
                        }
                    }
                }
            }
        }
    }
}
