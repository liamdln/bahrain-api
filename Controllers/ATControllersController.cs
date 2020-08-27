using System.Collections.Generic;
using bahrain_api.Models;
using bahrain_api.Data;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using bahrain_api.DTOs;
using Microsoft.AspNetCore.JsonPatch;

namespace bahrain_api.Controllers
{
    [Route("controllers")]
    [ApiController]
    public class ATControllersController : ControllerBase
    {
        private readonly IATControllerRepo repository;
        private readonly IMapper mapper;

        //private readonly MockATControllerRepo _repository = new MockATControllerRepo();

        public ATControllersController(IATControllerRepo repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        /////////////
        // GETTING //
        /////////////

        // TODO:
        // Add authorization - this will be a problem under GDPR.

        //GET api.bahrainvacc.com/controllers
        [HttpGet]
        public ActionResult <IEnumerable<ATControllerReadDTO>> GetAllControllers()
        {
            var controllerItems = this.repository.GetAllControllers();

            return Ok(this.mapper.Map<IEnumerable<ATControllerReadDTO>>(controllerItems));
        }

        //GET api.bahrainvacc.com/controllers/{id}
        [HttpGet("id/{id}", Name="GetControllerByID")]
        public ActionResult<ATControllerReadDTO> GetControllerByID(int id)
        {

            var controllerItem = this.repository.GetControllerByID(id);

            if (controllerItem != null) {
                return Ok(this.mapper.Map<ATControllerReadDTO>(controllerItem));
            } else {
                return NotFound();
            }

        }

        [HttpGet("cid/{cid}")]
        public ActionResult<ATControllerReadDTO> GetControllerByNetworkID(string networkID)
        {

            var controllerItem = this.repository.GetControllerByNetworkID(networkID);
            if (controllerItem != null) {
                return Ok(this.mapper.Map<ATControllerReadDTO>(controllerItem));
            } else {
                return NotFound();
            }

        }

        [HttpGet("ratings/{rating}")]
        public ActionResult<IEnumerable<ATControllerReadDTO>> GetControllerByRating(string rating)
        {

            var controllerItems = this.repository.GetControllerByRating(rating);

            return Ok(this.mapper.Map<IEnumerable<ATControllerReadDTO>>(controllerItems));

        }

        //TODO: Fix this: Browser doesn't like commas.

        // [HttpGet("approved-positions/{positions}")]
        // public ActionResult<ATController> GetControllerByPosition(string position)
        // {

        //     var controllerItem = this.repository.GetControllerByNetworkID(position);

        //     return Ok(controllerItem);

        // }

        [HttpGet("on-solo")]
        public ActionResult<IEnumerable<ATControllerReadDTO>> GetControllerBySoloVal()
        {

            var controllerItems = this.repository.GetSignedOffControllers();

            return Ok(this.mapper.Map<IEnumerable<ATControllerReadDTO>>(controllerItems));

        }

        [HttpGet("signed-off")]
        public ActionResult<IEnumerable<ATControllerReadDTO>> GetControllerBySignOff()
        {

            var controllerItems = this.repository.GetSignedOffControllers();

            return Ok(this.mapper.Map<IEnumerable<ATControllerReadDTO>>(controllerItems));

        }

        //TODO add pages for listing visitors

        /////////////
        // POSTING //
        /////////////

        //TODO:
        // Add authorization. Don't want any random adding stuff.

        //POST api.bahrainvacc.com/controllers
        [HttpPost]
        public ActionResult <ATControllerReadDTO> AddATController(ATControllerCreateDTO controllerCreateDTO)
        {
            var controllerModel = this.mapper.Map<ATController>(controllerCreateDTO);
            this.repository.AddATController(controllerModel);
            this.repository.SaveChanges();

            var controllerReadDTO = this.mapper.Map<ATControllerReadDTO>(controllerModel);

            return CreatedAtRoute(nameof(GetControllerByID), new {ID = controllerReadDTO.id}, controllerReadDTO);
        }

        /////////////
        // PUTTING //
        /////////////

        //TODO:
        //Add putting for other elements, such as name, rating etc.
        //Add authorization.

        //PUT api.bahrainvacc.com/controllers/id/{id}
        [HttpPut("id/{id}")]
        public ActionResult UpdateATController(int ID, ATControllerUpdateDTO controllerUpdateDTO)
        {
            var controllerFromRepo = this.repository.GetControllerByID(ID);
            if (controllerFromRepo == null)
            {
                return NotFound();
            }

            this.mapper.Map(controllerUpdateDTO, controllerFromRepo);
            this.repository.UpdateATController(controllerFromRepo);
            this.repository.SaveChanges();

            return NoContent();

        }


        //////////////
        // PATCHING //
        //////////////

        //Example:
        // [
        //     {
        //         "op": "replace",
        //         "path": "/fullName",
        //         "value": "Steve Door"
        //     }
        // ]

        //TODO:
        //Add putting for other elements, such as name, rating etc.
        // Add authorization

        //PATCH api.bahrainvacc.com/controllers/id/{id}
        [HttpPatch("id/{id}")]
        public ActionResult PatchATController(int ID, JsonPatchDocument<ATControllerUpdateDTO> patchDoc)
        {

            var controllerFromRepo = this.repository.GetControllerByID(ID);
            if (controllerFromRepo == null) 
            {
                return NotFound();
            }

            var controllerToPatch = this.mapper.Map<ATControllerUpdateDTO>(controllerFromRepo);
            patchDoc.ApplyTo(controllerToPatch, ModelState); //Modelstate checking if model validations are valid, nice

            if (!TryValidateModel(controllerToPatch))
            {
                return ValidationProblem(ModelState);
            }

            this.mapper.Map(controllerToPatch, controllerFromRepo);
            this.repository.UpdateATController(controllerFromRepo); //I think these two lines do the same thing?

            this.repository.SaveChanges();

            return NoContent();

        }

        //////////////
        // DELETING //
        //////////////

        //Deleting should only be called when a user leaves the vACC or requests that their data be deleted under GDPR.

        //TODO:
        // Add authorization!!!!
        // Add VATSIM ID as a way to find a user to delete.

        //DELETE api.bahrainvacc.com/controllers/id/{id}
        [HttpDelete("id/{id}")]
        public ActionResult DeleteATController(int ID)
        {
            var controllerFromRepo = this.repository.GetControllerByID(ID);
            if (controllerFromRepo == null) 
            {
                return NotFound();
            }

            this.repository.DeleteController(controllerFromRepo);
            this.repository.SaveChanges();

            //return NoContent();
            //We are going to return the deleted record just in case it was an accident, the user can copy it and put it back.
            //or in the system, we can add an undo button while the delete successful page is still active - it can keep the response until the user leaves the page.
            return Ok(this.mapper.Map<ATControllerReadDTO>(controllerFromRepo));

        }

    }
}