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
{//Class
    // Antaine O Conghaile (G00347577)

    public sealed partial class MainPage : Page
    {//main

        //Variables
        int turnCount = 1;
        int collNo = 0;
        int rowNo1 = -0, rowNo2 = 0, rowNo3 = 0, rowNo4 = 0, rowNo5 = 0, rowNo6 = 0, rowNo7 = 0;
        int[,][,] board;
        int P11 = 0, P21 = -7, P31 = -14, P41 = -21, P51 = -28, P61 = -35;
        int P12 = -1, P22 = -8, P32 = -15, P42 = -22, P52 = -29, P62 = -36;
        int P13 = -2, P23 = -9, P33 = -16, P43 = -23, P53 = -30, P63 = -37;
        int P14 = -3, P24 = -10, P34 = -17, P44 = -24, P54 = -31, P64 = -38;
        int P15 = -4, P25 = -11, P35 = -18, P45 = -25, P55 = -32, P65 = -39;
        int P16 = -5, P26 = -12, P36 = -19, P46 = -26, P56 = -33, P66 = -40;
        int P17 = -6, P27 = -13, P37 = -20, P47 = -27, P57 = -34, P67 = -41;
        Ellipse piece;
        Boolean win = false;
        String winningPlayer;

     /*   public void generateLogicBoard()
        {
            int[,] board = new int[6, 7] {
                {P11,P12,P13,P14,P15,P16,P17},
                {P21,P22,P23,P24,P25,P26,P27},
                {P31,P32,P33,P34,P35,P36,P37},
                {P41,P42,P43,P44,P45,P46,P47},
                {P51,P52,P53,P54,P55,P56,P57},
                {P61,P62,P63,P64,P65,P66,P67} };
        }*/

        //Check for 4 in a row
        public void checkWin()
        {
            checkHorizontal();
            checkVertical();
            checkDiagonal();
            //if 4 in a row show winner
            if (win == true && turnCount % 2 == 0)
            {
                winningPlayer = "Player 2";
                winningScreen();
            }

            else if (win == true && turnCount % 2 != 0)
            {
                winningPlayer = "Player 1";
                winningScreen();
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        //mouse pointer enter piece show what colour (Who's turn)
        private void PointrIn(object sender, PointerRoutedEventArgs e)
        {
            var ellipse = sender as Ellipse;
            //player2
            if (turnCount % 2 == 0)
            {
                ellipse.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
            }
            //player1
            else
            {
                ellipse.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
            }
        }

        //Mouse pointer exit change back to white
        private void PointrOut(object sender, PointerRoutedEventArgs e)
        {
            var ellipse = sender as Ellipse;
            ellipse.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
        }

        //Click piece to add a chip to a collum
        //Add 2 to row num in order to keep track of the what row each collum has reached
        //if 2 goes into turn number its player 2s go
        //else it will be player 1s
        //give a value to the position 1 for player1 and  2 for player 2
        private void Clicked1(object sender, PointerRoutedEventArgs e)
        {
            collNo = 1;
            rowNo1 = rowNo1 + 2;
            if (rowNo1 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C1R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P11 = 2;
                }
                else
                {
                    C1R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P11 = 1;
                }


            }

            else if (rowNo1 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C1R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P21 = 2;
                }
                else
                {
                    C1R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P21 = 1;
                }

            }

            else if (rowNo1 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C1R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P31 = 2;
                }
                else
                {
                    C1R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P31 = 1;
                }

            }

            else if (rowNo1 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C1R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P41 = 2;
                }
                else
                {
                    C1R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P41 = 1;
                }

            }

            else if (rowNo1 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C1R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P51 = 2;
                }
                else
                {
                    C1R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P51 = 1;
                }

            }

            else if (rowNo1 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C1R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P61 = 2;
                }
                else
                {
                    C1R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P61 = 1;
                }

            }

            //stay white and decrement counter
            else
            {
                enterPiece1.StrokeThickness = 0;
                enterPiece1.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }

            //Check for win
            checkWin();
            turnCount++;

        }
        //Repeat for clicks 2-7 for the other colums

        private void Clicked2(object sender, PointerRoutedEventArgs e)
        {
            collNo = 3;
            rowNo2 = rowNo2 + 2;

            if (rowNo2 == 2)
            {
                if (turnCount % 2 == 0)
                {
                    C3R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P12 = 2;
                }
                else
                {
                    C3R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P12 = 1;
                }
            }

            else if (rowNo2 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C3R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P22 = 2;
                }
                else
                {
                    C3R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P22 = 1;
                }
            }

            else if (rowNo2 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C3R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P32 = 2;
                }
                else
                {
                    C3R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P32 = 1;
                }
            }

            else if (rowNo2 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C3R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P42 = 2;
                }
                else
                {
                    C3R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P42 = 1;
                }
            }

            else if (rowNo2 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C3R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P52 = 2;
                }
                else
                {
                    C3R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P52 = 1;
                }
            }

            else if (rowNo2 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C3R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P62 = 2;
                }
                else
                {
                    C3R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P62 = 1;
                }
            }

            else
            {
                enterPiece2.StrokeThickness = 0;
                enterPiece2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            checkWin();
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
                    P13 = 2;
                }
                else
                {
                    C5R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P13 = 1;
                }
            }

            else if (rowNo3 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C5R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P23 = 2;
                }
                else
                {
                    C5R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P23 = 1;
                }
            }

            else if (rowNo3 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C5R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P33 = 2;
                }
                else
                {
                    C5R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P33 = 1;
                }
            }

            else if (rowNo3 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C5R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P43 = 2;
                }
                else
                {
                    C5R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P43 = 1;
                }
            }

            else if (rowNo3 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C5R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P53 = 2;
                }
                else
                {
                    C5R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P53 = 1;
                }
            }

            else if (rowNo3 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C5R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P63 = 2;
                }
                else
                {
                    C5R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P63 = 1;
                }
            }

            else
            {
                enterPiece3.StrokeThickness = 0;
                enterPiece3.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            checkWin();
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
                    P14 = 2;
                }
                else
                {
                    C7R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P14 = 1;
                }
            }

            else if (rowNo4 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C7R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P24 = 2;
                }
                else
                {
                    C7R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P24 = 1;
                }
            }

            else if (rowNo4 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C7R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P34 = 2;
                }
                else
                {
                    C7R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P34 = 1;
                }
            }

            else if (rowNo4 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C7R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P44 = 2;
                }
                else
                {
                    C7R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P44 = 1;
                }
            }

            else if (rowNo4 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C7R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P54 = 2;
                }
                else
                {
                    C7R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P54 = 1;
                }
            }

            else if (rowNo4 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C7R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P64 = 2;
                }
                else
                {
                    C7R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P64 = 1;
                }
            }

            else
            {
                enterPiece4.StrokeThickness = 0;
                enterPiece4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            checkWin();
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
                    P15 = 2;
                }
                else
                {
                    C9R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P15 = 1;
                }
            }

            else if (rowNo5 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C9R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P25 = 2;
                }
                else
                {
                    C9R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P25 = 1;
                }
            }

            else if (rowNo5 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C9R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P35 = 2;
                }
                else
                {
                    C9R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P35 = 1;
                }
            }

            else if (rowNo5 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C9R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P45 = 2;
                }
                else
                {
                    C9R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P45 = 1;
                }
            }

            else if (rowNo5 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C9R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P55 = 2;
                }
                else
                {
                    C9R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P55 = 1;
                }
            }

            else if (rowNo5 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C9R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P65 = 2;
                }
                else
                {
                    C9R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P65 = 1;
                }
            }

            else
            {
                enterPiece5.StrokeThickness = 0;
                enterPiece5.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            checkWin();
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
                    P16 = 2;
                }
                else
                {
                    C11R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P16 = 1;
                }
            }

            else if (rowNo6 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C11R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P26 = 2;

                }
                else
                {
                    C11R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P26 = 1;
                }
            }

            else if (rowNo6 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C11R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P36 = 2;
                }
                else
                {
                    C11R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P36 = 1;
                }
            }

            else if (rowNo6 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C11R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P46 = 2;
                }
                else
                {
                    C11R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P46 = 1;
                }
            }

            else if (rowNo6 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C11R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P56 = 2;

                }
                else
                {
                    C11R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P56 = 1;
                }
            }

            else if (rowNo6 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C11R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P66 = 2;
                }
                else
                {
                    C11R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P66 = 1;
                }
            }

            else
            {
                enterPiece6.StrokeThickness = 0;
                enterPiece6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            checkWin();
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
                    P17 = 2;
                }
                else
                {
                    C13R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P17 = 1;
                }
            }

            else if (rowNo7 == 4)
            {
                if (turnCount % 2 == 0)
                {
                    C13R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P27 = 2;
                }
                else
                {
                    C13R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P27 = 1;
                }
            }

            else if (rowNo7 == 6)
            {
                if (turnCount % 2 == 0)
                {
                    C13R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P37 = 2;
                }
                else
                {
                    C13R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P37 = 1;
                }
            }

            else if (rowNo7 == 8)
            {
                if (turnCount % 2 == 0)
                {
                    C13R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P47 = 2;
                }
                else
                {
                    C13R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P47 = 1;
                }
            }

            else if (rowNo7 == 10)
            {
                if (turnCount % 2 == 0)
                {
                    C13R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P57 = 2;
                }
                else
                {
                    C13R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P57 = 1;
                }
            }

            else if (rowNo7 == 12)
            {
                if (turnCount % 2 == 0)
                {
                    C13R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Yellow);
                    P67 = 2;
                }
                else
                {
                    C13R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.Red);
                    P67 = 1;
                }
            }

            else
            {
                enterPiece7.StrokeThickness = 0;
                enterPiece7.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
                turnCount--;
            }
            checkWin();
            turnCount++;
        }

        //Check horizontally for 4 in a row
        //if the adjacent 4 pieces horizontally have the same value 1 0r 2 win = true;
        //uses win in check win method
        public void checkHorizontal()
        {
            //Check for player2
            if (turnCount % 2 == 0)
            {
                if (P21 == 2 && P22 == 2 && P13 == 2 && P14 == 2 || P12 == 2 && P13 == 2 && P14 == 2 && P15 == 2 || P13 == 2 && P14 == 2 && P15 == 2 && P16 == 2 || P14 == 2 && P15 == 2 && P16 == 2 && P17 == 2)
                {
                    win = true;
                }

                else if (P21 == 2 && P22 == 2 && P23 == 2 && P24 == 2 || P22 == 2 && P23 == 2 && P24 == 2 && P25 == 2 || P23 == 2 && P24 == 2 && P25 == 2 && P26 == 2 || P24 == 2 && P25 == 2 && P26 == 2 && P27 == 2)
                {
                    win = true;
                }

                else if (P31 == 2 && P32 == 2 && P33 == 2 && P34 == 2 || P32 == 2 && P33 == 2 && P34 == 2 && P35 == 2 || P33 == 2 && P34 == 2 && P35 == 2 && P36 == 2 || P34 == 2 && P35 == 2 && P36 == 2 && P37 == 2)
                {
                    win = true;
                }

                else if (P41 == 2 && P42 == 2 && P43 == 2 && P44 == 2 || P42 == 2 && P43 == 2 && P44 == 2 && P45 == 2 || P43 == 2 && P44 == 2 && P45 == 2 && P46 == 2 || P44 == 2 && P45 == 2 && P46 == 2 && P47 == 2)
                {
                    win = true;
                }

                else if (P51 == 2 && P52 == 2 && P53 == 2 && P54 == 2 || P52 == 2 && P53 == 2 && P54 == 2 && P55 == 2 || P53 == 2 && P54 == 2 && P55 == 2 && P56 == 2 || P54 == 2 && P55 == 2 && P56 == 2 && P57 == 2)
                {
                    win = true;
                }

                else if (P61 == 2 && P62 == 2 && P63 == 2 && P64 == 2 || P62 == 2 && P63 == 2 && P64 == 2 && P65 == 2 || P63 == 2 && P64 == 2 && P65 == 2 && P66 == 2 || P64 == 2 && P65 == 2 && P66 == 2 && P67 == 2)
                {
                    win = true;
                }

            }

            //Repeat for player1
            else if (turnCount % 2 != 0)
            {
                if (P11 == 1 && P12 == 1 && P13 == 1 && P14 == 1 || P12 == 1 && P13 == 1 && P14 == 1 && P15 == 1 || P13 == 1 && P14 == 1 && P15 == 1 && P16 == 1 || P14 == 1 && P15 == 1 && P16 == 1 && P17 == 1)
                {
                    win = true;
                }

                else if (P21 == 1 && P22 == 1 && P23 == 1 && P24 == 1 || P22 == 1 && P23 == 1 && P24 == 1 && P25 == 1 || P23 == 1 && P24 == 1 && P25 == 1 && P26 == 1 || P24 == 1 && P25 == 1 && P26 == 1 && P27 == 1)
                {
                    win = true;
                }

                else if (P31 == 1 && P32 == 1 && P33 == 1 && P34 == 1 || P32 == 1 && P33 == 1 && P34 == 1 && P35 == 1 || P33 == 1 && P34 == 1 && P35 == 1 && P36 == 1 || P34 == 1 && P35 == 1 && P31 == 1 && P37 == 1)
                {
                    win = true;
                }

                else if (P41 == 1 && P42 == 1 && P43 == 1 && P44 == 1 || P42 == 1 && P43 == 1 && P44 == 1 && P45 == 1 || P43 == 1 && P44 == 1 && P45 == 1 && P46 == 1 || P44 == 1 && P45 == 1 && P46 == 1 && P47 == 1)
                {
                    win = true;
                }

                else if (P51 == 1 && P52 == 1 && P53 == 1 && P54 == 1 || P52 == 1 && P53 == 1 && P54 == 1 && P55 == 1 || P53 == 1 && P54 == 1 && P55 == 1 && P56 == 1 || P54 == 1 && P55 == 1 && P56 == 1 && P57 == 1)
                {
                    win = true;
                }

                else if (P61 == 1 && P62 == 1 && P63 == 1 && P64 == 1 || P62 == 1 && P63 == 1 && P64 == 1 && P65 == 1 || P63 == 1 && P64 == 1 && P65 == 1 && P66 == 1 || P64 == 1 && P65 == 1 && P66 == 1 && P67 == 1)
                {
                    win = true;
                }
            }


        }
        //Check Vertically for 4 in a row
        //if the adjacent 4 pieces horizontally have the same value 1 0r 2 win = true;
        //uses win in check win method
        public void checkVertical()
        {
            //Player2
            if (turnCount % 2 == 0)
            {
                if (P11 == 2 && P21 == 2 && P31 == 2 && P41 == 2 || P21 == 2 && P31 == 2 && P41 == 2 && P51 == 2 || P31 == 2 && P41 == 2 && P51 == 2 && P61 == 2)
                {
                    win = true;
                }

                else if (P12 == 2 && P22 == 2 && P32 == 2 && P42 == 2 || P22 == 2 && P32 == 2 && P42 == 2 && P52 == 2 || P32 == 2 && P42 == 2 && P52 == 2 && P62 == 2)
                {
                    win = true;
                }

                else if (P13 == 2 && P23 == 2 && P33 == 2 && P43 == 2 || P23 == 2 && P33 == 2 && P43 == 2 && P53 == 2 || P33 == 2 && P43 == 2 && P53 == 2 && P63 == 2)
                {
                    win = true;
                }

                else if (P14 == 2 && P24 == 2 && P34 == 2 && P44 == 2 || P24 == 2 && P34 == 2 && P44 == 2 && P54 == 2 || P34 == 2 && P44 == 2 && P54 == 2 && P64 == 2)
                {
                    win = true;
                }

                else if (P15 == 2 && P25 == 2 && P35 == 2 && P45 == 2 || P25 == 2 && P35 == 2 && P45 == 2 && P55 == 2 || P35 == 2 && P45 == 2 && P55 == 2 && P65 == 2)
                {
                    win = true;
                }

                else if (P16 == 2 && P26 == 2 && P36 == 2 && P46 == 2 || P26 == 2 && P36 == 2 && P46 == 2 && P56 == 2 || P36 == 2 && P46 == 2 && P56 == 2 && P66 == 2)
                {
                    win = true;
                }

                else if (P17 == 2 && P27 == 2 && P37 == 2 && P47 == 2 || P27 == 2 && P37 == 2 && P47 == 2 && P57 == 2 || P37 == 2 && P47 == 2 && P57 == 2 && P67 == 2)
                {
                    win = true;
                }

            }

            //Player1
            else if (turnCount % 2 != 0)
            {
                if (P11 == 1 && P21 == 1 && P31 == 1 && P41 == 1 || P21 == 1 && P31 == 1 && P41 == 1 && P51 == 1 || P31 == 1 && P41 == 1 && P51 == 1 && P61 == 1)
                {
                    win = true;
                }

                else if (P12 == 1 && P22 == 1 && P32 == 1 && P42 == 1 || P22 == 1 && P32 == 1 && P42 == 1 && P52 == 1 || P32 == 1 && P42 == 1 && P52 == 1 && P62 == 1)
                {
                    win = true;
                }

                else if (P13 == 1 && P23 == 1 && P33 == 1 && P43 == 1 || P23 == 1 && P33 == 1 && P43 == 1 && P53 == 1 || P33 == 1 && P43 == 1 && P53 == 1 && P63 == 1)
                {
                    win = true;
                }

                else if (P14 == 1 && P24 == 1 && P34 == 1 && P44 == 1 || P24 == 1 && P34 == 1 && P44 == 1 && P54 == 1 || P34 == 1 && P44 == 1 && P54 == 1 && P64 == 1)
                {
                    win = true;
                }

                else if (P15 == 1 && P25 == 1 && P35 == 1 && P45 == 1 || P25 == 1 && P35 == 1 && P45 == 1 && P55 == 1 || P35 == 1 && P45 == 1 && P55 == 1 && P65 == 1)
                {
                    win = true;
                }

                else if (P16 == 1 && P26 == 1 && P36 == 1 && P46 == 1 || P26 == 1 && P36 == 1 && P46 == 1 && P56 == 1 || P36 == 1 && P46 == 1 && P56 == 1 && P66 == 1)
                {
                    win = true;
                }

                else if (P17 == 1 && P27 == 1 && P37 == 1 && P47 == 1 || P27 == 1 && P37 == 1 && P47 == 1 && P57 == 1 || P37 == 1 && P47 == 1 && P57 == 1 && P67 == 1)
                {
                    win = true;
                }
            }
        }

        //Check Diagonally for 4 in a row
        //if the adjacent 4 pieces horizontally have the same value 1 0r 2 win = true;
        //uses win in check win method
        public void checkDiagonal()
        {
            //player2
            #region Check diagonally to the right
            if (turnCount % 2 == 0)
            {
                if (P11 == 2 && P22 == 2 && P33 == 2 && P44 == 2 || P21 == 2 && P32 == 2 && P43 == 2 && P54 == 2 || P31 == 2 && P42 == 2 && P53 == 2 && P64 == 2)
                {
                    win = true;
                }

                else if (P12 == 2 && P23 == 2 && P34 == 2 && P45 == 2 || P22 == 2 && P33 == 2 && P44 == 2 && P55 == 2 || P32 == 2 && P43 == 2 && P54 == 2 && P65 == 2)
                {
                    win = true;
                }

                else if (P13 == 2 && P24 == 2 && P35 == 2 && P46 == 2 || P23 == 2 && P34 == 2 && P45 == 2 && P56 == 2 || P33 == 2 && P44 == 2 && P55 == 2 && P66 == 2)
                {
                    win = true;
                }

                else if (P14 == 2 && P25 == 2 && P36 == 2 && P47 == 2 || P24 == 2 && P35 == 2 && P46 == 2 && P57 == 2 || P34 == 2 && P45 == 2 && P56 == 2 && P67 == 2)
                {
                    win = true;
                }
                #endregion Check diagonally to the right

                //Check to the left

                else if (P14 == 2 && P23 == 2 && P32 == 2 && P41 == 2 || P24 == 2 && P33 == 2 && P42 == 2 && P51 == 2 || P34 == 2 && P43 == 2 && P52 == 2 && P61 == 2)
                {
                    win = true;
                }

                else if (P15 == 2 && P24 == 2 && P33 == 2 && P42 == 2 || P25 == 2 && P34 == 2 && P43 == 2 && P52 == 2 || P35 == 2 && P44 == 2 && P53 == 2 && P62 == 2)
                {
                    win = true;
                }

                else if (P16 == 2 && P25 == 2 && P34 == 2 && P43 == 2 || P26 == 2 && P35 == 2 && P44 == 2 && P53 == 2 || P36 == 2 && P45 == 2 && P54 == 2 && P63 == 2)
                {
                    win = true;
                }

                else if (P17 == 2 && P26 == 2 && P35 == 2 && P44 == 2 || P27 == 2 && P36 == 2 && P45 == 2 && P54 == 2 || P37 == 2 && P46 == 2 && P55 == 2 && P64 == 2)
                {
                    win = true;
                }

            }

            //player 1
            else if (turnCount % 2 != 0)
            {
                #region Check diagonally to the right
                if (P11 == 1 && P22 == 1 && P33 == 1 && P44 == 1 || P21 == 1 && P32 == 1 && P43 == 1 && P54 == 1 || P31 == 1 && P42 == 1 && P53 == 1 && P64 == 1)
                {
                    win = true;
                }

                else if (P12 == 1 && P23 == 1 && P34 == 1 && P45 == 1 || P22 == 1 && P33 == 1 && P44 == 1 && P55 == 1 || P32 == 1 && P43 == 1 && P54 == 1 && P65 == 1)
                {
                    win = true;
                }

                else if (P13 == 1 && P24 == 1 && P35 == 1 && P46 == 1 || P23 == 1 && P34 == 1 && P45 == 1 && P56 == 1 || P33 == 1 && P44 == 1 && P55 == 1 && P66 == 1)
                {
                    win = true;
                }

                else if (P14 == 1 && P25 == 1 && P36 == 1 && P47 == 1 || P24 == 1 && P35 == 1 && P46 == 1 && P57 == 1 || P34 == 1 && P45 == 1 && P56 == 1 && P67 == 1)
                {
                    win = true;
                }
                #endregion Check diagonally to the right

                else if (P14 == 1 && P23 == 1 && P32 == 1 && P41 == 1 || P24 == 1 && P33 == 1 && P42 == 1 && P51 == 1 || P34 == 1 && P43 == 1 && P52 == 1 && P61 == 1)
                {
                    win = true;
                }

                else if (P15 == 1 && P24 == 1 && P33 == 1 && P42 == 1 || P25 == 1 && P34 == 1 && P43 == 1 && P52 == 1 || P35 == 1 && P44 == 1 && P53 == 1 && P62 == 1)
                {
                    win = true;
                }

                else if (P16 == 1 && P25 == 1 && P34 == 1 && P43 == 1 || P26 == 1 && P35 == 1 && P44 == 1 && P53 == 1 || P36 == 1 && P45 == 1 && P54 == 1 && P63 == 1)
                {
                    win = true;
                }

                else if (P17 == 1 && P26 == 1 && P35 == 1 && P44 == 1 || P27 == 1 && P36 == 1 && P45 == 1 && P54 == 1 || P37 == 1 && P46 == 1 && P55 == 1 && P64 == 1)
                {
                    win = true;
                }
            }
        }

        //Show winner
        public void winningScreen()
        {
           test5.FontSize = 45;
           test5.Text = "Winner is " + winningPlayer;
         
        }

        //Reset winner
       public void restartScreen()
        {
            test5.Text=String.Empty;
        }


        //Clean board and reset variables
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //reset board values
            P11 = 0; P21 = -7; P31 = -14; P41 = -21; P51 = -28; P61 = -35;
            P12 = -1; P22 = -8; P32 = -15; P42 = -22; P52 = -29; P62 = -36;
            P13 = -2; P23 = -9; P33 = -16; P43 = -23; P53 = -30; P63 = -37;
            P14 = -3; P24 = -10; P34 = -17; P44 = -24; P54 = -31; P64 = -38;
            P15 = -4; P25 = -11; P35 = -18; P45 = -25; P55 = -32; P65 = -39;
            P16 = -5; P26 = -12; P36 = -19; P46 = -26; P56 = -33; P66 = -40;
            P17 = -6; P27 = -13; P37 = -20; P47 = -27; P57 = -34; P67 = -41;

            //Reset colour to white
            //Row 1
            C1R2.Fill = enterPiece1.Fill;
            C3R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C5R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C7R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C9R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C11R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C13R2.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            //Row2
            C1R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C3R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C5R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C7R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C9R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C11R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C13R4.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            //Row3
            C1R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C3R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C5R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C7R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C9R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C11R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C13R6.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            //Row4
            C1R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C3R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C5R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C7R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C9R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C11R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C13R8.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            //Row5
            C1R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C3R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C5R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C7R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C9R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C11R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C13R10.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            //Row 6
            C1R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C3R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C5R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C7R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C9R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C11R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);
            C13R12.Fill = new SolidColorBrush(color: Windows.UI.Colors.White);

            //reset variables
            winningPlayer = " ";

            turnCount = 1;
            rowNo1 = -0;
            rowNo2 = 0;
            rowNo3 = 0;
            rowNo4 = 0;
            rowNo5 = 0;
            rowNo6 = 0;
            rowNo7 = 0;
            win = false;
            restartScreen();
            
        }
    }
}


