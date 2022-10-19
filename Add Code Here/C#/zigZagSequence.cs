using systems;
public class Zigzag
{

 public static void zigZagSequesnce()
        {
            int[] arr = new int[] { 2, 6, 1, 4, 7, 3, 5 };
            int length = arr.Length;
            int midIndex = length / 2;
            int lastIndex = length - 1;
            
            Array.Sort(arr);
            
            int max = arr[lastIndex];
            arr[lastIndex] = arr[midIndex]; 
            arr[midIndex] = max;
            
            int leftIndex = midIndex + 1;
            int rightIndex = lastIndex - 1;

            while (leftIndex < rightIndex)
            {
                int tmp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = tmp;

                leftIndex++;
                rightIndex--;
            }
            Console.WriteLine(string.Join(",", arr));
            Console.ReadLine();
        }
}
