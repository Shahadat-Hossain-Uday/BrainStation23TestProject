using BrainStation23TestProject.DBContext;
using BrainStation23TestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrainStation23TestProject.Controllers
{
    public class HomeController : Controller
    {
        BSTDBContext db = new BSTDBContext();

        public ActionResult Index()
        {
            List<Post> postList = new List<Post>();
            postList = db.Post.ToList();          
            return View(GetpostList(postList));
        }

        public List<Post> GetpostList(List<Post> postlist)
        {

            List<Post> Allpost = new List<Post>();
            if (postlist.Count > 0)
            {
                foreach (var item in postlist)
                {
                    item.comments = db.Comment.Where(y => y.postID == item.postID).ToList();

                    Allpost.Add(item);
                }
            }

            return Allpost;
        }
    }
}