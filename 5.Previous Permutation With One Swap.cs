
public class Solution {
    public int[] PrevPermOpt1(int[] arr) {
        int maxIndex = 0, prevIndex = 0, max = 0, prevMax = 0;
        for(int i = 1; i < arr.Count(); i++){
            if(arr[i-1] > arr[i] ){
                maxIndex = i-1;
                prevIndex = i;
                max = arr[i-1];
                prevMax = arr[i];
            }
            if(arr[i] > prevMax && max > arr[i] && prevMax > 0){
                prevIndex = i;
                prevMax = arr[i];
            }
        }
        int tmp = arr[maxIndex];
        arr[maxIndex] = arr[prevIndex]; 
        arr[prevIndex] = tmp;
        //Console.WriteLine($"{max}\t{prevMax}\n{maxIndex}\t{prevIndex}" );
        return arr;
    }
}
