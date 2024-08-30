using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace MyBikeFactoryBusLayer
{

    [Serializable] ///allows serialization of mountainbike
    public class MountainBike : Bike ///inheritance of bike attributes
    {

        //Data member: (private fields)
        //Fields
        private EnumSuspension suspension;
        private double heightFromGround;


        //public properties
        public double Height  //Height from ground
        {
            get { return this.heightFromGround; }
            set { this.heightFromGround = value; }
        }

        public EnumSuspension Suspension  //MountainBike suspension of type enum
        {
            get { return this.suspension;}
            set { this.suspension = value;}
        }

        //public default constructor (constructor without parameters)
        public MountainBike() : base()  //inhertance of bike attributes
        { 
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        // Constructors with different parameter combinations
        // Each constructor initializes the inherited fields from the Bike class
        // and sets the specific fields for MountainBike
        public MountainBike(long serial_number, string make) : base(serial_number,make)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model) : base(serial_number, make, model)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model, EnumBikeType type) : base(serial_number, make, model,type)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model, double speed, EnumBikeType type)
            : base(serial_number, make, model, speed,type)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color)
          : base(serial_number, make, model,type, speed, color)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate)
            : base(serial_number, make, model,type, speed, color, frame, madeDate)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes)
             : base(serial_number, make, model,type, speed, color, frame, madeDate,brakes)
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes, EnumSuspension suspension)
            : base(serial_number, make, model,type, speed, color, frame, madeDate, brakes)
        {
            this.heightFromGround = 0;
            this.suspension = suspension;
        }

        public MountainBike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes, EnumSuspension suspension, double heightFromGround)
          : base(serial_number, make, model,type, speed, color, frame, madeDate, brakes)
        {
            this.heightFromGround = heightFromGround;
            this.suspension = suspension;
        }

        public override string GetState()
        {
            string state;
            state = base.GetState() + "|Height: " + this.heightFromGround + "|Suspension: " + this.suspension;
            return state;
        }

        public override string ToString()
        {           //Calls the basic bike features then add mountain bike specific features
            return base.ToString() + "|Height: " + this.heightFromGround + "|Suspension: " + this.suspension;
        }


        // Override the SpeedUp method to limit the speed based on the maximum speed of the MountainBike
        public override void SpeedUp(double newSpeed)
        {
          if(this.Speed + newSpeed <= GetMaxSpeed())
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
