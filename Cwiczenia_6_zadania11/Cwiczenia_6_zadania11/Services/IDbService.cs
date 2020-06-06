using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia_6_zadania11.DTOs;
using Cwiczenia_6_zadania11.Models;

namespace Cwiczenia_6_zadania11.Services
{
    public interface IDbService
    {
        Doctor AddDoctor(AddDoctorRequest request);
        Doctor UpdateDoctor(UpdateDoctorRequest request);
        public IEnumerable<Doctor> GetDoctors();
        public string DeleteDoctor(int id);
    }
}
