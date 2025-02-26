namespace DailyCodingChallenges.src
{
    /*

        Given an array of integers nums and an integer target,
        return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        Example 1:

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        Example 2:

        Input: nums = [3,2,4], target = 6
        Output: [1,2]
        Example 3:

        Input: nums = [3,3], target = 6
        Output: [0,1]
    */

    public static class TwoSum
    {

        public static void Run()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            int[] result = FindTwoSum(nums, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }

        public static int[] FindTwoSum(int[] nums, int target)
        {
            var numbersAndIndexes = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int remainder = target - nums[i];

                if (numbersAndIndexes.ContainsKey(remainder))
                {
                    return new int[] { i, numbersAndIndexes[remainder] };
                }

                numbersAndIndexes[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution for provided arguments");
        }
    }
}