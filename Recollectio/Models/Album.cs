using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recollectio.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType (DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        public List<Track> TrackList { get; set; }
        public string RecordLabel { get; set; }
    }
}