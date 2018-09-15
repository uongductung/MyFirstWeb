using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstWeb.Models;

namespace MyFirstWeb.Controllers
{
    public class StoreManageController : Controller
    {
        public MusicStoreEntities objMusicStore = new MusicStoreEntities();
        // GET: StoreManage
        public ActionResult Index()
        {
            SampleData sample = new SampleData();
            objMusicStore = sample.Seed();
            return View(objMusicStore);
        }

        // GET: StoreManage/Details/5
        public ActionResult Details(int id)
        {
            SampleData sample = new SampleData();
            objMusicStore = sample.Seed();
            Album AlbumDetails = new Album();
            AlbumDetails=objMusicStore.GetAlbums().Find(x=>x.AlbumId==id);
            return View(AlbumDetails);
        }

        // GET: StoreManage/Create
        public ActionResult Create()
        {
            SampleData sample = new SampleData();
            ViewBag.ArtistList =new  SelectList(sample.GetArtists(),"ArtistId","Name");
            ViewBag.GenreList = new SelectList(sample.Seed().GetGenres(), "GenreId", "Name");
            Album album = new Album();
            return View(album);
        }

        // POST: StoreManage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreManage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreManage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
