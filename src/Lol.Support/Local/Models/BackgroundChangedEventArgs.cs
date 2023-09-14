using System;

namespace Lol.Support.Local.Models
{
    public class BackgroundChangedEventArgs : EventArgs
    {
        public Uri NewUri { get; }

        public BackgroundChangedEventArgs(Uri uri)
        {
            NewUri = uri;
        }
    }
}
