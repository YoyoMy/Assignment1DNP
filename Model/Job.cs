using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Job
    {
        public string JobTitle { get; set; }
        [Range(0, int.MaxValue)]
        public int Salary { get; set; }
    }
}