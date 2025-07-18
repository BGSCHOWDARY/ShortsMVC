using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortsMVC.Models
{
    public class Short
    {
        
            public int Id { get; set; }
            public string ShortTitle { get; set; }
            public string ShortYouTubeUrl { get; set; }
            public string SongTitle { get; set; }
            public string SongYouTubeUrl { get; set; }
        }
    }
