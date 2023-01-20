using ExternalInterfacesFeedProcessServices.SampleModel.Order;
using MassTransit;

namespace ExternalInterfacesFeedProcessServices.BusinessObjects.Order
{
    public class OrderConsumer:IConsumer<OrderModel>
    {

        public async Task Consume(ConsumeContext<OrderModel> context)
        {
            var msg = context.Message;

        }
    }
}
