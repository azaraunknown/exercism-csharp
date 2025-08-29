static class AssemblyLine
{
    private const int BaseRatePerHour = 221;

    public static double SuccessRate(int speed) => speed switch
    {
        <= 0 => 0.0,
        <= 4 => 1.0,
        <= 8 => 0.9,
        9 => 0.8,
        10 => 0.77,
        _ => 0.0
    };

    public static double ProductionRatePerHour(int speed) => speed is < 0 or > 10 ? 0.0 : speed * BaseRatePerHour * SuccessRate(speed);
    
    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}