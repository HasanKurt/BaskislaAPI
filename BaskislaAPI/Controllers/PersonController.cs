using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaskislaAPI.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public PersonController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllPersons()
        {
            try
            {
                var persons = _repository.Person.GetAllPersons();
                _logger.LogInfo($"Returned all persons from database.");

                var personsResult = _mapper.Map<IEnumerable<PersonDTO>>(persons);

                return Ok(persons);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllPersons action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "PersonById")]
        //https://code-maze.com/async-generic-repository-pattern/. For now, only make this async
        public async Task<IActionResult> GetPersonByIdAsync(int id)
        {
            try
            {
                var owner = await _repository.Person.GetPersonByIdAsync(id);
                //var spouseId = _repository.Person.GetSpouse(id);

                //add spounse info to person
                //todo?????? HOW to do

                if (owner == null)
                {
                    _logger.LogError($"Person with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned person with id: {id}");

                    var ownerResult = _mapper.Map<PersonDTO>(owner);
                    return Ok(ownerResult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetDetailsOfPerson(int id)
        {
            try
            {
                var viewModel = await _repository.Person.GetPersonDetailsByIdAsync(id);

                if (viewModel == null)
                {
                    _logger.LogError($"Person with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned persondetails with name: {viewModel.FirstName}");
                    var ownerResult = _mapper.Map<PersonDetailsDTO>(viewModel);

                    return Ok(ownerResult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


        

        //[HttpGet("{id}/children")]
        //public IActionResult GetAllChildren(int id)
        //{
        //    try
        //    {
        //        _logger.LogInfo($"Returned all persons from database.");

        //        var children = _repository.Person.GetAllChildren(id);

        //        var personsResult = _mapper.Map<IEnumerable<PersonDTO>>(children);

        //        return Ok(personsResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside GetAllPersons action: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}





        //[HttpPost]
        public IActionResult CreateOwner([FromBody]PersonForCreationDTO person)
        {
            try
            {
                if (person == null)
                {
                    _logger.LogError("Person object sent from client is null.");
                    return BadRequest("person object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid person object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var personEntity = _mapper.Map<Person>(person);

                _repository.Person.CreatePerson(personEntity);
                _repository.Save();

                var createdPerson = _mapper.Map<PersonDTO>(personEntity);

                return CreatedAtRoute("PersonById", new { id = createdPerson.Id }, createdPerson);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreatePerson action: {ex.Message}");
                return StatusCode(500, "Internal server error during post");
            }
        }

        //[HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, [FromBody] PersonForUpdateDto person)
        {
            try
            {
                if (person == null)
                {
                    _logger.LogError("Owner object sent from client is null.");
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid person object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var personEntity = _repository.Person.GetPersonById(id);
                if (personEntity == null)
                {
                    _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _mapper.Map(person, personEntity);

                _repository.Person.UpdatePerson(personEntity);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Updateperson action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        //[HttpDelete("{id}")]
        public IActionResult DeleteOwner(int id)
        {
            try
            {
                var person = _repository.Person.GetPersonById(id);
                if (person == null)
                {
                    _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.Person.DeletePerson(person);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteOwner action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }



    }
}