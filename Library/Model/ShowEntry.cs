﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;

namespace GodLesZ.Tools.RtlNowReader.Library.Model {

    public class ShowEntry {

        public string Name {
            get;
            set;
        }

        public string ThumbUrl {
            get;
            set;
        }

        public string Link {
            get;
            set;
        }

        public List<EpisodeEntry> Episodes = new List<EpisodeEntry>();


        public Image FetchThumb() {
            var client = new WebClient();
            var buf = client.DownloadData(ThumbUrl);
            using (var stream = new MemoryStream(buf)) {
                return Image.FromStream(stream);
            }
        }

    }

}