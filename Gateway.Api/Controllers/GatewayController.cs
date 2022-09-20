using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace Gateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public GatewayController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        [Route("Stack")]
        public async Task<IActionResult> Stack()
            => await ProxyTo("http://si9/api/DataStructures/Stack");

        [HttpGet]
        [Route("Queue")]
        public async Task<IActionResult> Queue()
            => await ProxyTo("http://si9/api/DataStructures/Queue");

        [HttpGet]
        [Route("LinkedList")]
        public async Task<IActionResult> LinkedList()
            => await ProxyTo("http://si9/api/DataStructures/LinkedList");

        [HttpGet]
        [Route("HashTable")]
        public async Task<IActionResult> HashTable()
            => await ProxyTo("http://si9/api/DataStructures/HashTable");

        [HttpGet]
        [Route("BinarySearchTree")]
        public async Task<IActionResult> BinarySearchTree()
            => await ProxyTo("http://si9/api/DataStructures/BinarySearchTree");

        [HttpGet]
        [Route("Graph")]
        public async Task<IActionResult> Graph()
            => await ProxyTo("http://si9/api/DataStructures/Graph");

        private async Task<ContentResult> ProxyTo(string url)
            => Content(await _httpClient.GetStringAsync(url));

    }
}
