﻿/*using AutoMapper;
using System.Linq;
using ToDo.Common.Exceptions;
using ToDo.Core.Managers.Interfaces;
using ToDo.DbModel;
using ToDo.ModelView.ModelView;

namespace ToDo.Core.Managers
{
    public class CommonManager : ICommonManager
    {
        private tododbContext _tododbContext;
        private IMapper _mapper;

        public CommonManager(tododbContext tododbContext, IMapper mapper)
        {
            _tododbContext = tododbContext;
            _mapper = mapper;
        }

        public UserModelView GetUserRole(UserModelView user)
        {
            var dbUser = _tododbContext.Users.FirstOrDefault(a => a.Id == user.Id) ??
                         throw new ServiceValidationException("Invalid user id received");
            return _mapper.Map<UserModelView>(dbUser);
        }
    }
}
*/