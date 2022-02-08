using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot
{
    public static class TelegramBotServiceExtension
    {
        public static void AddTelegramBot(this IServiceCollection services, string token)
        {
            var bot = new TelegramBotClient(token);
            //if (!bot.TestApiAsync().Result)
            //{
            //    throw new ArgumentException("неверный токен для Telegram бота");
            //}
            services.AddSingleton(bot);
        }
    }
}
