using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            string copy_num = Convert.ToString(num);
            num = int.Parse(Convert.ToString(copy_num[0]));
            for (int i = 1; i < copy_num.Length; i++) { num *= int.Parse(Convert.ToString(copy_num[i])); }
            return num;
        }
    }
}
