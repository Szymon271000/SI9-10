using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SI9.DTOs;

namespace AlgDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;

        public DataStructureController(IHttpClientFactory httpClientFactory, IConfiguration _config)
        {
            _httpClient = httpClientFactory.CreateClient();
            _url = _config.GetValue<string>("Urls:DataStructures");
        }
        /// <summary>
        /// Get Stack details
        /// </summary>
        /// <returns>Get Stack details</returns>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>

        [HttpGet]
        public async Task<IActionResult> Stack()
            => Ok(await _httpClient.GetFromJsonAsync<DataStructureReadDto>($"{_url}/Stack"));

        /// <summary>
        /// Get Queue details
        /// </summary>
        /// <returns>Get Queue details</returns>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>

        [HttpGet]
        public async Task<IActionResult> Queue()
            => Ok(await _httpClient.GetFromJsonAsync<DataStructureReadDto>($"{_url}/Queue"));

        /// <summary>
        /// Get LinkedList details
        /// </summary>
        /// <returns>Get LinkedList details</returns>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>

        [HttpGet]
        public async Task<IActionResult> LinkedList()
           => Ok(await _httpClient.GetFromJsonAsync<DataStructureReadDto>($"{_url}/LinkedList"));

        /// <summary>
        /// Get HashTable details
        /// </summary>
        /// <returns>Get HashTable details</returns>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>

        [HttpGet]
        public async Task<IActionResult> HashTable()
           => Ok(await _httpClient.GetFromJsonAsync<DataStructureReadDto>($"{_url}/HashTable"));

        /// <summary>
        /// Get BinarySearchTree details
        /// </summary>
        /// <returns>Get BinarySearchTree details</returns>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>

        [HttpGet]
        public async Task<IActionResult> BinarySearchTree()
           => Ok(await _httpClient.GetFromJsonAsync<DataStructureReadDto>($"{_url}/BinarySearchTree"));

        /// <summary>
        /// Get Graph details
        /// </summary>
        /// <returns>Get Graph details</returns>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>

        [HttpGet]
        public async Task<IActionResult> Graph()
           => Ok(await _httpClient.GetFromJsonAsync<DataStructureReadDto>($"{_url}/Graph"));
    }
}
