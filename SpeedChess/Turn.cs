using System.ComponentModel;
using System;

namespace SpeedChess
{
    public class Turn : INotifyPropertyChanged 
	{
		private string _colour;
        public string colour 
		{
            get { return this._colour; } 

			set 
			{
                if (value != _colour && (value == "black" || value == "white"))
                {
                    _colour = value;
                    NotifyPropertyChanged("colour");
                }
			} 
		}

		private bool _isSelected;
		public bool isSelected
		{
            get { return this._isSelected; }

			set 
			{  
				if (value != _isSelected)
                {
                    _isSelected = value;
                    NotifyPropertyChanged("isSelected");
                }
			}
		}

        private string _type;
        public string type
        {
            get { return this._type; }

            set
            {
                if (value != _type)
                {
                    _type = value;
                    NotifyPropertyChanged("type");
                }
            }
        }

        private int _index;
        public int indexOfTypesList
        {
            get { return this._index; }

            set
            {
                if (value != _index)
                {
                    _index = value;
                    NotifyPropertyChanged("indexOfTypesList");
                }
            }
        }

		public Turn(string p)
		{
            this.colour = p;
            this.isSelected = false;
		}

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
	}
}