using Lol.Data.Codes;
using NAudio.CoreAudioApi;
using System.Collections.Generic;

namespace Lol.ExampleData.Setting
{
    public partial class ExamSettings
    {
        public static List<AudioDevice> GetAudioDeviceList()
        {
            List<AudioDevice> source = new();
            MMDeviceEnumerator enumerator = new();

            foreach (MMDevice endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            {
                source.Add(new AudioDevice { Name = $"{endpoint.FriendlyName}" });
            }
            return source;
        }
    }
}
