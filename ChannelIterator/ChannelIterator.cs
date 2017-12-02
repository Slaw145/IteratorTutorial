using System;
using System.Collections.Generic;
using System.Text;

namespace IterateChannels
{
    interface IIterator
    {
        string FirstChannel { get; }
        string Next { get; }
        string CurrentChannel { get; }
        bool IsDone { get; }
        string Previous { get; }
    }

    class Channelterator : IIterator
    {
        ChannelFrequencies aggregate_ = null;
        int currentIndex_ = 0;

        public Channelterator(ChannelFrequencies aggregate)
        {
            aggregate_ = aggregate;
        }

        public string FirstChannel
        {
            get
            {
                currentIndex_ = 0;
                return aggregate_[currentIndex_];
            }
        }

        public string Next
        {
            get
            {
                currentIndex_ += 1;

                if (IsDone == false)
                {
                    return aggregate_[currentIndex_];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string Previous
        {
            get
            {
                currentIndex_ -= 1;

                if (IsDone == false)
                {
                    return aggregate_[currentIndex_];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string CurrentChannel
        {
            get
            {
                return aggregate_[currentIndex_];
            }
        }

        public bool IsDone
        {
            get
            {
                if (currentIndex_ < aggregate_.Count)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
