﻿using System;
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
        public IActionResult GetPersonById(int id)
        {
            try
            {
                var owner = _repository.Person.GetPersonById(id);

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

        [HttpGet("{id}/wife")]
        public IActionResult GetWifeOfMale(int id)
        {
            try
            {
                var stringWifeName = _repository.Person.GetWifeOfMale(id);

                if (stringWifeName == null)
                {
                    _logger.LogError($"Person with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned person with name: {stringWifeName}");

                    return Ok(stringWifeName);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}/children")]
        public IActionResult GetAllChildren(int id)
        {
            try
            {
                _logger.LogInfo($"Returned all persons from database.");

                var children = _repository.Person.GetAllChildren(id);

                var personsResult = _mapper.Map<IEnumerable<PersonDTO>>(children);

                return Ok(personsResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllPersons action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }




        [HttpPost]
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



    }
}