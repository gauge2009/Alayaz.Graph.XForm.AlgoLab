using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Alayaz.Graph.XForm.AlgoLab.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}
