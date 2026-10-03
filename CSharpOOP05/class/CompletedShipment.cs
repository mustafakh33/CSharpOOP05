using CSharpOOP05.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5m);
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode : {TrackingCode}");
            Console.WriteLine($"Description  : {Description}");
            Console.WriteLine($"Weight       : {Weight}");
            Console.WriteLine($"DeliveryFee  : {DeliveryFee:C}");
            Console.WriteLine($"Destination  : {Destination.GetFullAddress()}");
            Console.WriteLine($"EstimatedCost: {EstimatedCost:C}");
        }
    }
}
