using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstWeb.Models
{
    public class MusicStoreEntities
    {
        private List<Album> albums;

        public List<Album> GetAlbums()
        {
            return albums;
        }

        public void SetAlbums(List<Album> value)
        {
            albums = value;
        }

        private List<Genre> genres;

        public MusicStoreEntities(List<Album> albums, List<Genre> genres)
        {
            this.albums = albums;
            this.genres = genres;
        }

        public MusicStoreEntities()
        {
            albums = new List<Album>();
            genres = new List<Genre>();
        }

        public List<Genre> GetGenres()
        {
            return genres;
        }

        public void SetGenres(List<Genre> value)
        {
            genres = value;
        }
    }
}