using CSharpOOP05.@class;
using CSharpOOP05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {

        private decimal _extraFee;

        public decimal ExtraFee
        {
            get => _extraFee;
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5m) + ExtraFee;
            }
        }

       public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"  TrackingCode : {TrackingCode}");
            Console.WriteLine($"  Description  : {Description}");
            Console.WriteLine($"  Weight       : {Weight}");
            Console.WriteLine($"  DeliveryFee  : {DeliveryFee:C}");
            Console.WriteLine($"  ExtraFee     : {ExtraFee:C}");
            Console.WriteLine($"  Destination  : {Destination.GetFullAddress()}");
            Console.WriteLine($"  EstimatedCost: {EstimatedCost:C}");

        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
