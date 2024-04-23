using KB13478_WpfApp1.Infrastructure;
using System.Collections.ObjectModel;

namespace KB13478_WpfApp1.Model;
internal class Customer : ObservableObject
{
    private String _id = "";
    public String ID
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(); }
    }

    private String _familyName = "";
    public String FamilyName
    {
        get { return _familyName; }
        set { _familyName = value; OnPropertyChanged(); }
    }

    private String _givenName = "";
    public String GivenName
    {
        get { return _givenName; }
        set { _givenName = value; OnPropertyChanged(); }
    }

    public String CustomerName => $"{_familyName} {_givenName}";

    private ObservableCollection<Purchase> _purchases = new();
    public ObservableCollection<Purchase> Purchases
    {
        get { return _purchases; }
        set { _purchases = value; OnPropertyChanged(); }
    }

    public Customer()
    {
    }
}