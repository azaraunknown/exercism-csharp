static class LogLine
{
    public static string Message(string logLine)
    {
        var s = logLine.Trim();
        var colon = s.IndexOf(':');
        return s[(colon + 1)..].TrimStart();
    }

    public static string LogLevel(string logLine)
    {
        var s = logLine.Trim();
        var end = s.IndexOf(']');
        return s[1..end].ToLowerInvariant();
    }

    public static string Reformat(string logLine)
    {
        var s = logLine.Trim();
        var end = s.IndexOf(']');
        var level = s[1..end].ToLowerInvariant();

        var colon = s.IndexOf(':', end);
        var message = s[(colon + 1)..].TrimStart();

        return $"{message} ({level})";
    }
}