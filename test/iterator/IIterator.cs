using System;

namespace TestAutomation.iterator
{
    public interface IIterator
    {
        public bool HasNext();
        public object next();
    }
}