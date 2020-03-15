using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Ticket
    {
        private double _distance;

        public double Distance
        {
            get { return _distance; }
        }

        public Ticket(double distance)
        {
            if(distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        public double Price
        {
            get {
                if (_distance <= 100)
                    return _distance;
                if (_distance > 100 && _distance <= 200)
                    return _distance * 0.95;
                if (_distance > 200 && _distance <= 300)
                    return _distance * 0.9;
                else
                    return _distance * 0.8; 
            }
        }

        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要{1}元", _distance, this.Price);
        }
    }
}
