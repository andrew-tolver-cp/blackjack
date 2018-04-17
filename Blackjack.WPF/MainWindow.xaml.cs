using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Blackjack.BL.Services;
using Blackjack.Models;

namespace Blackjack.WPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ICallService _callService = new CallService();
    private NetworkCall _displayCall;

    public MainWindow()
    {
      InitializeComponent();

      FetchData();

      ShowData();
    }

    private void FetchData()
    {
      _displayCall = _callService.GetCall(0);
    }

    private void ShowData()
    {
      // Display data.
    }
  }
}
