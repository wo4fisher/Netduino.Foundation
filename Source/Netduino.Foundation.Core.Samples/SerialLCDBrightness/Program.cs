using System.Threading;
using Microsoft.SPOT;
using H = Microsoft.SPOT.Hardware;
using N = SecretLabs.NETMF.Hardware.Netduino;
using Netduino.Foundation.Displays;

namespace Netduino.Foundation.Core.Samples
{
    public class Program
    {
        public static void Main()
        {
            SerialLCD _display = new SerialLCD();

            _display.SetBrightness(140);

            _display.WriteLine("Hello, line 2.", 1);

            while (true)
            {
                float bValue = 0f;
                for (int i = 0; i <= 100; i++)
                {
                    bValue = (float)i / (float)100;
                    _display.WriteLine("Brightness: " + i.ToString() + "%", 0);
                    Debug.Print("Brightness: " + i.ToString() + "%");
                    _display.SetBrightness(bValue);
                }

                //Thread.Sleep(1000);
            }

        }
    }
}
