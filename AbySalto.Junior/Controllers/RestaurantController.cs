using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AbySalto.Junior.Controllers
{
    [ApiController]
    [Route("order")]
    public class RestaurantController : ControllerBase
    {
       private readonly IOrderService _orderService; 
        
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] OrderCreationRequestDto dto)
        {
            try
            {
                _orderService.CreateOrder(dto);

                return Ok();
            }
            catch 
            {
               return StatusCode(500, "Error with creation of order"); 
            }
            
        }
    }
}
