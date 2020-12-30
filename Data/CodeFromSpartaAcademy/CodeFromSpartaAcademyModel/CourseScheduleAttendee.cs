using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFromSpartaAcademyModel
{
    public partial class CourseScheduleAttendee
    {
        public int CourseScheduleId { get; set; }
        public int AttendeeId { get; set; }
        public bool Active { get; set; }
    }
}
