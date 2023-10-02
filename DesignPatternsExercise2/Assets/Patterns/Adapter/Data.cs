using System;

namespace Patterns.Adapter
{


    [Serializable]
    public class Data
    {
        public string Data1;
        public int Data2;

        public Data(string data1, int data2)
        {
            Data1 = data1;
            Data2 = data2;
        }
    }
}
