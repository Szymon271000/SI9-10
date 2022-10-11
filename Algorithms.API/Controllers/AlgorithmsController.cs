using Algorithms.API.Utils;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using RabbitMq.API.RabbitMQ;
using Shared.DTOs;
using System.Diagnostics;
using System.Text.Json;

namespace Algorithms.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        //private readonly IRabbitMQProducer _rabbitMQProducer;
        private readonly string _connectionString;
        private readonly string _queueName;

        public AlgorithmsController(IConfiguration _config)
        {
            _connectionString = _config.GetValue<string>("Queue:ConnectionString");
            _queueName = _config.GetValue<string>("Queue:QueueName");
        }
        //public AlgorithmsController(IRabbitMQProducer rabbitMQProducer)
        //{
        //    _rabbitMQProducer = rabbitMQProducer;
        //}

        [HttpPost]
        [Route("/BubbleSort")]
        public async Task<IActionResult> BubbleSortAlgorithm(ListDto listDto)
        {
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.BubbleSortAlgorithm(listDto.Values));
            await Post(listDto.Values);
            Thread.Sleep(5000);
            //_rabbitMQProducer.SendProductMessage(new RabbitMQMessage("BubbleSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]
        [Route("/InsertionSort")]
        public async Task<IActionResult> InsertionSortAlgorithm(ListDto listDto)
        {
            
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.InsertionSortAlgorithm(listDto.Values));
            await Post(listDto.Values);
            //_rabbitMQProducer.SendProductMessage(new RabbitMQMessage("InsertionSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]
        [Route("/MergeSort")]
        public async Task<IActionResult> MergeSortAlgorithm(ListDto listDto)
        {
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.MergeSortAlgorithm(listDto.Values));
            await Post(listDto.Values);
            //_rabbitMQProducer.SendProductMessage(new RabbitMQMessage("MergeSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]
        [Route("/QuickSort")]
        public async Task<IActionResult> QuickSortAlgorithm(ListDto listDto)
        {
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.QuickSortAlgorithm(listDto.Values));
            await Post(listDto.Values);
            //_rabbitMQProducer.SendProductMessage(new RabbitMQMessage("QuickSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]

        private async Task Post(List<int> data) 
        {
            var queueClient = new QueueClient(_connectionString, _queueName);
            var message = JsonSerializer.Serialize(data);
            await queueClient.SendMessageAsync(message);
        }
    }
}
