using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace connect4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int turnCount = 1;
        int collNo=0;
        int rowNo1=-0,rowNo2 = 0,rowNo3 = 0,rowNo4 = 0, rowNo5 = 0, rowNo6 = 0;
        Ellipse piece;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PointrIn(object sender, PointerRoutedEventArgs e)
        {
            var ellipse = sender as Ellipse;
            if (turnCount % 2 == 0)
            {
                ellipse.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
            }
            else
            {
                ellipse.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
            }
        }

        private void PointrOut(object sender, PointerRoutedEventArgs e)
        {
            var ellipse = sender as Ellipse;
            ellipse.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
        }

        private void Clicked(object sender, PointerRoutedEventArgs e)
        {
            turnCount++;
            
        }

        private void Clicked1(object sender, PointerRoutedEventArgs e)
        {
            collNo = 2;
            rowNo1 = rowNo1 + 2;
            if (turnCount % 2 == 0)
            {
                C2R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
            }
            else
            {
                C2R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
            }
            turnCount++;

        }

        private void Clicked2(object sender, PointerRoutedEventArgs e)
        {
            collNo = 3;
            turnCount++;
        }

        private void Clicked3(object sender, PointerRoutedEventArgs e)
        {
            collNo = 5;
            turnCount++;
        }

        private void Clicked4(object sender, PointerRoutedEventArgs e)
        {
            collNo = 7;
            turnCount++;
        }

        private void Clicked5(object sender, PointerRoutedEventArgs e)
        {
            collNo = 9;
            turnCount++;
        }

        private void Clicked6(object sender, PointerRoutedEventArgs e)
        {
            collNo = 11;
            turnCount++;
        }

        private void Clicked7(object sender, PointerRoutedEventArgs e)
        {
            collNo = 13;
            turnCount++;
        }


    }
}
