using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public String sub { get; set; }
        public decimal mark { get; set; }
    }
}
