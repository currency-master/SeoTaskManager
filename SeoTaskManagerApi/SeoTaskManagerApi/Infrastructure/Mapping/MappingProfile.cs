using AutoMapper;
using SeoTaskManager.Domain.Models;
using SeoTaskManagerApi.Models;

namespace SeoTaskManagerApi.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserTask, ParserTaskResponse>();

            CreateMap<TaskResult, UserTask>();
        }
    }
}