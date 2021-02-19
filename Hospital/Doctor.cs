namespace Hospital
{
    using System.Collections.Generic;

    public class Doctor
    {
        private string name;
        private string surname;
        private HashSet<Patient> patients;

        public Doctor(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            patients = new HashSet<Patient>();
        }
        public void AddPatient(string[] tokens)
        {
            var patientName = tokens[3];
            Patient patient = new Patient(patientName);
            patients.Add(patient);
        }
    }
}