public static class Bob
{
    public static string Response(string statement){
        statement = statement?.Trim() ?? string.Empty;

        bool isQuestion = statement.EndsWith("?");
        bool isYelling = statement.ToUpper() == statement && statement.ToLower() != statement;
        bool isSilence = string.IsNullOrEmpty(statement);

        if (isSilence)
        {
            return "Fine. Be that way!";
        }

        if (isQuestion && isYelling)
        {
            return "Calm down, I know what I'm doing!";
        }

        if (isYelling)
        {
            return "Whoa, chill out!";
        }

        if (isQuestion)
        {
            return "Sure.";
        }
        
        return "Whatever.";
    }
}