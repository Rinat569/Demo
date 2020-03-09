using System;

class MainClass {
  public static void Main (string[] args) {
   
   string str = "один два три три пять четыре шесть";
        string[] writes = str.Split(' ');
 
        for (int i = 0; i < writes.Length; i++)
        {
            string write = writes[i];
 
            int count=0;
            foreach (string item in writes)
            {
                if (item == write)
                    count++;
            }
            if (count==1)
                Console.WriteLine(writes[i]);
        }
 
        Console.ReadLine();
}
  }
