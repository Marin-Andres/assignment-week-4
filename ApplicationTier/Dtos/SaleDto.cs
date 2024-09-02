﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Dtos
{
    public class SaleDto
    {
        public int Id { get; set; }

        public int? CustomerId {  get; set; } 

        public int? ProductId { get; set; }

        public int? StoreId { get; set; }

        public DateTime? DateSold { get; set; }

        public decimal? TotalSale { get; set; }

    }
}
