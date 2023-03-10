/*
 * Сервис роботов-пылесосов
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RobotsApiController : ControllerBase
    { 
        /// <summary>
        /// Метод удаления робота из облака по номеру
        /// </summary>
        /// <param name="fabrickNumber">Уникальный id робота</param>
        /// <response code="200">Успешный ответ на удаление устройства</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="0">Все остальное</response>
        [HttpDelete]
        [Route("/robots/{fabrick_number}")]
        [ValidateModelState]
        [SwaggerOperation("CencelRobotsByNumber")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error404), description: "Not Found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error500), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "Все остальное")]
        public virtual IActionResult CencelRobotsByNumber([FromRoute][Required]int? fabrickNumber)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error404));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error500));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод подключения робота
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Успешный ответ на подключение робота</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="0">Все остальное</response>
        [HttpPost]
        [Route("/robots")]
        [ValidateModelState]
        [SwaggerOperation("CreateRobotCleaner")]
        [SwaggerResponse(statusCode: 200, type: typeof(RobotCleaner), description: "Успешный ответ на подключение робота")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error404), description: "Not Found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error500), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "Все остальное")]
        public virtual IActionResult CreateRobotCleaner([FromBody]Error body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RobotCleaner));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error404));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error500));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"resources\" : 90,\n  \"fabrick_number\" : 792566,\n  \"id_group\" : 2,\n  \"ip_adress\" : \"192.128.8.5\",\n  \"status\" : \"Зарядка\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RobotCleaner>(exampleJson)
                        : default(RobotCleaner);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Метод получения списка привязанных устройств
        /// </summary>
        /// <response code="200">Успешный ответ со списком привязанных устройств</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="0">Все остальное</response>
        [HttpGet]
        [Route("/robots")]
        [ValidateModelState]
        [SwaggerOperation("GetAllRobots")]
        [SwaggerResponse(statusCode: 200, type: typeof(Robots), description: "Успешный ответ со списком привязанных устройств")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error404), description: "Not Found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error500), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "Все остальное")]
        public virtual IActionResult GetAllRobots()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Robots));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error404));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error500));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));
            string exampleJson = null;
            exampleJson = "[ {\n  \"resources\" : 90,\n  \"fabrick_number\" : 792566,\n  \"id_group\" : 2,\n  \"ip_adress\" : \"192.128.8.5\",\n  \"status\" : \"Зарядка\"\n}, {\n  \"resources\" : 90,\n  \"fabrick_number\" : 792566,\n  \"id_group\" : 2,\n  \"ip_adress\" : \"192.128.8.5\",\n  \"status\" : \"Зарядка\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Robots>(exampleJson)
                        : default(Robots);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Метод получения привязанного устройства по ID
        /// </summary>
        /// <param name="fabrickNumber">Уникальный id устройства</param>
        /// <response code="200">Успешный ответ с параметрами устройства</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="0">Все остальное</response>
        [HttpGet]
        [Route("/robots/{fabrick_number}")]
        [ValidateModelState]
        [SwaggerOperation("GetRobot")]
        [SwaggerResponse(statusCode: 200, type: typeof(RobotCleaner), description: "Успешный ответ с параметрами устройства")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error404), description: "Not Found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error500), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "Все остальное")]
        public virtual IActionResult GetRobot([FromRoute][Required]int? fabrickNumber)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RobotCleaner));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error404));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error500));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"resources\" : 90,\n  \"fabrick_number\" : 792566,\n  \"id_group\" : 2,\n  \"ip_adress\" : \"192.128.8.5\",\n  \"status\" : \"Зарядка\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RobotCleaner>(exampleJson)
                        : default(RobotCleaner);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
