using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.DataAccess;

namespace WebApplication1.Controllers
{
    public class AuthorController : ApiController
    {
        private IdotTP2Entities db = new IdotTP2Entities();

        // GET: api/Author
        public IQueryable<T_Author> GetT_Author()
        {
            return db.T_Author;
        }

        // GET: api/Author/5
        [ResponseType(typeof(T_Author))]
        public IHttpActionResult GetT_Author(long id)
        {
            T_Author t_Author = db.T_Author.Find(id);
            if (t_Author == null)
            {
                return NotFound();
            }

            return Ok(t_Author);
        }

        // PUT: api/Author/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutT_Author(long id, T_Author t_Author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_Author.Id)
            {
                return BadRequest();
            }

            db.Entry(t_Author).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_AuthorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Author
        [ResponseType(typeof(T_Author))]
        public IHttpActionResult PostT_Author(T_Author t_Author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.T_Author.Add(t_Author);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = t_Author.Id }, t_Author);
        }

        // DELETE: api/Author/5
        [ResponseType(typeof(T_Author))]
        public IHttpActionResult DeleteT_Author(long id)
        {
            T_Author t_Author = db.T_Author.Find(id);
            if (t_Author == null)
            {
                return NotFound();
            }

            db.T_Author.Remove(t_Author);
            db.SaveChanges();

            return Ok(t_Author);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool T_AuthorExists(long id)
        {
            return db.T_Author.Count(e => e.Id == id) > 0;
        }
    }
}