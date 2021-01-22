using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CustomerOrderDetailViewer.Model;

namespace CustomerOrderDetailViewer.Repository
{
    class CustomerOrderDetailCommand
    {
        private string _stringConnection = @"Data Source=DESKTOP-PT93TFM\SQLEXPRESS;Initial Catalog=BikeStores;Integrated Security=True";
        private string _getListCommand = "SELECT TOP 50 order_id, customer_id, product_id, first_name, last_name, product_name, list_price FROM CustomerOrderView";
        private List<CustomerOrderDetailModel> _customerOrderDetailModels;

        public CustomerOrderDetailCommand()
        {
            _customerOrderDetailModels = new List<CustomerOrderDetailModel>();
        }

        public List<CustomerOrderDetailModel> GetList()
        {
            using (var sqlConnection = new SqlConnection(_stringConnection))
            {
                using (var sqlCommand = new SqlCommand(_getListCommand, sqlConnection))
                {
                    sqlConnection.Open();

                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                CustomerOrderDetailModel customerOrderDetailModel = new CustomerOrderDetailModel()
                                {
                                    OrderId = (int)sqlDataReader["order_id"],
                                    CustomerId = (int)sqlDataReader["customer_id"],
                                    ProductId = (int)sqlDataReader["product_id"],
                                    FirstName = sqlDataReader["first_name"].ToString(),
                                    LastName = sqlDataReader["last_name"].ToString(),
                                    ProductName = sqlDataReader["product_name"].ToString(),
                                    ListPrice = (decimal)sqlDataReader["list_price"]
                                };
                                _customerOrderDetailModels.Add(customerOrderDetailModel);
                            }
                        }
                    }
                }
            }
            return _customerOrderDetailModels;
        }
    }
}
