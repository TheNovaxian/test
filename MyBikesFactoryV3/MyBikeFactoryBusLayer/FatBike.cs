using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeFactoryBusLayer
{

    [Serializable] //Allows the serialization of Roadbike
    public class FatBike : Bike // FatBike class inheriting from the Bike clas
    {
        // Private field specific to FatBike
        private int tireWidth;

        // Public property for accessing the tire width of the FatBike
        public int Width
        {
            get { return this.tireWidth; }
            set { this.tireWidth = value; }
        }


        // Default constructor for FatBike
        public FatBike() : base()
        {
            this.tireWidth = 0;
            
        }

        // Constructors with different parameter combinations
        // Each constructor initializes the inherited fields from the Bike class
        // and sets the specific fields for FatBike

        public FatBike(long serial_number, string make) : base(serial_number, make)
        {
            this.tireWidth = 0;
           
        }

        public FatBike(long serial_number, string make, string model) : base(serial_number, make, model)
        {
            this.tireWidth = 0;
           
        }

        public FatBike(long serial_number, string make, string model, EnumBikeType type) : base(serial_number, make, model, type)
        {
            this.tireWidth = 0;
         
        }

        public FatBike(long serial_number, string make, string model, double speed, EnumBikeType type)
            : base(serial_number, make, model, speed, type)
        {
            this.tireWidth = 0;
           
        }

        public FatBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color)
          : base(serial_number, make, model, type, speed, color)
        {
            this.tireWidth = 0;
            
        }

        public FatBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate)
            : base(serial_number, make, model, type, speed, color, frame, madeDate)
        {
            this.tireWidth = 0;
           
        }

        public FatBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes)
             : base(serial_number, make, model, type, speed, color, frame, madeDate, brakes)
        {
            this.tireWidth = 0;
           
        }

        public FatBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes, int tirewidth)
            : base(serial_number, make, model, type, speed, color, frame, madeDate, brakes)
        {
            this.tireWidth = tirewidth;
           
        }


        // Method to get the state of the FatBike
        public override string GetState()
        {
            string state;
            //calls basic attributes of bike and adds fatbike specific features
            state = base.GetState() + "|Tire Width: " + this.tireWidth ;
            return state;
        }

        // Override the ToString() method to provide a string representation of the FatBike
        public override string ToString()
        {
            return base.ToString() + "|Tire Width: " + this.tireWidth;
        }


        // Override the SpeedUp method to limit the speed based on the maximum speed of the FatBike
        public override void SpeedUp(double newSpeed)
        {
            if (this.Speed + newSpeed <= GetMaxSpeed())
            {
                this.Speed += newSpeed;
            }
            else
            {
                this.Speed = this.Speed;
            }
        }
    }
}
