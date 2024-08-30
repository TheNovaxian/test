using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBikeFactoryBusLayer;

namespace MyBikeFactoryDataLayer
{

    // DataCollection class to manage a collection of bikes
    public class DataCollection
    {

        // Static list of bikes to store the bikes
        private static List<Bike> listOfBikes = new List<Bike>();


        // Property to access the list of bikes
        public static List<Bike> ListOfBikes
        {
            get { return listOfBikes; }
               
            set { listOfBikes = value; }
        }

        // Method to add a bike to the list
        public static void Add(Bike currentBike)
        {
          
                listOfBikes.Add(currentBike);
          

        }

        // Method to remove a bike from the list
        public static void Remove(Bike currentBike)
        {
         
            
                listOfBikes.Remove(currentBike);
          
        }

        // Method to remove a bike at a specific index from the list
        public static void RemoveAt(int currentIndex)
        {
            ListOfBikes.RemoveAt(currentIndex);
        }


        // Method to insert a bike at a specific index in the list
        public static void InsertAt(int currentIndex, Bike currentBike)
        {
            listOfBikes.Insert(currentIndex, currentBike);
        }

        // Method to remove and add a bike at a specific index in the list
        public static void RemoveAdd(int currentIndex)
        {
                listOfBikes.RemoveAt(currentIndex);
            

        }

        // Method to get the list of bikes
        public static List<Bike> GetBikeList()
        {
           
                return listOfBikes;
            
        }

        // Method to search for a bike by serial number
        public static Bike Search(int key)
        {
            Bike BikeToSearch = null;
            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike.SerialNumber == key)
                {
                    BikeToSearch = currentBike;
                    break;
                }
            }

            return BikeToSearch;
        }


        // Method to get a list of mountain bikes from the list of bikes
        public static List<MountainBike> GetMountainBikeList()
        {
            List<MountainBike> listOfMBike = new List<MountainBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is MountainBike)
                {
                    MountainBike currentMBike = new MountainBike();
                    currentMBike = (MountainBike)currentBike;

                    listOfMBike.Add(currentMBike);
                }
            }


            return listOfMBike;
        }

        // Method to get a list of road bikes from the list of bikes
        public static List<RoadBike> GetRoadBikeList()
        {
            List<RoadBike> listOfRBike = new List<RoadBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is RoadBike)
                {
                    RoadBike currentRBike = new RoadBike();
                    currentRBike = (RoadBike)currentBike;

                    listOfRBike.Add(currentRBike);
                }
            }


            return listOfRBike;
        }

        // Method to get a list of fat bikes from the list of bikes
        public static List<FatBike> GetFatBikeList()
        {
            List<FatBike> listOfFBike = new List<FatBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is FatBike)
                {
                    FatBike currentFBike = new FatBike();
                    currentFBike = (FatBike)currentBike;

                    listOfFBike.Add(currentFBike);
                }
            }


            return listOfFBike;
        }

    }
}
