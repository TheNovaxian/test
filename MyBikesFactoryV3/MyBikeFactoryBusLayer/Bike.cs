
using System.Xml.Serialization;

namespace MyBikeFactoryBusLayer
{
    // Enum defining different types of bikes
    public enum EnumBikeType
    {
        FatBike,
        MountainBike,
        RoadBike,
        Undefined

    }

    //Implementing the base class for all bikes

    [XmlInclude(typeof(MountainBike))] // Allow serialization of MountainBike objects
    [XmlInclude(typeof(RoadBike))] // Allow serialization of RoadBike objects
    [XmlInclude(typeof(FatBike))] // Allow serialization of FatBike objects
    public abstract class Bike : Object, IMovable, IPrintable
    {
        //Data member: (private fields)
        //Fields
        //encapsulation
        private long serial_number;
        private string make;
        private string model;
        private double speed;
        private EnumColor color;
        private Date madeDate;
        private EnumFrameType frame;
        private EnumBrakes brakes;
        private EnumBikeType type;


        // Properties
        public long SerialNumber
        { 
        get { return this.serial_number; }
        set { this.serial_number = value; } 
        }

        public string Make  //encapsulation , only way to access private field make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model 
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        

        public EnumColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public EnumFrameType Frame
        {
            get { return this.frame; }
            set { this.frame = value; }
        }

        public Date MadeDate
        {
            get { return this.madeDate; }
            set { this.madeDate = value; }
        }

        public EnumBrakes Brakes
        {
            get { return this.brakes; }
            set { this.brakes = value; }
        }

        public EnumBikeType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Methods (functions) Member
        public Bike()
        {
            this.serial_number = 0;
            this.make = string.Empty;
            this.model = string.Empty;
            this.speed = 0;
            this.color = EnumColor.Undefined;
            this.frame = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;
            this.type = EnumBikeType.Undefined;

        }

        public Bike(long serial_number, string make)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = string.Empty;
            this.speed = 0;
            this.color = EnumColor.Undefined;
            this.frame = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;
            this.type = EnumBikeType.Undefined;

        }

        public Bike(long serial_number, string make, string model)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = EnumBikeType.Undefined;
            this.speed = 0;
            this.color = EnumColor.Undefined;
            this.frame = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;


        }
        public Bike(long serial_number, string make, string model, EnumBikeType type)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = type;
            this.speed = 0;
            this.color = EnumColor.Undefined;
            this.frame = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;
            

        }

        public Bike(long serial_number, string make, string model, double speed, EnumBikeType type)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = type;
            this.speed = speed;
            this.color = EnumColor.Undefined;
            this.frame = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;
           

        }

        public Bike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = type;
            this.speed = speed;
            this.color = color;
            this.frame = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;
           

        }

        public Bike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = type;
            this.speed = speed;
            this.color = color;
            this.frame = frame;
            this.madeDate = new Date();
            this.brakes = EnumBrakes.Undefined;
            

        }

        public Bike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame,Date madeDate)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = type;
            this.speed = speed;
            this.color = color;
            this.frame = frame;
            this.madeDate = madeDate;
            this.brakes = EnumBrakes.Undefined;
            

        }

        public Bike(long serial_number, string make, string model, EnumBikeType type, double speed, EnumColor color, EnumFrameType frame, Date madeDate, EnumBrakes brakes)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.model = model;
            this.type = type;
            this.speed = speed;
            this.color = color;
            this.frame = frame;
            this.madeDate = madeDate;
            this.brakes = brakes;
            

        }


        public virtual string GetState()
        {
            string state;
            state = "Serial#: " + this.serial_number + "|Make: " + this.make + " |Model: " + this.model + "|Type: " + this.type + " |Speed: " + this.speed + " |Color: " + this.color
                + " |Frame: " + this.frame + " |Brakes: " + this.brakes + " |Made Date: " + this.madeDate.GetDateState();
            return state;
        }

        public override string ToString() // Override the ToString() method to return the same string as GetState
        {
            string state;
            state = "Serial#: " + this.serial_number + "|Make: " + this.make + " |Model: " + this.model + "|Type: " + this.type + " |Speed: " + this.speed + " |Color: " + this.color
                + " |Frame: " + this.frame + " |Brakes: " + this.brakes + " |Made Date: " + this.madeDate.GetDateState();
            return state;
        }

      
        //overriding of the abstract class getmaxspeed to initialize a max speed in bikes
        //polymorphism
        public virtual double GetMaxSpeed()  // not mandatory to be overwritten
        {
            double maxSpeed = 20;
            return maxSpeed;
        }


        // Abstract method to speed up the bike (implemented in subclasses) must be overwritten
        public abstract void SpeedUp(double newSpeed); // implemented in sub classes

      
    }
}
