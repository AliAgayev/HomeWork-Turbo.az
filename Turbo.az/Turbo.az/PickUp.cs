using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    class PickUp: Car
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Car CarId { get; set; }
    }
}
