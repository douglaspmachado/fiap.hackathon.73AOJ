﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using App.Domain.Entity;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace App.UI.Controllers
{
    public class CadastroController : Controller
    {

        //private readonly string URL_API = "playershares.api";
        //private readonly string URL_API = "192.168.99.100:20001";

        private readonly IConfiguration _configuration;

        public CadastroController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View("Cadastro");
        }







    }
}