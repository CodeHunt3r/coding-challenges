using System;
namespace MHP.CodingChallenge.Backend.Mapping.Data.DB
{
    public class Image : DbEntity
    {
        public String Url { get; set; }
        public ImageSize ImageSize { get; set; }
    }
}
