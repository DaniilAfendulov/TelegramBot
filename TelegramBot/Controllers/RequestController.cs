using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot.Controllers
{
    [Route("TelegramBot")]
    public class RequestController : Controller
    {
        private TelegramBotClient _client;
        public RequestController(TelegramBotClient client)
        {
            _client = client;
        }

        [Route("AddRequest")]
        [HttpPost]
        public async Task<IActionResult> AddRequest()
        {
            // TODO: AddRequest
            return Ok();
        }
    }
}
