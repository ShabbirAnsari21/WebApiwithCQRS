using AutoMapper;
using CQRS.Api.Model.Request;
using CQRS.Business.MediatR.Command.Employee;
using CQRS.Business.MediatR.Query;
using CQRS.Domain.Entity;
using CQRS.Model.Model.Request;
using CQRS.Model.Model.Response;

namespace CQRS.Api.MProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateEmployeeRequest, CreateEmployeeCommand>();
            CreateMap<UpdateEmployeeRequest, UpdateEmployeeCommand>();
            CreateMap<Employee, EmployeeResponse>();
        }
    }
}
