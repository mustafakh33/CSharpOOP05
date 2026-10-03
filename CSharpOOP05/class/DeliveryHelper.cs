using CSharpOOP05.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            shipment.PrintShipment();
        }
    }
}
