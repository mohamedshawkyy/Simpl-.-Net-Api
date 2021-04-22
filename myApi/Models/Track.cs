using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myApi.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Branch { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}