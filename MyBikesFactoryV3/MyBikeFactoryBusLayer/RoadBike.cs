using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeFactoryBusLayer
{
    [Serializable] //Allows serialization of Roadbike
    public class RoadBike : Bike //inheriting from the Bike class
    {
        // Private field specific to RoadBike
        private double Seat_height;


        // Public property for accessing the seat height of the RoadBike
        public double SeatHeight
        {
            get { return this.Seat_height; }
            set { this.Seat_height = value; }
        }


        // Default constructor for RoadBike
        public RoadBike() : base()
        {
            this.Seat_height = 0;
         
        }

        // Constructors with different parameter combinations
        // Each constructor initializes the inherited fields from the Bike class
        // and sets the specific fields for RoadBike
        //static polymorphism
        public RoadBike(long serial_number, string make) : base(serial_number, make)
        {
            this.Seat_height = 0;
         
        }

        public RoadBike(long serial_number, string make, string model) : base(serial_number, make, model)
        {
            this.Seat_height = 0;
          
        }

        public RoadBike(long serial_number, string make, string model, EnumBikeType type) : base(serial_number, make, model, type)
        {
            this.Seat_height = 0;
           
        }

        public RoadBike(long serial_number, string make, string model, double speed, EnumBikeType type)
            : base(serial_number, make, model, speed, type)
        {
            this.Seat_height = 0;
          
        }

        public RoadBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color )
          : base(serial_number, make, model, type, speed, color )
        {
            this.Seat_height = 0;
            
        }

        public RoadBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color,  EnumFrameType frame)
            : base(serial_number, make, model,type, speed, color,  frame)
        {
            this.Seat_height = 0;
          
        }

        public RoadBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate)
             : base(serial_number, make, model, type, speed, color, frame, madeDate )
        {
            this.Seat_height = 0;
            
        }

        public RoadBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes)
            : base(serial_number, make, model,type, speed, color, frame, madeDate, brakes)
        {
            this.Seat_height = 0;
          
        }

        public RoadBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes, double seat_height)
         : base(serial_number, make, model,type, speed, color, frame, madeDate, brakes)
        {
            this.Seat_height = seat_height;

        }



        public override string GetState()
        {
            string state;
            state = base.GetState() + "|Seat Height: " + this.Seat_height ;
            return state;
        }

        public override string ToString()
        {
            //calls the generic bike properties and add the properties of road bike
            string state;
            state = base.GetState() + "|Seat Height: " + this.Seat_height;
            return state;
        }

        //setting max speed for road bike to 40
        //example of polymorphism
        public override double GetMaxSpeed()
        {

            double maxSpeed = 40;
            return maxSpeed;
        }

        //public virtual double GetMaxSpeed(double speed)
        //{

        //    return 40;
        //}
        public override void SpeedUp(double newSpeed)
        {
            if (Speed + newSpeed <= GetMaxSpeed())
            {
                Speed += newSpeed;
            }
        }

    }
}

