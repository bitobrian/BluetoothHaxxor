using InTheHand.Net.Sockets;

namespace BluetoothHaxxor;

public class DetectBluetooth
{
    public void DetectBluetoothDevices()
    {
        BluetoothClient bluetoothClient = new BluetoothClient();
        var tacos = true;

        while (tacos)
        {
            Console.WriteLine("Scanning for devices...");

            var devices = bluetoothClient.DiscoverDevices();

            if (devices.Count > 0)
            {
                Console.WriteLine($"Found {devices.Count} devices");

                foreach (var device in devices)
                {
                    Console.WriteLine($"Found device: {device.DeviceName} - {device.DeviceAddress}");
                }
                
                tacos = false;
            }
            else
            {
                Console.WriteLine("No devices found");
            }

            Thread.Sleep(1000);
        }

    }
}


