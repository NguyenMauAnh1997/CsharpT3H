﻿using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTI
{
    interface IStudentRegister
    {
        ReturnData RegisterCource(Course course, Student student);
    }
}
