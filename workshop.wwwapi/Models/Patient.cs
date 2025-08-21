﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly
    [Table("patients")]
    public class Patient
    {
        [Key]
        [Column("patient_id")]
        public int Id { get; set; }

        [Column("patient_fullname")]
        public string FullName { get; set; }

        [Column("patient_appointments")]
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
