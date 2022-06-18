using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
   abstract class Vehicle: IWithEngine
    {
        public string Id { get; set; }

        public abstract void Start();
        public abstract void Stop();
        public abstract void GoBackWard();
        public abstract void GoForWard();
        public abstract void ShitUp();
        public abstract void ShitDown();

        public void StartEngine()
        {
        }

        public void StopEngine()
        {
        }
    }
}
