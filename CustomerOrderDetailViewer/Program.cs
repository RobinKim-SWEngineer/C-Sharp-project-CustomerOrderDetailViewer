using CustomerOrderDetailViewer.Model;
using CustomerOrderDetailViewer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerOrderDetailViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOrderDetailCommand customerOrderDetailCommand = new CustomerOrderDetailCommand();
            List<CustomerOrderDetailModel> customerOrderDetailModels = new List<CustomerOrderDetailModel>();

            try
            {
                customerOrderDetailModels = customerOrderDetailCommand.GetList();
                if (customerOrderDetailModels.Any())
                {
                    foreach (CustomerOrderDetailModel eachRow in customerOrderDetailModels)
                    {
                        Console.WriteLine($" OrderId : {eachRow.OrderId} -- CustomerId: {eachRow.CustomerId} ,Customer : {eachRow.FirstName} {eachRow.LastName}," +
                            $"Product: {eachRow.ProductName},  Price: {eachRow.ListPrice}");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Faild : {exception.Message}");
            }
        }
    }
}