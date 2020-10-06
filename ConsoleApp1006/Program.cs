using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(10, "오렌지");
            ht[10] = "딸기";
            ht[20] = "사과";
            //ht.Add(20, "복숭아");
            //ht["수박"] = 100;

            Console.WriteLine(ht.Count);

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(10, "오렌지");
            dic[10] = "딸기";
            dic[20] = "사과";
            //dic["수박"] = 100;

            foreach (int elem in dic.Keys)
            {
                Console.WriteLine(dic[elem]);
            }
            foreach(KeyValuePair<int, string> elem in dic)
            {
                Console.WriteLine($"{elem.Key} - {elem.Value}");
            }
            foreach (var elem in dic) //무슨 타입인지 모를 때 var 타입 사용
            {
                Console.WriteLine($"{elem.Key} - {elem.Value}");
            }
            //dynamic name = "홍길동";
            
            //name = 10;
            //Console.WriteLine(name);
        }
    }
}
