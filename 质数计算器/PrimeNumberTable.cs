using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 质数计算器
{
    internal class PrimeNumberTable
    {
        private long[] list = new long[5000];
        private void listAdd() 
        { 
            bool flag = true;
            long i = 0;
            int k = 0;
            while (flag)
            {
                i++;
                if(k == 5000)
                {
                    flag = false;
                    break;
                }
                if(i < 10)
                {
                    if(i == 2 || i == 3 || i == 5 || i == 7)
                    {
                        list[k] = i;
                        k++;
                    }
                }
                else
                {
                    bool juage = true;
                    for (int j = 2; j <= i/2; j++)
                    {
                        if(i % j == 0)
                        {
                            juage = false;
                            break ;
                        }
                    }
                    if(juage == true)
                    {
                        list[k] = i;
                        k++;
                    }
                }

            }
        }

        public long[] getList()
        {
            listAdd();
            return list;
        }
    }
}
