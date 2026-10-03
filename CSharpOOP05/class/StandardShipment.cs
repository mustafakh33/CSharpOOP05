using CSharpOOP05.@class;
using CSharpOOP05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight,  decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
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
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"  TrackingCode : {TrackingCode}");
            Console.WriteLine($"  Description  : {Description}");
            Console.WriteLine($"  Weight       : {Weight}");
            Console.WriteLine($"  DeliveryFee  : {DeliveryFee:C}");
            Console.WriteLine($"  Destination  : {Destination.GetFullAddress()}");
            Console.WriteLine($"  EstimatedCost: {EstimatedCost:C}");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}
