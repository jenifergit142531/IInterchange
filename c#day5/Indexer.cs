using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_day5
{
    public class MultiIndex
    {

        public string[] data = new string[10];

        public string this[int index]
            {
            get
            {
                return data[index];
            }
            set
            {
                if (index > 0 && index<data.Length)
                {
                    data[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
            }

        public string this[string key]
        {
            get
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == key)
                    {
                        return data[i];
                    }
                }
                return "not found"; //key not found
            }
            set
            {
                for(int i=0;i<data.Length;i++)
                {
                    if (data[i] == key)
                    {
                        data[i] = value;
                        return;
                    }
                   
                }
                
            }
        }

    }
    public class Indexer
    {
        private string[] names = new string[size];
        static public int size = 10;
        public Indexer()
        {
            for(int i=0; i<size;i++)
            {
                names[i] = "Not Applicable";
            }
        }

        public string this[int i]
        { 
            get
            {
                return names[i];
            }

            set
            {
                names[i] = value;
            }
        }

    }
}
