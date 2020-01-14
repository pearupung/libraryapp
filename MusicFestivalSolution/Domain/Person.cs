using System.Collections.Generic;

namespace Domain
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; } = default!;
        public string? IdCode { get; set; }

        public string? CompanyCode { get; set; }
        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }

        public string? VatSubjectNumber { get; set; }

        public List<Participant>? Participants { get; set; }

        public List<TrackPayRight>? TrackPayRights { get; set; }
    }
}