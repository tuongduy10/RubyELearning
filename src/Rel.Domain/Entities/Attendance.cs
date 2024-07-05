using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rel.Domain.Entities;

public class Attendance : GenericAuditEntity<Guid>
{
    public Guid AttendeeId { get; set; }
    public ApplicationUser Attendee { get; set; }
}
