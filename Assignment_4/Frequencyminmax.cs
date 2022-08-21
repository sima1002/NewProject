/*using system;
using system.collections.generic;
using system.text;

namespace myproject.assignment_4
{
    class frequencyminmax
    {
        public static void main()
        {
            string str = "grass is greener on the other side";
            int[] freq = new int[str.length];
            char minchar = str[0], maxchar = str[0];
            int i, j, min, max;

            char[] string1 = str.tochararray();
            for ( i= 0; i < string1.length; i++)
            {
                freq[i] = 1;
                for (j = i + 1; j < string1.length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0') 
                    {
                        freq[i]++;
                        string1[j] = '0';
                    }
                }
            }
            min = max = freq[0];
            for (i = 0; i < freq.length; i++)
            {
                if (min > freq[i] && freq[i] != '0')
                {
                    min = freq[i];
                    minchar = string1[i];

                }
                if (max < freq[i])
                {
                    max = freq[i];
                    maxchar = string1[i];
                }
            }
            console.writeline("minimum character:", +minchar);
            console.writeline("maximum character:", +maxchar);
        }
    }
}*/
