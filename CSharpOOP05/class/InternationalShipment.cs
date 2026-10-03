using CSharpOOP05.@class;
using CSharpOOP05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string _destinationCountry = string.Empty;
        private decimal _customsFee;

        public string DestinationCountry
        {
            get => _destinationCountry;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get => _customsFee;
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5m) + CustomsFee;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        // GenerateCustomsReport()
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating customs report...");
        }

        // PrintShipment() ← Country + CustomsFee
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"  TrackingCode       : {TrackingCode}");
            Console.WriteLine($"  Description        : {Description}");
            Console.WriteLine($"  Weight             : {Weight}");
            Console.WriteLine($"  DeliveryFee        : {DeliveryFee:C}");
            Console.WriteLine($"  DestinationCountry : {DestinationCountry}");
            Console.WriteLine($"  CustomsFee         : {CustomsFee:C}");
            Console.WriteLine($"  Destination        : {Destination.GetFullAddress()}");
            Console.WriteLine($"  EstimatedCost      : {EstimatedCost:C}");

        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
