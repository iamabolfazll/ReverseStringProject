using Contracts;

namespace Services
{
    public class StringService : IStringService
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }

            return new string(charArray);
        }

        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string reversed = ReverseString(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}