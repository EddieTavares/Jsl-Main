using Jsl.Application.Models;
using Jsl.Domain.Entities;
using Jsl.Domain.Interfaces;
using Jsl.Service.Validators;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Jsl.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristaController : ControllerBase
    {
        private IBaseService<Motorista> _baseMotoristaService;

        public MotoristaController(IBaseService<Motorista> baseMotoristaService)
        {
            _baseMotoristaService = baseMotoristaService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateMotoristaModel Motorista)
        {
            if (Motorista == null)
                return NotFound();

            return Execute(() => _baseMotoristaService.Add<CreateMotoristaModel, MotoristaModel, MotoristaValidator>(Motorista));
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateMotoristaModel Motorista)
        {
            if (Motorista == null)
                return NotFound();

            return Execute(() => _baseMotoristaService.Update<UpdateMotoristaModel, MotoristaModel, MotoristaValidator>(Motorista));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseMotoristaService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseMotoristaService.Get<MotoristaModel>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseMotoristaService.GetById<MotoristaModel>(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
