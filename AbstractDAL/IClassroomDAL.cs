﻿using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IClassroomDAL
    {
        int AddClassroom();

        int DeleteClassroomByClassroomId();

        int UpdateClassroomByClassroomId();

        Classroom GetClassroomByClassroomId();

    }
}
