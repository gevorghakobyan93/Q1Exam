class Exam
{
    static void Main()
    {
        string[] array = {"Hello", "2", "world", ":-)" };
        string [] newArray = CreateNewArray(array, 3);
        Console.WriteLine($"[{string.Join(",", newArray)}]");
    }

    static string[] CreateNewArray(string [] array, int limit)
    {   
        int size = 0;
        int index = 0;

        //Calculate size of array that will fit in limit
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= limit){
                size++;
            }
        }
        //Create array with exact count that matches of size
        string [] newArray = new string[size];
        for (int j = 0; j < array.Length; j++)
        {
             if(array[j].Length <= limit){
                newArray[index] = array[j];
                index ++;
            }
        }
        return newArray;
    }
}