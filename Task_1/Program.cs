using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            if (!help(arg))
            {
                for (int i = 0; i < arg.Length; i++)
                {
                    switch (is_comand(arg[i]))
                    {
                        case "-k":
                            i = k(arg, i + 1);
                            break;
                        case "-print":
                            i = print(arg, i + 1);
                            break;
                        case "-ping":
                            ping();
                            break;
                        default:
                            Console.WriteLine("Command <" + arg[i] + "> is not supported, use Tasck_1.exe /? to see set of allowed commands");
                            break;
                    }
                }
            }
        }
        public static bool help(string[] list)
        {
            string[] help = new string[3] { "/?", "/help", "-help" };
            bool is_help = false;
            foreach (string val in list)
            {
                if (help.Contains(val.ToLower()))
                    is_help = true;
            }
            if (list.Length == 0)
                is_help = true;
            if (is_help)
                Console.WriteLine("[/?] [/help] [-help] [-k key value] [-ping] [-print <print a value>]");
            return is_help;
        }
        public static int k(string[] arg, int key)
        {
            for (int i = key; i < arg.Length; i++)
            {
                if (is_comand(arg[i]) == null)
                {
                    if ((i + 1) < arg.Length && is_comand(arg[i + 1]) == null)
                    {
                        Console.WriteLine(arg[i] + " - " + arg[i + 1]);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(arg[i] + " - <null>");
                        return i;
                    }
                }
                else
                    return i - 1;
            }
            return arg.Length;
        }
        public static int print(string[] arg, int key)
        {
            string print = null;
            for (int i = key; i < arg.Length; i++)
            {
                if (is_comand(arg[i]) == null)
                {
                    if (print != null)
                        print += " ";
                    print += arg[i];
                }
                else
                {
                    Console.WriteLine(print);
                    return i - 1;
                }
            }
            Console.WriteLine(print);
            return arg.Length;
        }
        public static string is_comand(string comand)
        {
            string[] list = new string[3] { "-k", "-print", "-ping" };
            if (list.Contains(comand.ToLower()))
                return comand.ToLower();
            else
                return null;
        }
        public static void ping()
        {
            Console.Beep();
            Console.WriteLine("Pinging ...");
        }
    }
}
