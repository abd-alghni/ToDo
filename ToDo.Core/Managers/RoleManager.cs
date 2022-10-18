/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ToDo.Core.Managers.Interfaces;
using ToDo.DbModel;
using ToDo.ModelView.ModelView;

namespace ToDo.Core.Managers
{
    public class RoleManager : IRoleManager
    {
        private tododbContext _tododbContext;
        private IMapper _mapper;

        public RoleManager(tododbContext tododbContext, IMapper mapper)
        {
            _tododbContext = tododbContext;
            _mapper = mapper;
        }

        public bool CheckAccess(UserModelView userModel)
        {
            var isAdmin = _tododbContext.Users.Any(a => a.Id == userModel.Id 
                                                        && a.IsAdmin);
            return isAdmin;
        }
    }
}
*/