using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GuildWebSite;

namespace GuildWebSite.Controllers
{
    public class GuildRecruitmentsController : Controller
    {
        private GuildRecruitmentEntities db = new GuildRecruitmentEntities();

        // GET: GuilRecruitments
        public ActionResult Index()
        {
            return View(db.GuilRecruitments.ToList());
        }

        // GET: GuilRecruitments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuilRecruitment guilRecruitment = db.GuilRecruitments.Find(id);
            if (guilRecruitment == null)
            {
                return HttpNotFound();
            }
            return View(guilRecruitment);
        }

        // GET: GuilRecruitments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GuilRecruitments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RcruitID,CharacterName,Realm,Class,Specialization,Offspec,RaidTimes,RaidingExperience,CombatLogs,ArmoryLink,Age,TellUsMore,hardcore,BattleTag,Why,Reasons")] GuilRecruitment guilRecruitment)
        {
            if (ModelState.IsValid)
            {
                db.GuilRecruitments.Add(guilRecruitment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guilRecruitment);
        }

        // GET: GuilRecruitments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuilRecruitment guilRecruitment = db.GuilRecruitments.Find(id);
            if (guilRecruitment == null)
            {
                return HttpNotFound();
            }
            return View(guilRecruitment);
        }

        // POST: GuilRecruitments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RcruitID,CharacterName,Realm,Class,Specialization,Offspec,RaidTimes,RaidingExperience,CombatLogs,ArmoryLink,Age,TellUsMore,hardcore,BattleTag,Why,Reasons")] GuilRecruitment guilRecruitment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guilRecruitment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guilRecruitment);
        }

        // GET: GuilRecruitments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuilRecruitment guilRecruitment = db.GuilRecruitments.Find(id);
            if (guilRecruitment == null)
            {
                return HttpNotFound();
            }
            return View(guilRecruitment);
        }

        // POST: GuilRecruitments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GuilRecruitment guilRecruitment = db.GuilRecruitments.Find(id);
            db.GuilRecruitments.Remove(guilRecruitment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
