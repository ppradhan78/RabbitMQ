using ExternalInterfacesFeedServices.SampleModel.Order;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfacesFeedServices.Controllers.Order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IPublishEndpoint _publishEndpoint { get; set; }

        public OrderController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderModel order)
        {
            try
            {
                await _publishEndpoint.Publish<OrderModel>(order);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
