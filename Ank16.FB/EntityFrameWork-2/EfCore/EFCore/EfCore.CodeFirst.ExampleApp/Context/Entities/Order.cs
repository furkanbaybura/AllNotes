﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ExampleApp.Context.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public OrderShipping? OrderShipping { get; set; }
    }
}
