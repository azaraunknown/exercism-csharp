public static class Identifier
{
    public static string Clean(string identifier)
    {
        var cleaned = new System.Text.StringBuilder();
        bool nextUpper = false;

        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                cleaned.Append("CTRL");
                continue;
            }

            if (char.IsWhiteSpace(c))
            {
                cleaned.Append("_");
                continue;
            }

            if (c == '-')
            {
                nextUpper = true;
                continue;
            }

            // Omit *lowercase* Greek letters (keep uppercase)
            bool inGreekBlock =
                (c >= '\u0370' && c <= '\u03FF') ||
                (c >= '\u1F00' && c <= '\u1FFF');

            if (inGreekBlock && char.IsLower(c))
            {
                continue;
            }

            if (char.IsLetter(c) || c == '_')
            {
                if (nextUpper)
                {
                    cleaned.Append(char.ToUpperInvariant(c));
                    nextUpper = false;
                }
                else
                {
                    cleaned.Append(c);
                }
            }
        }

        return cleaned.ToString();
    }
}