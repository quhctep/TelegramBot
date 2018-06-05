using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotConsole.Models;
using Telegram.Bot.Types;

namespace TelegramBotConsole.Commands
{
    public static class Calc
    {
        public static void ReceiveMessage(int Id)
        {
            YourBot.Bot.SendTextMessageAsync(Id,"",replyMarkup: new ReplyKeyboardRemove());
            YourBot.Bot.SendTextMessageAsync(Id, "С радостью решу! Но я еще не особо умный помощник, только учусь.");
            YourBot.Bot.SendTextMessageAsync(Id, "Давай выберим тип уравнения...");
            var button = new ReplyKeyboardMarkup();
            button.Keyboard =
            new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("a + b"),
                    new KeyboardButton("a - b")
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("a * b")
                }
            };
        }
    }
}