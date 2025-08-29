class BirdCount
{
    private readonly int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() => new[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var n in birdsPerDay)
            if (n == 0)
                return true;
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var upto = Math.Min(numberOfDays, birdsPerDay.Length);
        var sum = 0;
        for (var i = 0; i < upto; i++) sum += birdsPerDay[i];
        return sum;
    }

    public int BusyDays()
    {
        const int BusyThreshold = 5;
        var busy = 0;
        foreach (var n in birdsPerDay)
            if (n >= BusyThreshold)
                busy++;
        return busy;
    }
}