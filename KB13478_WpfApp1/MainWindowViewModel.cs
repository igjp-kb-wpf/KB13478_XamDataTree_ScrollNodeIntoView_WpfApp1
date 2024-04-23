using KB13478_WpfApp1.Infrastructure;
using KB13478_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB13478_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    private CustomerAndPurchaseCollection _customersAndPurchases = new();
    public CustomerAndPurchaseCollection CustomersAndPurchases
    {
        get { return _customersAndPurchases; }
        set { _customersAndPurchases = value; OnPropertyChanged(); }
    }

    public MainWindowViewModel()
    {
    }
}