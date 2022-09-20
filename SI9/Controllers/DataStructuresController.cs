using AutoMapper;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SI9.Datas.Repositories;
using SI9.DTOs;

namespace SI9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructuresController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public DataStructuresController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("Stack")]
        [HttpGet]
        public async Task<IActionResult> GetStack()
        {
            string nameOfStructure = "Stack";
            var dataStructure = await _unitOfWork.dataStructureRepository.GetSingleDataStructure(nameOfStructure);
            if (dataStructure == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DataStructureReadDto>(dataStructure));

        }

        [Route("Queue")]
        [HttpGet]
        public async Task<IActionResult> GetQueue()
        {
            string nameOfStructure = "Queue";
            var dataStructure = await _unitOfWork.dataStructureRepository.GetSingleDataStructure(nameOfStructure);
            if (dataStructure == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DataStructureReadDto>(dataStructure));

        }

        [Route("LinkedList")]
        [HttpGet]
        public async Task<IActionResult> GetLinkedList()
        {
            string nameOfStructure = "Linked List";
            var dataStructure = await _unitOfWork.dataStructureRepository.GetSingleDataStructure(nameOfStructure);
            if (dataStructure == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DataStructureReadDto>(dataStructure));

        }

        [Route("HashTable")]
        [HttpGet]
        public async Task<IActionResult> GetHashTable()
        {
            string nameOfStructure = "Hash Table";
            var dataStructure = await _unitOfWork.dataStructureRepository.GetSingleDataStructure(nameOfStructure);
            if (dataStructure == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DataStructureReadDto>(dataStructure));

        }

        [Route("BinarySearchTree")]
        [HttpGet]
        public async Task<IActionResult> GetBinarySearchTree()
        {
            string nameOfStructure = "Binary Search Tree";
            var dataStructure = await _unitOfWork.dataStructureRepository.GetSingleDataStructure(nameOfStructure);
            if (dataStructure == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DataStructureReadDto>(dataStructure));

        }

        [Route("Graph")]
        [HttpGet]
        public async Task<IActionResult> GetGraph()
        {
            string nameOfStructure = "Graph";
            var dataStructure = await _unitOfWork.dataStructureRepository.GetSingleDataStructure(nameOfStructure);
            if (dataStructure == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DataStructureReadDto>(dataStructure));

        }
    }
}
