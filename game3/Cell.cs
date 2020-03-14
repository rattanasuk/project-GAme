using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game3
{
    public class Cell
    {
        int value;
        public Cell()
        {
            this.value = 0;
        }
        public bool isZeroValue()
        {
            return (value == 0);
              
        }
        public void setZeroValue()
        {
            value = 0;
        }
        public void setFirstValue()
        {
            value = 2;
        }
        public void setValue(int givenValue)
        {
            value = givenValue;
        }
        public int getValue()
        {
            return value;
        }
        public void doubleValue()
        {
            value *= 2;
        }
    }
}
