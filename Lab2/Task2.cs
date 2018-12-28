using System.Collections;

namespace Lab2
{class Task2
    {private int num;
     public Task2 (int num)
        {this.num = num;
        }
        public string Con()
        {int tmp = num;
        ArrayList list = new ArrayList();    
        int i = 0;
        while (tmp != 0)
            {list.Add(tmp % 2);
             tmp /= 2;
             i++;
            }
           list.Reverse();        
           string result = null;
           foreach (int element in list)
            {result += element;
            }
            return result;
        }
    }
}
