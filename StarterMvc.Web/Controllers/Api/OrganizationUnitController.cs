using StarterMvc.Web.Core;
using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Persistence;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace StarterMvc.Web.Controllers.Api
{
    public class OrganizationUnitController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrganizationUnitController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }

        // GET /api/organizationunits
        public IEnumerable<OrganizationUnit> GetOrganizationUnitsList()
        {
            return _unitOfWork.OrganizationUnits.GetAll();
        }

        // GET /api/organizationunits/1
        public IHttpActionResult GetOrganizationUnit(int id)
        {
            //var organizationUnit = _context.OrganizationUnits.SingleOrDefault(x => x.Id == id);
            var organizationUnit = _unitOfWork.OrganizationUnits.Get(id);
            if (organizationUnit == null)
                NotFound();

            return Ok(organizationUnit);
        }

        // POST /api/organizationunits
        [HttpPost]
        public IHttpActionResult CreateOrganizationUnit(OrganizationUnit organizationUnit)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _unitOfWork.OrganizationUnits.Add(organizationUnit);
            _unitOfWork.Commit();

            return Created(new Uri(Request.RequestUri + "/" + organizationUnit.Id), organizationUnit);
        }

        // PUT /api/organizationunits/1    
        [HttpPut]
        public void UpdateOrganizationUnit(int id, OrganizationUnit organizationUnit)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var organizationUnitInDb = _unitOfWork.OrganizationUnits.Get(id);

            if (organizationUnitInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            organizationUnitInDb.Code = organizationUnit.Code;
            organizationUnitInDb.Description = organizationUnit.Description;
            organizationUnitInDb.IsActive = organizationUnit.IsActive;

            _unitOfWork.Commit();
        }

        // DELETE /api/organizationunits/1
        [HttpDelete]
        public void DeleteOrganizationUnits(int id)
        {
            var organizationUnitInDb = _unitOfWork.OrganizationUnits.Get(id);

            if (organizationUnitInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _unitOfWork.OrganizationUnits.Remove(organizationUnitInDb);
            _unitOfWork.Commit();
        }

    }
}















