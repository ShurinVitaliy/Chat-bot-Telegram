using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramBot
{
    class Program
    {
        static TelegramBotClient Bot;

        static void Main(string[] args)
        {
            Bot = new TelegramBotClient("580295528:AAE9c5hJk__odw6Nd5qNhta5zAedky74w3A");

            Bot.OnMessage += BotOnMessageReceived;

            var me = Bot.GetMeAsync().Result;

            Console.WriteLine(me.FirstName);

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void BotOnMessageReceived(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            String name = $"{message.From.FirstName} {message.From.LastName}";

            Console.WriteLine($"{name} Отправил сообщение: {message.Text}"); 
        }
    }
}
