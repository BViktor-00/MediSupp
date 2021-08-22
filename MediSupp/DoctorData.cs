using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediSupp
{
    class DoctorData
    {
        private DoctorRepository doctorRepository = new DoctorRepository();

        public List<Doctor> doctorsList = new List<Doctor>();

        public void getDoctors()
        {
            doctorsList = doctorRepository.OrvosAdatAdatLekeres();
        }

        public DoctorData()
        {
            getDoctors();
        }
        
    }
}
