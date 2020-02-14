namespace TestAutomation.iterator
{
    public class NameRepository
    {
        public static string[] names = {"Robert", "John", "Julie", "Lora"};

        public IIterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            int index;

            public bool HasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }

                return false;
            }

            public object next()
            {
                if (HasNext())
                {
                    return names[index++];
                }

                return null;
            }
        }
    }
}