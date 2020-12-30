using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFromSpartaAcademyModel
{
    public partial class CourseSchedule
    {
        public int CourseScheduleId { get; set; }
        public int AcademyId { get; set; }
        public int RoomId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
