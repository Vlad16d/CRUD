﻿using System;
using System.Dynamic;
using ServiceContracts.DTO;
using ServiceContracts.Enums;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulating Person entity
    /// </summary>
    public interface IPersonsService
    {
        /// <summary>
        /// Adds a new person into the list of persons 
        /// </summary>
        /// <param name="personAddRequest"> Person to add </param>
        /// <returns> Returns the same person details, along with newly generated PersonID </returns>
        PersonResponse AddPerson(PersonAddRequest? personAddRequest);

        /// <summary>
        /// Returns all persons
        /// </summary>
        /// <returns> Returns a list of objects of PersonResponse type </returns>
        List<PersonResponse> GetAllPersons();

        /// <summary>
        /// Returns the person object based on the given person id 
        /// </summary>
        /// <param name="personID"></param>
        /// <returns> Returns matching person object </returns>
        PersonResponse? GetPersonByPersonID(Guid? personID);

        /// <summary>
        /// Returns all person object that matches with the given search field and search string
        /// </summary>
        /// <param name="searchBy">Search field to search</param>
        /// <param name="searchString">Search string to search</param>
        /// <returns>Returns all matching persons based on the given search field and search string</returns>
        List<PersonResponse> GetFilteredPersons(string searchBy, string? searchString);

        /// <summary>
        /// Returns sorted list of persons
        /// </summary>
        /// <param name="allPerson">Represents list of persons to sort</param>
        /// <param name="sortBy">Name of property (key), based on which the persons should be sorted</param>
        /// <param name="sortOrder">ASC or DESC</param>
        /// <returns>Returns sorted persons as PersonResponse list</returns>
        List<PersonResponse> GetSortedPersons(List<PersonResponse> allPerson, string sortBy, SortOrderOptions sortOrder);

        /// <summary>
        /// Updates the specified person details based on the given person ID 
        /// </summary>
        /// <param name="personUpdateRequest">Person details to update, incuding person id</param>
        /// <returns>Returns the person response object after updation</returns>
        PersonResponse UpdatePerson(PersonUpdateRequest? personUpdateRequest);

        /// <summary>
        /// Deletes a person based on the given person id 
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>Returns true, if the deletions is succesful; otherwise false</returns>
        bool DeletePerson(Guid? personID);
    }
}
