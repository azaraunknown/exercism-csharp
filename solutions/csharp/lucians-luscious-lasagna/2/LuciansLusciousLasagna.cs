public sealed class Lasagna
{
    private const int ExpectedOvenMinutes = 40;
    private const int MinutesPerLayer = 2;

    public int ExpectedMinutesInOven() => ExpectedOvenMinutes;

    public int RemainingMinutesInOven(int actual) => ExpectedOvenMinutes - actual;

    public int PreparationTimeInMinutes(int layers) => layers * MinutesPerLayer;

    public int ElapsedTimeInMinutes(int layers, int actual)
        => PreparationTimeInMinutes(layers) + actual;
}