using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05.@class
{
    public abstract class Shipment
    {
        private string? _trackingCode;
        private string? _description;
        private decimal _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;
        // Static field 
        private static int _totalShipmentsCreated;
        public static int TotalShipmentsCreated
        {
            get => _totalShipmentsCreated;
        }

        // Constructor that receives only trackingCode and uses defaults
        public Shipment(string trackingCode): this( trackingCode,"Unknown",1,50,new DeliveryAddress())
        {
        }

        // Constructor that receives all values including destination
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            _totalShipmentsCreated++;
        }

        // TrackingCode: read-only from outside, cannot be null/empty/whitespace
        public string TrackingCode
        {
            get => _trackingCode;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }

        // Description: read/write with validation (cannot be null/empty/whitespace)
        public string Description
        {
            get => _description;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        // Weight: read/write with validation (must be > 0)
        public decimal Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        // update Weight(decimal weight): updates the weight only when weight is greater than 0.
        public void UpdateWeight(decimal weight)
        {
            if (weight > 0m)
            {
                Weight = weight;
            }
        }
        // update Weight(decimal weight, decimal extraPackingWeight): updates the weight only when weight is greater than 0 and extraPackingWeight is greater than or equal to 0.
        public void UpdateWeight(decimal weight, decimal extraPackingWeight)
        {
            if (weight > 0m && extraPackingWeight >= 0m)
            {
                Weight = weight + extraPackingWeight;
            }
        }

        // DeliveryFee: public getter, private setter; must be > 0
        public decimal DeliveryFee
        {
            get => _deliveryFee;
            private set
            {
                if (value > 0m)
                {
                    _deliveryFee = value;
                }
            }
        }
        
        // Destination: public read/write property
        public DeliveryAddress Destination
        {
            get => _destination;
            set => _destination = value;
        }

        // EstimatedCost: calculated on request (not stored)
        public abstract decimal EstimatedCost { get; }

        // UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0.
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0m)
            {
                DeliveryFee = newFee;
            }
        }

        // PrintShipment(): prints all shipment information, including the estimated cost.
        public abstract void PrintShipment();

        // Object Copying
        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }
        // Shallow Copy
        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }
        // Deep Copy
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                Destination.City,
                Destination.Street,
                Destination.BuildingNumber
            );

            return copy;
        }

    }
}
