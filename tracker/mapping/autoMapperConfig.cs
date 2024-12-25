using AutoMapper;
using dtoLayer.appUserDtos;
using dtoLayer.companyUserDtos;
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

            CreateMap<addUserDto, AppUser>().ReverseMap();
            CreateMap<updateUserDto, AppUser>().ReverseMap();

            CreateMap<addCompanyUserDto, companyUser>().ReverseMap();
            CreateMap<updateCompanyUserDto, companyUser>().ReverseMap();
        }
    }
}
