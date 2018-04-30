using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TelegramBotConsole.Models;

namespace TelegramBotConsole.Commands
{
    public static class Help
    {
        public static async void ReceiveMessage(int Id)
        {
            await YourBot.Bot.SendTextMessageAsync(Id, "О, нужна помощь! Давай-ка решим, чем я могу тебе помочь...");

            var button = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup();
            button.Keyboard =
            new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Калькулятор"),
                    new KeyboardButton("Погода")
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("Курс валют")
                }
            };
            await YourBot.Bot.SendTextMessageAsync(Id, "Выбери, чем тебе помочь:", replyMarkup: button);
        }
    }
}