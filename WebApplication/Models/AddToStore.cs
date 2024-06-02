using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AddToStore
    {
        public int StoreID { get; set; }
        public int AlbumID { get; set; }

        public List<Album> Albums { get; set; }

        public AddToStore()
        {
            Albums = new List<Album>();
        }
    }
}