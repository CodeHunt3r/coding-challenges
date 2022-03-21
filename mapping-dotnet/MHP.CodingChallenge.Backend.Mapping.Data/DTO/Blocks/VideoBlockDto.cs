using System;
using MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks;

namespace MHP.CodingChallenge.Backend.Mapping.Data.DTO.Blocks
{
    public class VideoBlockDto : ArticleBlockDto
    {
        public String Url { get; set; }
        public VideoBlockType Type { get; set; }
    }
}
