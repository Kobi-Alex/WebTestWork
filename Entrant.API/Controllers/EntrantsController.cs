using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entrant.API.Application.Services.Interfaces;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;


namespace Entrant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class EntrantController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public EntrantController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }


        //POST api/Entrant
        [HttpPost]
        public async Task<IActionResult> CreateAccount([FromBody] EntrantContactCreateDto contactCreateDto, CancellationToken cancellationToken)
        {

            await _serviceManager.EntrantAccountService.GetByNameAsync(contactCreateDto.AccountName, cancellationToken);

            if (await _serviceManager.EntrantContactService.IsContactExistAsync(contactCreateDto.Email, cancellationToken))
            {
                await _serviceManager.EntrantContactService.UpdateAsync(contactCreateDto, cancellationToken);
            }
            else
            {
                await _serviceManager.EntrantContactService.CreateAsync(contactCreateDto, cancellationToken);
            }

            return NoContent();

        }

    }
}
