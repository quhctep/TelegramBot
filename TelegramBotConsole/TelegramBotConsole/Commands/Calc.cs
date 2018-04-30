using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotConsole.Models;

namespace TelegramBotConsole.Commands
{
    public static class Calc
    {
        public static void ReceiveMessage(int Id)
        {
            YourBot.Bot.SendTextMessageAsync(Id,"",replyMarkup: new ReplyKeyboardRemove());
            YourBot.Bot.SendTextMessageAsync(Id, "С радостью решу! Напиши мне уравнение...");
        }
    }
}