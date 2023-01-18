using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Domain.Requests
{
    public record CreateOrderRequest(string orderId, string productType, int quantity);
}
