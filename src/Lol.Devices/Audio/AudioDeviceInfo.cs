using Lol.Data.Codes;
using NAudio.CoreAudioApi;
using System.Collections.Generic;

namespace Lol.Devices.Audio
{
    public class AudioDeviceInfo
    {
        public List<AudioDevice> GetDevices()
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
