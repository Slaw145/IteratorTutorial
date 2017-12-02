using System;

namespace IteratorSchema
{
    class Program
    { 
        public static void Main(string[] args)
        {
            ListCollection listCollection = new ListCollection();

            for (TraversalAbstraction iter = listCollection.createIterator(); iter.hasNext();)
            {
                string name = (string)iter.next();
                Console.WriteLine("Name : " + name);
            }

            Console.ReadKey();
        }
    }

    public interface TraversalAbstraction
    {
        bool hasNext();
        object next();
    }

    interface Collection
    {
        TraversalAbstraction createIterator();
    }

    class ListCollection: Collection
    {
        public TraversalAbstraction createIterator()
        {
            return new ListTraversal();
        }
    }

    class ListTraversal : TraversalAbstraction
    {
        public string[] names = new string[] { "Robert", "John", "Julie", "Lora" };

        int index;

        public bool hasNext()
        {

            if (index < names.Length)
            {
                return true;
            }
            return false;
        }

        public Object next()
        {

            if (hasNext())
            {
                return names[index++];
            }
            return null;
        }
    }
}
