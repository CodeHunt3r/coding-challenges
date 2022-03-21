using System;
namespace MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks
{
    public class VideoBlock : ArticleBlock
    {
        public String Url { get; set; }
        public VideoBlockType Type { get; set; }
    }
}
