using CSharpOOP05.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base( 
             trackingCode,
             description,
             weight,
             deliveryFee,
             destination,
             destinationCountry,
             customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generating priority customs report...");
        }
    }
}
