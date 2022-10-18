using AutoMapper;
using ToDo.Common.Extensions;
using ToDo.DbModel.Models;
using ToDo.ModelView.ModelView;

namespace ToDo.Core.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserModelView>().ReverseMap();
            CreateMap<User, LoginUserResponseView>().ReverseMap();
            CreateMap<User, UserResultView>().ReverseMap();
            CreateMap<Todo, TodoResultView>().ReverseMap();
            CreateMap<Todo, TodoModelView>().ReverseMap();
            CreateMap<PagedResult<TodoModelView>, PagedResult<Todo>>().ReverseMap();
            CreateMap<PagedResult<UserModelView>, PagedResult<User>>().ReverseMap();
            CreateMap<TodoModelView, UserModelView>().ReverseMap();
        }
    }
}
