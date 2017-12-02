using System;
using System.Collections.Generic;
using System.Text;

namespace IterateChannels
{
    interface ChannelFrequencies
    {
        IIterator GetChannelIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }

    class TunedChannel : ChannelFrequencies
    {
        List<string> values_ = null;

        public TunedChannel()
        {
            values_ = new List<string>();
        }

        public IIterator GetChannelIterator()
        {
            return new Channelterator(this);
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
