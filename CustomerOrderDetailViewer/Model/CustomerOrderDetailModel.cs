using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderDetailViewer.Model
{
    class CustomerOrderDetailModel
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public Decimal ListPrice { get; set; }
    }
}
