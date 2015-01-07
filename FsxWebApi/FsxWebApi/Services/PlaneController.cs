﻿namespace FsxWebApi.Services
{
    using System.Web.Http.Cors;
    using Infrastructure;
    using Model;
    using System.Web.Http;

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PlaneController : ApiController
    {
        private readonly FsxManager _fsxManager = new FsxManager();

        // GET: api/Plane
        public IHttpActionResult Get()
        {
            //return ActionRes;
            PlaneData planeData = _fsxManager.GetCurrentPlaneData();

            if (planeData == null)
            {
                return NotFound();
            }
            return Ok(planeData);
        }

        // POST: api/Plane
        public IHttpActionResult Post(Location newLocation)
        {
            // Pass the values to the FSX

            return Ok();
        }
    }
}
