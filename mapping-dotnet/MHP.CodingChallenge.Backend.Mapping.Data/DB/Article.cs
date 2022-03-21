using System;
using System.Collections.Generic;
using MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks;

namespace MHP.CodingChallenge.Backend.Mapping.Data.DB
{
    public class Article : DbEntity
    {
        public String Title { get; set; }

        public String Description { get; set; }

        public String Author { get; set; }

        public HashSet<ArticleBlock> Blocks { get; set; }
    }
}
