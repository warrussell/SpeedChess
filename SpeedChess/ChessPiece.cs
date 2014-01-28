using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System;

namespace SpeedChess
{
	public class ChessPiece : INotifyPropertyChanged 
	{
		private int _x;
        public int x 
		{ 
			get { return this._x; } 

			set 
			{  
				if (value != _x)
                {
                    _x = value;
                    NotifyPropertyChanged("x");
                }
			} 
		}

		private int _y;
        public int y
		{
            get { return this._y; }

			set 
			{  
				if (value != _y)
                {
                    _y = value;
                    NotifyPropertyChanged("y");
                }
			}
		}

		private string _colour;
		public string colour
		{
            get { return this._colour; }

			set 
			{  
				if (value != _colour && ( value == "black" || value == "white" || value == "empty") )
                {
                    _colour = value;
                    NotifyPropertyChanged("colour");
                }
			}
		}

		private string _image;
		public string image
		{
            get { return this._image; }

			set 
			{  
				if (value != _image)
                {
                    _image = value;
                    NotifyPropertyChanged("image");
                }
			}
		}

        public bool highlighted = false;

		public ChessPiece()
		{

		}

		public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
	}

	public class Pawn : ChessPiece
	{
		private int _prevX;
		public int prevX
		{
			get { return this._prevX; }

			set 
			{
				if (value != _prevX)
                {
                    _prevX = value;
                    NotifyPropertyChanged("prevX");
                }
			}

		}
		private int _prevY;
		public int prevY
		{
			get { return this._prevY; }

			set 
			{
				if (value != _prevY)
                {
                    _prevY = value;
                    NotifyPropertyChanged("prevY");
                }
			}

		}


        
        public List<List<int>> offset = new List<List<int>>();
        public List<List<int>> attack = new List<List<int>>();
        public bool pawnLeap = true;

		public Pawn( int X, int Y )
		{
			this.x = X;
			this.y = Y;

            offset.Add(new List<int>(new int[] {0,1}));
            offset.Add(new List<int>(new int[] { 0, 2 }));

            attack.Add(new List<int>(new int[] { -1, 1 }));
            attack.Add(new List<int>(new int[] { 1, 1 }));
		}
        /*override public int x
        {
            set 
            { 
                prevX = base.x;
                base.x = value;
            }
        }
        override public int y
        {
            set
            {
                prevY = base.y;
                base.y = value;
            }
        }*/
	}

	public class Rook : ChessPiece
	{
		public Rook( int X, int Y )
		{
			this.x = X;
			this.y = Y;
		}
	}

	public class Bishop : ChessPiece
	{
		public Bishop( int X, int Y )
		{
			this.x = X;
			this.y = Y;
		}
	}

	public class Knight : ChessPiece
	{
		public Knight( int X, int Y )
		{
			this.x = X;
			this.y = Y;
		}
	}

	public class Queen : ChessPiece
	{
		public Queen( int X, int Y )
		{
			this.x = X;
			this.y = Y;
		}
	}

	public class King : ChessPiece
	{
		public King( int X, int Y )
		{
			this.x = X;
			this.y = Y;
		}
	}
}