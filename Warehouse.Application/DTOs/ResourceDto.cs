using System;
using System.Collections.Generic;
using System.Linq;


namespace Warehouse.Application.DTOs
{
    public class ResourceDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        //public Balance? Balance { get; set; }

        //public IncomingResource[]? IncomingResource { get; set; }

        //public ShipmentResource[]? ShipmentResource { get; set; }
    }
}
