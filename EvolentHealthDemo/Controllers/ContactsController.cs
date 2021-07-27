using EvolentHealth.Providers.Repository;
using EvolnetHealth.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvolentHealthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ContactsController : ControllerBase
    {
        private readonly IContactsRepository _contactsRepository;
        public ContactsController(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository ??
                throw new ArgumentNullException(nameof(contactsRepository));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> GetAll()
        {
            return Ok(_contactsRepository.GetAll());
        }

        [HttpGet("{id}", Name = "GetContacts")]
        public ActionResult GetById(int id)
        {
            var item = _contactsRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        [Authorize]
        [AllowAnonymous]
        public IActionResult Create([FromBody] Contacts item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _contactsRepository.Add(item);
            return CreatedAtRoute("GetContacts", new { Controller = "Contacts", id = item.Id }, item);
        }

        [HttpPut("{id}")]
        [Authorize]
        [AllowAnonymous]
        public ActionResult Update(int id, [FromBody] Contacts item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var contactObj = _contactsRepository.Find(id);
            if (contactObj == null)
            {
                return NotFound();
            }

            return Ok(_contactsRepository.Update(item));
        }

        [HttpDelete("{id}")]
        [Authorize]
        [AllowAnonymous]
        public ActionResult Delete(int id)
        {
            _contactsRepository.Remove(id);
            return NoContent();
        }
    }
}
