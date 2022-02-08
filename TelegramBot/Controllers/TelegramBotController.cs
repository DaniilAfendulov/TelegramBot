using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot.Controllers
{
    [ApiController]
    [Route("telegram-bot")]
    public class TelegramBotController : Controller
    {
        private TelegramBotClient _client;
        public TelegramBotController(TelegramBotClient client)
        {
            _client = client;
        }

        [Route("job-request")]
        [HttpPost]
        public async Task<IActionResult> JobRequest()
        {
            // TODO: AddRequest
            return Ok("asdasd");
        }
    }
}
