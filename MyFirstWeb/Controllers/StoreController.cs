using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstWeb.Models;

namespace Controllers
{
    public class StoreController : Controller
    {
        public MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            SampleData sample = new SampleData();
            storeDB=sample.Seed();
            var genres = storeDB.GetGenres().ToList();
            return View(genres);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            List<Album> genreModel = new List<Album>();
            try
            {
                SampleData sample = new SampleData();
                storeDB = sample.Seed();
                genreModel = storeDB.GetAlbums().FindAll(x => x.Genre.Name == genre);
                return View(genreModel);
            }
            catch (Exception ex)
            {
            }
            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            Album album = new Album();
            SampleData sample = new SampleData();
            storeDB = sample.Seed();
            album = storeDB.GetAlbums().Find(x => x.AlbumId == id);
            return View(album);
        }
    }
}