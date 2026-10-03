using CSharpOOP05.@class;
using CSharpOOP05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05.ExtensionMethods
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;

            return $"{shipment.TrackingCode} | " +
                   $"{shipment.GetType().Name.Replace("Shipment", "")} | " +
                   $"{shipment.Weight} KG | " +
                   $"{trackable.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;

            return trackable.GetTrackingStatus() == "Delivered";
        }
    }
}
