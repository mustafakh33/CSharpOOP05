using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05.@class
{
    public class DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress()
        {
            City = "Unknown";
            Street = "Unknown";
            BuildingNumber = 0;
        }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{City}, {Street}, {BuildingNumber}";
        }
    }
}
