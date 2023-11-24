using System;

namespace Lol.Support.Local.Models
{
    public class BackgroundChangedEventArgs : EventArgs
    {
        public Uri NewUri { get; }
        public int Seq { get; }

        public BackgroundChangedEventArgs(Uri uri)
        {
            NewUri = uri;
        }

        public BackgroundChangedEventArgs(int seq)
        {
            Seq = seq;
        }
    }
}
