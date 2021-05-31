using System;

namespace Edit
{
    public static class Edit
    {
        private static bool IsOneEditReplace(string str1, string str2)
        {
            bool mismatch = false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    if (mismatch)
                    {
                        return false;
                    }

                    mismatch = true;
                }
            }

            return true;
        }

        private static bool IsOneEditInsert(string str1, string str2)
        {
            bool mismatch = false;
            int index1 = 0;
            int index2 = 0;

            while (index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] == str2[index2])
                {
                    index1++;
                    index2++;
                }
                else
                {
                    if (mismatch)
                    {
                        return false;
                    }

                    mismatch = true;
                    index2++;
                }
            }

            return true;
        }

        public static bool IsOneEdit(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                throw new ArgumentNullException();
            }

            if (str1.Length == str2.Length)
            {
                return IsOneEditReplace(str1, str2);
            }

            if (str1.Length + 1 == str2.Length)
            {
                return IsOneEditInsert(str1, str2);
            }

            if (str1.Length == str2.Length + 1)
            {
                return IsOneEditInsert(str2, str1);
            }

            return false;
        }
    }
}