using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    internal class MediaItem
    {

        public string title;
        public string MediaType;
        public TimeSpan duration;

        public MediaItem(string title , string mediaType, TimeSpan duration)
        {
            this.title = title;
            this.duration = duration;
            this.MediaType = mediaType;
        }
    }
}
