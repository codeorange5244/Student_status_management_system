﻿using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IRoleDAL
    {
        /// 根据Id查询角色
        Role GetRoleByRoleId();

    }
}
