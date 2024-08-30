using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeFactoryBusLayer
{
    public interface IMovable
    {
       //Abstract class -  declared but not implemented. They are implememented in sub classes

        public abstract double GetMaxSpeed();

   

        public abstract void SpeedUp(double newspeed);
    }
}
