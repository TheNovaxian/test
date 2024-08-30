using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using MyBikeFactoryBusLayer;

namespace MyBikeFactoryDataLayer

{
    public class FileManager
    {
        // Path to the XML file
        private static String xmlFilePath = @"../../../library.xml";

        // Method to write a list of bikes to an XML file
        public static void WriteToXmlFile(List<Bike> listOfBikes)
        {
            // Create a new XML writer
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);
            // Create a new XML serializer for the list of bikes
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));
            // Serialize the list of bikes to the XML file
            xmlSerializer.Serialize(xmlWriter, listOfBikes);
            // Close the XML writer
            xmlWriter.Close();
        }


        // Method to read a list of bikes from an XML file
        public static List<Bike> ReadFromXmlFile()
        {
            List<Bike> listFromFile = new List<Bike>();
            // Create a new stream reader for the XML file
            StreamReader streamReader = new StreamReader(xmlFilePath);
            // Create a new XML serializer for the list of bikes
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));
            // Deserialize the XML file to a list of bikes
            listFromFile = (List<Bike>)xmlSerializer.Deserialize(streamReader);
            // Close the stream reader
            streamReader.Close();

            if (listFromFile != null) return listFromFile;// Return the list of bikes from the XML file
            else return null;
        }
    }
}
