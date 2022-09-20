using AutoMapper;
using Data.Models;
using SI9.DTOs;

namespace SI9.Profiles
{
    public class DataStructureProfile: Profile
    {
        public DataStructureProfile()
        {
            CreateMap<DataStructure, DataStructureReadDto>();
        }
    }
}
