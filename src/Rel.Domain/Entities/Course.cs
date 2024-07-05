using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rel.Domain.Entities;

public class Course : GenericAuditEntity<Guid>
{
    public string CourseName { get; set; }
}
