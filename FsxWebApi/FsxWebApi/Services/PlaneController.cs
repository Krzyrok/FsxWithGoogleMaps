﻿namespace FsxWebApi.Services
{
    using Infrastructure;
    using Model;
    using System.Web.Http;

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
        public void Post(Location newLocation)
        {
            // Pass the values to the FSX
        }
    }
}
