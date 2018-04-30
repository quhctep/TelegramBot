using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelegramBotConsole.Models;
using TelegramBotConsole.Commands;

namespace TelegramBotConsole.Commands
{
    public static class Command
    {
        public static async void ReceiveMessage()
        {
            var lastMessageId = 0;
            while (true)
            {
                var messages = await YourBot.Bot.GetUpdatesAsync();
                if (messages.Length > 0)
                {
                    var last = messages[messages.Length - 1];
                    if (lastMessageId != last.Id)
                    {
                        lastMessageId = last.Id;
                        Console.WriteLine(last.Message.Text);
                        switch (last.Message.Text.ToLower())
                        {
                            case "привет": case "hello": Hello.ReceiveMessage(last.Message.From.Id); break;
                            case "помоги": case "help": Help.ReceiveMessage(last.Message.From.Id);  break;
                            case "калькулятор": case "calculate": Calc.ReceiveMessage(last.Message.From.Id); break;
                        }
                    }
                }
                Thread.Sleep(200);
            }
        }
    }
}