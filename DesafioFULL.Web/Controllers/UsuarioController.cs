﻿using DesafioFULL.Dominio.Entidades;
using DesafioFULL.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DesafioFULL.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        public UsuarioController(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repositorioUsuario.ObterTodos());
                //if(condicao == false)
                //{
                //    return BadRequest("");
                //}
            }
            catch (Exception e)
            {

                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Usuario Usuario)
        {
            try
            {
                _repositorioUsuario.Adicionar(Usuario);
                return Created("Usuario", Usuario);
            }
            catch (Exception e)
            {

                return BadRequest(e.ToString());
            }
        }

    }
}
