using AutoMapper;
using dtoLayer.projectDtos;
using dtoLayer.taskStageDtos;
using entityLayer.concrete;

namespace tracker.mapping
{
    public class autoMapperConfig : Profile
    {
        public autoMapperConfig()
        {
            CreateMap<addProjectDto,project>().ReverseMap();
            CreateMap<updateProjectDto,project>().ReverseMap();

            CreateMap<addTaskStageDto, taskStage>().ReverseMap();
            CreateMap<updateTaskStageDto, taskStage>().ReverseMap();
        }
    }
}
