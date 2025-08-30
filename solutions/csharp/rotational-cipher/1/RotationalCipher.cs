public static class RotationalCipher
{
    private static string finalString;

    public static string Rotate(string text, int shiftKey)
    {
        char RotatedChar;
        finalString = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                RotatedChar = (char)(c + shiftKey);
                if (RotatedChar > 'z')
                {
                    RotatedChar = (char)(RotatedChar - 26);
                }
                else if (RotatedChar > 'Z' && char.IsUpper(c))
                {
                    RotatedChar = (char)(RotatedChar - 26);
                }

                finalString += RotatedChar;
            }

            else
            {
                finalString += c;
            }
        }

        return finalString;
    }
}