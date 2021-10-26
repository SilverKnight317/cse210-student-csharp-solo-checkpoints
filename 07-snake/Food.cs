using System;
using System.Collections.Generic;

namespace _07_snake 
{
    // TODO: Define the Food class here.
    public class Food : Actor
    {
        public Food()
        {
            Reset();
        }
        private int _points;
        Random rnd = new Random();
        public void Reset()
        {
            int x = rnd.Next(0,Constants.MAX_X);
            int y = rnd.Next(0,Constants.MAX_Y);
            _text = _points.ToString();
            _position = new Point(x, y);
            _points = 0;
            
        }
        public int GetPoints()
        {
            AddPoints();
            return _points;
        }
        private void AddPoints()
        {
            _points += rnd.Next(1,10);
        }
    }
}