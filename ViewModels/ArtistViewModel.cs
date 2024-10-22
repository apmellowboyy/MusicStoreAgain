using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {
        public List<Album> Albums { get; set; } = new List<Album>();
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}
