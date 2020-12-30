using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFromSpartaAcademyModel
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public int AcademyId { get; set; }
        public string RoomName { get; set; }
        public string Description { get; set; }
        public short? Capacity { get; set; }
    }
}
