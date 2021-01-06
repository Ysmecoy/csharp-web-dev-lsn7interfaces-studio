using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        public string Spin();
        public void StoreData();
        public string ReportStatus();
        public void ReadData();
        public double GetRemainingCapacity();
    }
}
