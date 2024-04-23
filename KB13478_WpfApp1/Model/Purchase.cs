using KB13478_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB13478_WpfApp1.Model;
internal class Purchase : ObservableObject
{
    private String _orderId = "";
    public String OrderID
    {
        get { return _orderId; }
        set { _orderId = value; OnPropertyChanged(); }
    }

    private String _productName = "";
    public String ProductName
    {
        get { return _productName; }
        set { _productName = value; OnPropertyChanged(); }
    }

    public Purchase()
    {
    }
}