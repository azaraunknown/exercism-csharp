class RemoteControlCar
{
    public static RemoteControlCar Buy() => new RemoteControlCar();

    private int distanceDriven;
    private const int distancePerDrive = 20;

    public string DistanceDisplay() => $"Driven {distanceDriven} meters";


    private int batteryPercentage = 100;

    public string BatteryDisplay() => batteryPercentage <= 0 ? "Battery empty" : $"Battery at {batteryPercentage}%";


    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            distanceDriven += distancePerDrive;
            batteryPercentage -= 1;
        }
    }
}