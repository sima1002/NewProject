﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_5
{
    class UniqueElement
    {
        public static void Main()
        {
            int[] a = { 4, 8, 2, 2, 2, 9, 2, 8, 5, 5 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[k]==a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                }
            }

        }

    }
}
