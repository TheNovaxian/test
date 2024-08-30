using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeFactoryBusLayer
{
    // Interface to provide a common way for objects to provide a printable representation of themselves
    public interface IPrintable
    {
        // Abstract method to get the state of an object as a string
        public abstract string GetState();
    }
}
