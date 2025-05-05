using System.IO.Ports;

namespace tube_mixing_software
{
    public static class SerialManager
    {
        public static SerialPort Port { get; set; }
        public static string UltimaTemperatura { get; set; }
    }
}
