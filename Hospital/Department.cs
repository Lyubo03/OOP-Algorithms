namespace Hospital
{
    using System.Collections.Generic;

    public class Department
    {
        private string specialty;
        HashSet<Doctor> doctors;

        public Department(string specialty)
        {
            this.specialty = specialty;
            this.doctors = new HashSet<Doctor>();
        }
        public void addDoc(string[] tokens)
        {
            var name = tokens[1];
            var surname = tokens[2];
            Doctor doctor = new Doctor(name, surname);
            doctors.Add(doctor);
        }
    }
}