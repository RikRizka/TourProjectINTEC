namespace ExtentionLabrary
{
    public static class ExtensionStringsType
    {
        public static bool IsPalindroom(this string str)

        {

            #region Salvator

            //char[] chars = str.ToCharArray();

            //Array.Reverse(chars);

            //string woordReverse = new string(chars);

            //if(str.ToLower() == woordReverse.ToLower()) 

            //{

            //    return true;

            //}

            //else

            //{

            //    return false;

            //}

            #endregion

            #region Zakaria

            //char[] array = str.ToCharArray();

            //string str2 = "";

            //for(int i = array.Length -1; i >= 0; i--)

            //{

            //    str2 += array[i];

            //}

            //if(str2 == new string(array)) return true;

            //else return false;

            #endregion

            #region Hasan

            //string word = "";

            //for (int i = str.Length - 1; i >= 0; i--)

            //{

            //    word += str[i];

            //}

            //return word.Equals(str);

            #endregion

            #region Dritan

            string reversedText = new string(str.Reverse().ToArray());

            return str.Equals(reversedText);

            #endregion

        }
        public static int WoordTellen(this string str)
        {
            string[] words = str.Split(' ');

            int aantalWoorden = words.Length;

            return aantalWoorden;

        }
        public static string NaarTitelNotatie(this string str)

        {

            str = str.ToLower();

            string[] words = str.Split(" ");

            for (int i = 0; i < words.Length; i++)

            {

                if (i == 0)

                {

                    char[] letters = words[i].ToCharArray();

                    letters[0] = char.ToUpper(letters[0]);

                    words[i] = new string(letters);

                }

                else

                {

                    words[i] = words[i].ToLower();

                }

            }

            return str;

            #region Salvatore

            //string[] strArr = str.ToLower().Split().ToArray();

            //List<string> titelList = new List<string>();

            //foreach (var item in strArr)

            //{

            //    string capital = item.Substring(0, 1).ToUpper();

            //    string rest = item.Substring(1).ToLower();

            //    string full = capital + rest;

            //    titelList.Add(full);

            //}

            //return string.Join(" ", titelList);

            #endregion

            #region santiago

            //TextInfo textInfo = new CultureInfo("en-US").TextInfo;

            //return textInfo.ToTitleCase(str.ToLower());

            #endregion

        }

    }
}
