using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelegramBotConsole.Models;

namespace TelegramBotConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            YourBot yourBot = new YourBot();
            yourBot.testApiAsync();
            Console.ReadLine();
        }
    }
}