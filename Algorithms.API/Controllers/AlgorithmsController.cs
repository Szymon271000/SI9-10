using Algorithms.API.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMq.API.RabbitMQ;
using Shared.DTOs;
using System.Diagnostics;

namespace Algorithms.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IRabbitMQProducer _rabbitMQProducer;

        public AlgorithmsController(IRabbitMQProducer rabbitMQProducer)
        {
            _rabbitMQProducer = rabbitMQProducer;
        }

        [HttpPost]
        [Route("/BubbleSort")]
        public IActionResult BubbleSortAlgorithm(ListDto listDto)
        {
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.BubbleSortAlgorithm(listDto.Values));
            _rabbitMQProducer.SendProductMessage(new RabbitMQMessage("BubbleSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]
        [Route("/InsertionSort")]
        public IActionResult InsertionSortAlgorithm(ListDto listDto)
        {
            
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.InsertionSortAlgorithm(listDto.Values));
            _rabbitMQProducer.SendProductMessage(new RabbitMQMessage("InsertionSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]
        [Route("/MergeSort")]
        public IActionResult MergeSortAlgorithm(ListDto listDto)
        {
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.MergeSortAlgorithm(listDto.Values));
            _rabbitMQProducer.SendProductMessage(new RabbitMQMessage("MergeSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }

        [HttpPost]
        [Route("/QuickSort")]
        public IActionResult QuickSortAlgorithm(ListDto listDto)
        {
            float timeSeconds = TimeCalculator.CountTime(() => AlgorithmsCalculator.QuickSortAlgorithm(listDto.Values));
            _rabbitMQProducer.SendProductMessage(new RabbitMQMessage("QuickSort", listDto.Values));
            return Ok(new SortResultDto(listDto.Values, timeSeconds));
        }
    }
}
