using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public string WorkerPassword { get; set; }
        public string WorkerFirstName { get; set; }
        public string WorkerLastName { get; set; }
        public double EmployeeId { get; set; }
        public double DesignatedZipCode { get; set; }
    }
}