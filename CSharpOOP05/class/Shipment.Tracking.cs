using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP05.@class
{
    public abstract partial class Shipment
    {
        private string _trackingStatus = "In Transit";
        partial void OnTrackingStatusChanged(string newStatus);

        public string GetTrackingStatus()
        {
            return _trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
                throw new ArgumentException("Tracking status cannot be empty.");

            _trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
    }
}
