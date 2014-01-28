using System;
using System.ComponentModel;

namespace SpeedChess
{
    public class Timer
    {
        private int _startMin { set; get; }
        private int _sec;
        private int _min;

        public Timer(int startMin)
        {
            _startMin = startMin;
            this.setClock(_startMin);
        }

        public void setClock(int startMin)
        {
            _startMin = startMin;
            _min = startMin;
            _sec = 0;
        }

        public string getClock()
        {
            string time;
            if (_min < 10)
                time = "0" + _min;
            else
                time = "" + _min;
            if ((_sec) < 10)
                time += ":0" + _sec;
            else
                time += ":" + _sec;
            return time;
        }

        public void subtract(int min, int sec)
        {
            _min -= min;
            _sec -= sec;
            if (_sec < 0)
            {
                _min--;
                _sec = 59;
            }
        }
    }
}