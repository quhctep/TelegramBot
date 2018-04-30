using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelegramBotConsole.Commands;

namespace TelegramBotConsole.Models
{
    class YourBot
    {
        public string token = "******************************";
        public static Telegram.Bot.TelegramBotClient Bot;
        public async void testApiAsync()
        {
            try
            {
                Bot = new Telegram.Bot.TelegramBotClient(token);
                var me = await Bot.GetMeAsync();
                Console.WriteLine("Привет, меня зовут " + me.FirstName);
                Thread newThread = new Thread(Command.ReceiveMessage);
                newThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Привет, меня зовут " + ex.Message);
            }
        }
        
        

    }
}
