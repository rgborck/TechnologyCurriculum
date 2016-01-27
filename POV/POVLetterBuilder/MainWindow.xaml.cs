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

namespace POVLetterBuilder
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow() {
      InitializeComponent();
    }

    private void GridCellMouseUp(object sender, MouseButtonEventArgs e)
    {
      var point = Mouse.GetPosition(MyGrid);

      var row = 0;
      var col = 0;
      var accumulatedHeight = 0.0;
      var accumulatedWidth = 0.0;

      // calc row mouse was over
      foreach (var rowDefinition in MyGrid.RowDefinitions) {
        accumulatedHeight += rowDefinition.ActualHeight;
        if (accumulatedHeight >= point.Y)
          break;
        row++;
      }

      // calc col mouse was over
      foreach (var columnDefinition in MyGrid.ColumnDefinitions) {
        accumulatedWidth += columnDefinition.ActualWidth;
        if (accumulatedWidth >= point.X)
          break;
        col++;
      }

      MyGrid.Background = MyGrid.Background.Equals(Brushes.Black) ? Brushes.White : Brushes.Black;
    }
  }
}
