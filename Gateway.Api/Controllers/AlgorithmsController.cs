using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace Gateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public AlgorithmsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpPost]
        [Route("BubbleSort")]
        public async Task<IActionResult> BubbleSort(ListDto values)
        {
            var response = await _httpClient.PostAsJsonAsync("http://algorithms.api/api/BubbleSort", values);
            var result = await response.Content.ReadFromJsonAsync<SortResultDto>();
            return Ok(result);
        }

        [HttpPost]
        [Route("InsertionSort")]
        public async Task<IActionResult> InsertionSort(ListDto values)
        {
            var response = await _httpClient.PostAsJsonAsync("http://algorithms.api/api/InsertionSort", values);
            var result = await response.Content.ReadFromJsonAsync<SortResultDto>();
            return Ok(result);
        }

        [HttpPost]
        [Route("MergeSort")]
        public async Task<IActionResult> MergeSort(ListDto values)
        {
            var response = await _httpClient.PostAsJsonAsync("http://algorithms.api/api/MergeSort", values);
            var result = await response.Content.ReadFromJsonAsync<SortResultDto>();
            return Ok(result);
        }

        [HttpPost]
        [Route("QuickSort")]
        public async Task<IActionResult> QuickSort(ListDto values)
        {
            var response = await _httpClient.PostAsJsonAsync("http://algorithms.api/api/QuickSort", values);
            var result = await response.Content.ReadFromJsonAsync<SortResultDto>();
            return Ok(result);
        }
    }
}
