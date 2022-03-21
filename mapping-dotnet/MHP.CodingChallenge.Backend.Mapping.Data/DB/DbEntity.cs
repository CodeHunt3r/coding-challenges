using System;
namespace MHP.CodingChallenge.Backend.Mapping.Data.DB
{
    public class DbEntity
    {
        public long Id { get; set; }
        public DateTime LastModified { get; set; }
        public String LastModifiedBy { get; set; }
    }
}
