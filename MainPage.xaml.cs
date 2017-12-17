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
        int rowNo1=-0,rowNo2 = 0,rowNo3 = 0,rowNo4 = 0, rowNo5 = 0, rowNo6 = 0,rowNo7 =0;
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
            collNo = 1;
            rowNo1 = rowNo1 + 2;
            if(rowNo1 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C1R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C1R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

           else if (rowNo1 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C1R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C1R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

           else if (rowNo1 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C1R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C1R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo1 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C1R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C1R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo1 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C1R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C1R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo1 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C1R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C1R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece1.StrokeThickness = 0;
                enterPiece1.Fill = new SolidColorBrush(color: Windows.UI.Colors.White) ;
                turnCount--;
            }

            turnCount++;

        }

        private void Clicked2(object sender, PointerRoutedEventArgs e)
        {
            collNo = 3;
            rowNo2 = rowNo2 + 2;

            if (rowNo2 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C3R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C3R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo2 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C3R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C3R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo2 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C3R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C3R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo2 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C3R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C3R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo2 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C3R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C3R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo2 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C3R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C3R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece2.StrokeThickness = 0;
                enterPiece2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            turnCount++;
        }

        private void Clicked3(object sender, PointerRoutedEventArgs e)
        {
            collNo = 5;
            rowNo3 = rowNo3 + 2;
            if (rowNo3 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C5R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C5R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo3 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C5R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C5R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo3 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C5R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C5R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo3 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C5R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C5R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo3 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C5R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C5R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo3 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C5R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C5R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece3.StrokeThickness = 0;
                enterPiece3.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            turnCount++;
        }

        private void Clicked4(object sender, PointerRoutedEventArgs e)
        {
            collNo = 7;
            rowNo4 = rowNo4 + 2;
            if (rowNo4 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C7R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C7R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo4 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C7R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C7R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo4 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C7R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C7R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo4 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C7R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C7R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo4 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C7R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C7R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo4 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C7R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C7R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece4.StrokeThickness = 0;
                enterPiece4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            turnCount++;
        }

        private void Clicked5(object sender, PointerRoutedEventArgs e)
        {
            collNo = 9;
            rowNo5 = rowNo5 + 2;
            if (rowNo5 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C9R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C9R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo5 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C9R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C9R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo5 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C9R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C9R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo5 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C9R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C9R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo5 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C9R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C9R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo5 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C9R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C9R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece5.StrokeThickness = 0;
                enterPiece5.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            turnCount++;
        }

        private void Clicked6(object sender, PointerRoutedEventArgs e)
        {
            collNo = 11;
            rowNo6 = rowNo6 + 2;
            if (rowNo6 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C11R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C11R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo6 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C11R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C11R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo6 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C11R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C11R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo6 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C11R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C11R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo6 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C11R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C11R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo6 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C11R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C11R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece6.StrokeThickness = 0;
                enterPiece6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            turnCount++;
        }

        private void Clicked7(object sender, PointerRoutedEventArgs e)
        {
            collNo = 13;
            rowNo7 = rowNo7 + 2;
            if (rowNo7 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C13R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C13R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo7 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C13R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C13R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo7 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C13R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C13R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo7 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C13R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C13R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo7 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C13R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C13R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else if (rowNo7 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C13R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                }
                else
                {
                    C13R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                }
            }

            else
            {
                enterPiece7.StrokeThickness = 0;
                enterPiece7.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            turnCount++;
        }


    }
}
