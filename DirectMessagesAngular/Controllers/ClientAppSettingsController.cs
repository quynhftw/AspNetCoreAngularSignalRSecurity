﻿using SecurityAspNetCoreSignalR.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SecurityAspNetCoreSignalR.Controllers
{
    [Route("api/[controller]")]
    public class ClientAppSettingsController : Controller
    {
        private readonly ClientAppSettings _clientAppSettings;

        public ClientAppSettingsController(IOptions<ClientAppSettings> clientAppSettings)
        {
            _clientAppSettings = clientAppSettings.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientAppSettings);
        }
    }
}
