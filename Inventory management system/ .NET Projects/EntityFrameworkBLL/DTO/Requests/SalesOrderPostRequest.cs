using System;
using System.Collections.Generic;

namespace EntityFrameworkBLL.DTO.Requests
{
    public class SalesOrderPostRequest
    {
        public int WarehouseId { get; set; }
        public int? ShipInfoId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        
        public IEnumerable<ProductSubRequest> products { get; set; }
    }
}
