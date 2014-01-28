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
using SpeedChess;
using System.Diagnostics;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SpeedChess
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //CONSTANTS
        private List<ChessPiece> squares;
        private List<Pawn> pawnPieces;
        private List<King> kingPieces;

        private Turn player;

        private Timer tb, tw;
        private DispatcherTimer dt;

        public MainPage()
        {
            this.InitializeComponent();

            //initialize stuffs
            player = new Turn("white");
            setPieces();
            tw = new Timer(2);
            tb = new Timer(2);
            startTimer();
        }

        private void startTimer()
        {
            if (dt == null)
            {
                dt = new DispatcherTimer();
                dt.Interval = new TimeSpan(0, 0, 0, 1, 0);
                dt.Tick += timer_Tick;
            }
            dt.Stop();
            dt.Start();
        }

        public void timer_Tick(object sender, object args)
        {
            if (player.colour == "white")
            {
                if (tw.getClock() == "00:00")
                {
                    Debug.WriteLine("White Lost");
                }
                else
                {
                    tw.subtract(0, 1);
                }
                clockW.Text = tw.getClock();
            }
            if (player.colour == "black")
            {
                if (tb.getClock() == "00:00")
                {
                    Debug.WriteLine("Black Lost");
                }
                else
                {
                    tb.subtract(0, 1);
                }
                clockB.Text = tb.getClock();
                Debug.WriteLine("hi");
            }
        }

        private void setPieces()
        {
            squares = new List<ChessPiece>();

            int i = 0; int j = 0;
            ChessPiece c;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E00";
            E00.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E01";
            E01.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E02";
            E02.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E03";
            E03.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E04";
            E04.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E05";
            E05.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E06";
            E06.DataContext = c; squares.Add(c);j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E07";
            E07.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E10";
            E10.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E11";
            E11.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E12";
            E12.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E13";
            E13.DataContext = c; squares.Add(c);j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E14";
            E14.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E15";
            E15.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E16";
            E16.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c); c.image = "E17";
            E17.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E20";
            E20.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E21";
            E21.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E22";
            E22.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E23";
            E23.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E24";
            E24.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E25";
            E25.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E26";
            E26.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E27";
            E27.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E30";
            E30.DataContext = c; squares.Add(c);j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E31";
            E31.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E32";
            E32.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E33";
            E33.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E34";
            E34.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E35";
            E35.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E36";
            E36.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E37";
            E37.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E40";
            E40.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E41";
            E41.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E42";
            E42.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E43";
            E43.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E44";
            E44.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E45";
            E45.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E46";
            E46.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E47";
            E47.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E50";
            E50.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E51";
            E51.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E52";
            E52.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E53";
            E53.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E54";
            E54.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E55";
            E55.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E56";
            E56.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E57";
            E57.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E60";
            E60.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E61";
            E61.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E62";
            E62.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E63";
            E63.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E64";
            E64.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E65";
            E65.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E66";
            E66.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E67";
            E67.DataContext = c; squares.Add(c); i++; j=0;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E70";
            E70.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E71";
            E71.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E72";
            E72.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E73";
            E73.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E74";
            E74.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E75";
            E75.DataContext = c; squares.Add(c);  j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E76";
            E76.DataContext = c; squares.Add(c); j++;
            c = new ChessPiece(); c.x = i; c.y = j; c.colour = "empty"; squares.Add(c);c.image = "E77";
            E77.DataContext = c; squares.Add(c);
            pawnPieces = new List<Pawn>();

            //rookz
            Rook br1 = new Rook(0, 0);
            br1.image = BR1.Name;
            br1.colour = "black";
            BR1.DataContext = br1;

            Rook br2 = new Rook(7, 0);
            br2.image = BR2.Name;
            br2.colour = "black";
            BR2.DataContext = br2;

            Rook wr1 = new Rook(0, 7);
            wr1.image = WR1.Name;
            wr1.colour = "white";
            WR1.DataContext = wr1;

            Rook wr2 = new Rook(7, 7);
            wr2.image = WR2.Name;
            wr2.colour = "white";
            WR2.DataContext = wr2;

            //horses
            Knight bh1 = new Knight(1, 0);
            bh1.image = BH1.Name;
            BH1.DataContext = bh1;

            Knight bh2 = new Knight(6, 0);
            bh2.image = BH2.Name;
            BH2.DataContext = bh2;

            Knight wh1 = new Knight(1, 7);
            wh1.image = WH1.Name;
            WH1.DataContext = wh1;

            Knight wh2 = new Knight(6, 7);
            wh2.image = WH2.Name;
            WH2.DataContext = wh2;

            //bishop
            Bishop bb1 = new Bishop(2, 0);
            bb1.image = BB1.Name;
            BB1.DataContext = bb1;

            Bishop bb2 = new Bishop(5, 0);
            bb2.image = BB2.Name;
            BB2.DataContext = bb2;

            Bishop wb1 = new Bishop(2, 7);
            wb1.image = WB1.Name;
            WB1.DataContext = wb1;

            Bishop wb2 = new Bishop(5, 7);
            wb2.image = WB2.Name;
            WB2.DataContext = wb2;

            //queen
            Queen bq = new Queen(3, 0);
            bq.image = BQ.Name;
            BQ.DataContext = bq;

            Queen wq = new Queen(3, 7);
            wq.image = WQ.Name;
            WQ.DataContext = wq;

            //king
            King bk = new King(4, 0);
            bk.image = BK.Name;
            BK.DataContext = bk;

            King wk = new King(4, 7);
            wk.image = WK.Name;
            WK.DataContext = wk;

            //pawnssssssssssssssssssssssss
            Pawn bp1 = new Pawn(0, 1);
            bp1.image = BP1.Name;
            bp1.colour = "black";
            BP1.DataContext = bp1;

            Pawn bp2 = new Pawn(1, 1);
            bp2.image = BP2.Name;
            bp2.colour = "black";
            BP2.DataContext = bp2;

            Pawn bp3 = new Pawn(2, 1);
            bp3.image = BP3.Name;
            bp3.colour = "black";
            BP3.DataContext = bp3;

            Pawn bp4 = new Pawn(3, 1);
            bp4.image = BP4.Name;
            bp4.colour = "black";
            BP4.DataContext = bp4;

            Pawn bp5 = new Pawn(4, 1);
            bp5.image = BP5.Name;
            bp5.colour = "black";
            BP5.DataContext = bp5;

            Pawn bp6 = new Pawn(5, 1);
            bp6.image = BP6.Name;
            bp6.colour = "black";
            BP6.DataContext = bp6;

            Pawn bp7 = new Pawn(6, 1);
            bp7.image = BP7.Name;
            bp7.colour = "black";
            BP7.DataContext = bp7;

            Pawn bp8 = new Pawn(7, 1);
            bp8.image = BP8.Name;
            bp8.colour = "black";
            BP8.DataContext = bp8;

            Pawn wp1 = new Pawn(0, 6);
            wp1.image = WP1.Name;
            wp1.colour = "white";
            WP1.DataContext = wp1;

            Pawn wp2 = new Pawn(1, 6);
            wp2.image = WP2.Name;
            wp2.colour = "white";
            WP2.DataContext = wp2;

            Pawn wp3 = new Pawn(2, 6);
            wp3.image = WP3.Name;
            wp3.colour = "white";
            WP3.DataContext = wp3;

            Pawn wp4 = new Pawn(3, 6);
            wp4.image = WP4.Name;
            wp4.colour = "white";
            WP4.DataContext = wp4;

            Pawn wp5 = new Pawn(4, 6);
            wp5.image = WP5.Name;
            wp5.colour = "white";
            WP5.DataContext = wp5;

            Pawn wp6 = new Pawn(5, 6);
            wp6.image = WP6.Name;
            wp6.colour = "white";
            WP6.DataContext = wp6;

            Pawn wp7 = new Pawn(6, 6);
            wp7.image = WP7.Name;
            wp7.colour = "white";
            WP7.DataContext = wp7;

            Pawn wp8 = new Pawn(7, 6);
            wp8.image = WP8.Name;
            wp8.colour = "white";
            WP8.DataContext = wp8;

            //add all of 'em up
            pawnPieces.Add(wp1);
            pawnPieces.Add(wp2);
            pawnPieces.Add(wp3);
            pawnPieces.Add(wp4);
            pawnPieces.Add(wp5);
            pawnPieces.Add(wp6);
            pawnPieces.Add(wp7);
            pawnPieces.Add(wp8);
            
            pawnPieces.Add(bp1);
            pawnPieces.Add(bp2);
            pawnPieces.Add(bp3);
            pawnPieces.Add(bp4);
            pawnPieces.Add(bp5);
            pawnPieces.Add(bp6);
            pawnPieces.Add(bp7);
            pawnPieces.Add(bp8);
        }

        private void hitPawn(string name)
        {
            Pawn p = pawnPieces.Find(x => x.image == name);
            
           if (player.isSelected)
            {
                if (player.colour == p.colour)
                {
                    //same colour
                    Debug.WriteLine("it is your ally");
                }
                else
                {
                   //different colour
                    Debug.WriteLine("ATTACK!");

                    Pawn selectedPawn = pawnPieces[player.indexOfTypesList];

                    int direction = ( player.colour == "white") ? -1 : 1;
                    //int offset = p.offset;
                    if (selectedPawn.y + (direction * selectedPawn.attack[0][1]) == p.y && selectedPawn.x + (direction * selectedPawn.attack[0][0]) == p.x || (selectedPawn.y + (direction * selectedPawn.attack[1][1]) == p.y && selectedPawn.x + (direction * selectedPawn.attack[1][0]) == p.x))
                    {
                        selectedPawn.pawnLeap = false;
                        selectedPawn.x = p.x; selectedPawn.y = p.y;
                        
                     // Need to kill/remove UI chesspiece when it is taken by other player  
                        if (p.colour == "black")
                        {
                            p.x = 0; p.y = 0;
                        }
                        else
                        {
                            p.x = 7; p.y = 7;
                        }

                        player.isSelected = false;
                        player.type = "";
                        player.indexOfTypesList = -1;
                        //switch colour
                        if (player.colour == "white")
                        {
                            player.colour = "black";
                            mainScroll.ChangeView(0, 450, 1);
                        }
                        else
                        {
                            player.colour = "white";
                            mainScroll.ChangeView(0, 0, 1);
                        }
                    }
                }
            }
           else
           {
               if (player.colour == p.colour)
               {
                   //select the unit
                   Debug.WriteLine("select an ally unit");
                   player.isSelected = true;
                   player.indexOfTypesList = pawnPieces.IndexOf(p);
                   player.type = "pawn";
               }
           }
        }

        private void HighlightSquares( ChessPiece piece, List<List<int>> offset )
        {

        }

        private void Pointer_Released(object sender, PointerRoutedEventArgs e)
        {
            //grab the Image that was clicked
            Image r = (Image)sender;

            //searching in the dumbest way possible
            switch (r.Name){
                case "BP1":
                    hitPawn(r.Name);
                    break;
                case "BP2":
                    hitPawn(r.Name);
                    break;
                case "BP3":
                    hitPawn(r.Name);
                    break;
                case "BP4":
                    hitPawn(r.Name);
                    break;
                case "BP5":
                    hitPawn(r.Name);
                    break;
                case "BP6":
                    hitPawn(r.Name);
                    break;
                case "BP7":
                    hitPawn(r.Name);
                    break;
                case "BP8":
                    hitPawn(r.Name);
                    break;

                case "WP1":
                    hitPawn(r.Name);
                    break;
                case "WP2":
                    hitPawn(r.Name);
                    break;
                case "WP3":
                    hitPawn(r.Name);
                    break;
                case "WP4":
                    hitPawn(r.Name);
                    break;
                case "WP5":
                    hitPawn(r.Name);
                    break;
                case "WP6":
                    hitPawn(r.Name);
                    break;
                case "WP7":
                    hitPawn(r.Name);
                    break;
                case "WP8":
                    hitPawn(r.Name);
                    break;

                default:
                    Debug.WriteLine("oh no! it broke!");
                    break;
            }
        }
        private void EmptyRect_Pointer_Released(object sender, PointerRoutedEventArgs e)
        {
            //grab the rectangle that was clicked
            Image r = (Image)sender;
            Debug.WriteLine("empty button" + r.Name);

            if (player.isSelected)
            {
                //already picked one guy
                if (player.type == "pawn")
                {
                    Pawn p = pawnPieces[player.indexOfTypesList];

                    ChessPiece c = squares.Find(x => x.image == r.Name);
                    int direction = ( player.colour == "white") ? -1 : 1;
                    //int offset = p.offset;
                    if (p.y + (direction * p.offset[0][1]) == c.y && p.x == c.x || ( p.y + (direction * p.offset[1][1]) == c.y && p.pawnLeap && p.x == c.x ) )
                    {
                        p.pawnLeap = false;
                        p.x = c.x; p.y = c.y; 
                        player.isSelected = false; 
                        player.type = ""; 
                        player.indexOfTypesList = -1;
                        //switch colou
                        if (player.colour == "white")
                        {
                            player.colour = "black";
                            mainScroll.ChangeView(0, 450, 1);
                        }
                        else
                        {
                            player.colour = "white";
                            mainScroll.ChangeView(0, 0, 1);
                        }
                    }
                }
            }

        }
    }
}
