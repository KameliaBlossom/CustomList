using CustomList;

MyList newList = new MyList(4);
int[] example = new int[]{9, 8, 9};

newList.Add(1);
newList.Add(2);
newList.Add(3);
newList.Add(4);
newList.Add(5);
newList.Add(2, 4);
newList.Add(3, example);

Console.WriteLine(newList.Count);
Console.WriteLine(newList.Capacity);

Console.WriteLine();

for (int i = 0; i < newList.Count; i++)
{
    Console.WriteLine(newList[i]);
}

