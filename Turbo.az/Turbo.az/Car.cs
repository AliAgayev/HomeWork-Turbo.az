using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    class Car:Vehicle
    {
        public  Car()
        {
            Id = Guid.NewGuid().ToString();
            Models = new List<Model>();
            Markas = new List<Marka>();
        }

        public string Name { get; set; }
        public Model ModelId { get; set; }
        public Marka MarkaId { get; set; }
        public string FuelType { get; set; }
        public string SpeedBox { get; set; }
        public string Color { get; set; }
        public double Milleage { get; set; }
        public int Power { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Marka> Markas { get; set; }
        public List<Model> Models { get; set; }

        public override void GoBackWard()
        {          
        }

        public override void GoForWard()
        {
        }

        public override void ShitDown()
        {
        }

        public override void ShitUp()
        {
        }

        public override void Start()
        {
        }

        public override void Stop()
        {
        }
    }
}
