using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Microsoft.AspNetCore.Mvc;

using Desafio.Context;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController  : ControllerBase
    {
        private readonly Seguradora _context;
        public VendaController(Seguradora context)
        {
            _context = context;
        } 

        [HttpPost]
        public IActionResult RegistrarVenda(Venda venda)
        {
            if(venda.Itens.Count == 0)
            {
                return BadRequest();
            }
            //venda.Status = EnumStatusVenda.Aguadando_Pagamento;
            _context.Add(venda);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorID), new { id = venda.Id }, venda);
        }


        [HttpGet("{id}")]
        public IActionResult ObterPorID(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda == null)
            {
                return NotFound();
            }
            return Ok(venda);
        }
       
        [HttpPatch("{id}")]
        public IActionResult AtualizarStatus(EnumStatusVenda statusVenda,int id  )
        {
            var vendaAtualizada = _context.Vendas.Find(id);
            if (vendaAtualizada == null)
            {
                return NotFound();
            }
            else if(vendaAtualizada.Status == EnumStatusVenda.Aguadando_Pagamento&& statusVenda == EnumStatusVenda.Aprovado||statusVenda == EnumStatusVenda.Cancelada)
            {
                vendaAtualizada.Status = statusVenda;
                _context.SaveChanges();
                return Ok(vendaAtualizada);
            }
            else if(vendaAtualizada.Status == EnumStatusVenda.Aprovado && statusVenda == EnumStatusVenda.Enviado_Para_Transportadora||statusVenda == EnumStatusVenda.Cancelada)
            {
                vendaAtualizada.Status = statusVenda;
                _context.SaveChanges();
                return Ok(vendaAtualizada);
            }
            else if(vendaAtualizada.Status == EnumStatusVenda.Enviado_Para_Transportadora && statusVenda == EnumStatusVenda.Entregue)
            {
                vendaAtualizada.Status = statusVenda;
                _context.SaveChanges();
                return Ok(vendaAtualizada);
            }
            else if(vendaAtualizada.Status == EnumStatusVenda.Enviado_Para_Transportadora && statusVenda == EnumStatusVenda.Entregue)
            {
                vendaAtualizada.Status = statusVenda;
                _context.SaveChanges();
                return Ok(vendaAtualizada);
            }
            else
            {
                return BadRequest();
            }
        }

        
    }
}