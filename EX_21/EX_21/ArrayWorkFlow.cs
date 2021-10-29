using System;
using System.Collections; 

public class ArrayWorkFlow
{

    public ArrayList newArrayWithSize(int x, int y)
    {
        ArrayList myNewArray = new ArrayList();

        Random rnd = new Random();
        for (int i = 0; i < x; i++)
        {
            ArrayList tempNewArray = new ArrayList();

            for (int j = 0; j < y; j++)
            {
                tempNewArray.Add(rnd.Next(0, 99));
            }
            myNewArray.Add(tempNewArray);
        }

        return myNewArray;
    }

    public void sortedtArray(ArrayList arrayList)
    {
        for (int i = 0; i < arrayList.Count; i++)
        {
            ArrayList tempArrayLsit = (ArrayList)arrayList[i];
            tempArrayLsit.Sort();
            if (i % 2 == 0)
            {
                tempArrayLsit.Reverse();
            }
        }
    }


    public void printArrayList(ArrayList arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            ArrayList tempArray = (ArrayList)arr[i];
            for (int j = 0; j < tempArray.Count; j++)
                Console.Write(" " + tempArray[j]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}