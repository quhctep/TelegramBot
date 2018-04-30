using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelegramBotConsole.Models;

namespace TelegramBotConsole.Commands
{
    public static class Hello
    {
        public static void ReceiveMessage(int Id)
        {
            YourBot.Bot.SendTextMessageAsync(Id, "Привет! Я твой личный решатель всех проблем. Если нужна помощь, напиши мне 'помоги'.");
        }
    }
}