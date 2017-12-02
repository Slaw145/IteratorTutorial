using System;
using System.Collections.Generic;
using System.Text;

namespace BookIterator
{
    interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }

    class MyAggregate : IAggregate
    {
        List<string> values_ = null;

        public MyAggregate()
        {
            values_ = new List<string>();
        }


        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }


        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < values_.Count)
                {
                    return values_[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                values_.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return values_.Count;
            }
        }
    }
}
