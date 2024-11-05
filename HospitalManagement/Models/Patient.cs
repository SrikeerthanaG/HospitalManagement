﻿namespace HospitalManagement.Models
{
    // Patient.cs
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
