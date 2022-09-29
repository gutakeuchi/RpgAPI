using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using RpgApi.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagensController:ControllerBase
    {
        private readonly DataContext _dataContext;

        public PersonagensController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Personagem p = await _dataContext.Personagens
                .FirstOrDefaultAsync(pBusca => pBusca.Id == id);
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Personagem> lista = await _dataContext.Personagens.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Personagem novoPersonagem)
        {
            try
            {
                if (novoPersonagem.PontosVida > 100)
                {
                    throw new Exception("Pontos de Vida não pode ser maior que 100");
                }
                await _dataContext.Personagens.AddAsync(novoPersonagem);
                await _dataContext.SaveChangesAsync();

                return Ok(novoPersonagem.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);   
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Personagem novoPersonagem)
        {
            try
            {
                if (novoPersonagem.PontosVida > 100)
                {
                    throw new Exception("Pontos de Vida não pode ser maior que 100");
                }
               _dataContext.Personagens.Update(novoPersonagem);
               int linhasAfetadas = await _dataContext.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);   
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Personagem pRemover = await _dataContext.Personagens
                .FirstOrDefaultAsync(p => p.Id == id);

                _dataContext.Personagens.Remove(pRemover);
                int linhasAfetadas = await _dataContext.SaveChangesAsync();
                
                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);   
            }
        }
    }


}