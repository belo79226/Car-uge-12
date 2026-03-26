using System;
using System.Collections.Generic;
using System.Text;

namespace Car_uge_12
{
    public interface ISellable
    {
        double Price { get; }
        string GetSalesSummary();
    }
}
