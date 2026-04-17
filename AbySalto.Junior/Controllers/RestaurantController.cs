using System.Data.Common;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Application.Util;
using Microsoft.AspNetCore.Mvc;

namespace AbySalto.Junior.Controllers
{
    [ApiController]
    [Route("api/v1/orders")]
    public class RestaurantController : ControllerBase
    {
       private readonly IOrderService _orderService;

       public RestaurantController(IOrderService orderService)
       {
           _orderService = orderService;
       }
        
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] FrontendOrderCreationRequestDto dto)
        {
            try
            {
               OrderValidator.Validate(dto); 
                
                await _orderService.CreateOrder(dto);

                return Ok();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                
                return Ok(await _orderService.GetAllOrders());
            }
            catch (DbException e)
            {
                return StatusCode(500, "Error with creation of order" + e.Message); 
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateByIdAsync([FromBody] OrderStatusUpdateRequestDto dto)
        {
            try
            {
                await _orderService.UpdateOrder(dto);

                return Ok();
            } 
            catch (Exception e)
            {
                return StatusCode(500, "Error with creation of order" + e.Message);
            }
        }
    }
}
