public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool increase = true;
        bool decrease = true;

        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i + 1] < nums[i])
            {
                increase = false;
            }   
            if(nums[i + 1] > nums[i])
            {
                decrease = false;
            }         
        }
        return increase || decrease;
    }
}
