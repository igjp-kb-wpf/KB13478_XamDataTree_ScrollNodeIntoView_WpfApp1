using Infragistics.Controls.Menus;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB13478_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        var vm = (MainWindowViewModel)DataContext;
        var purchase = vm.CustomersAndPurchases.Last().Purchases.Last();
        var node = xamDataTree1.GetNodesFromItems([purchase], true).FirstOrDefault();
        if(node != null)
        {
            xamDataTree1.ScrollNodeIntoView(node);
            xamDataTree1.SelectedDataItems = [purchase];
            node.IsActive = true;
        }
    }
}
