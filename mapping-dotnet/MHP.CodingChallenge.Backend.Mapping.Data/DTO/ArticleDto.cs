using System;
using System.Collections.Generic;

namespace MHP.CodingChallenge.Backend.Mapping.Data.DTO
{
    public class ArticleDto
    {
        public long Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Author { get; set; }
        public List<ArticleBlockDto> Blocks { get; set; }
    }
}