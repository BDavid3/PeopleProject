using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace PeopleProject
{
    internal class People
    {
        private List<int> eletkorok;

        public People()
        {
            eletkorok = new List<int>();
        }

        public void UjSzemely(int eletkor)
        {
            if (eletkor > 0)
            {
                eletkorok.Add(eletkor);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double AtlagEletkor(int minEletkor, int maxEletkor)
        {
            List<int> tempList = new List<int>();
            int tempCounter = 0;

            // nincs szemely
            if (eletkorok.Count == 0)
            {
                throw new InvalidOperationException();
            }

            // min nagyobb mint max
            if (minEletkor > maxEletkor)
            {
                throw new ArgumentException();
            }

            foreach (int i in eletkorok)
            {
                if (i >= minEletkor && i <= maxEletkor)
                {
                    tempList.Add(i);
                }
            }

            foreach (int i in tempList)
            {
                tempCounter += i;
            }

            double atlag = (double)tempCounter / tempList.Count;

            return tempCounter;

        }
    }
}
