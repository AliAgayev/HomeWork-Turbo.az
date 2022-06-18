using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    class Model
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Marka MarkaId { get; set; }
        public string Desc { get; set; }
    }
}
