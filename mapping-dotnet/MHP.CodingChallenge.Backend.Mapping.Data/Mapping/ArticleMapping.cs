using AutoMapper;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.CodingChallenge.Backend.Mapping.Data.Mapping
{
    internal class ArticleMapping : Profile
    {
        public ArticleMapping()
        {
            // Maps für Auto Mapper erstellen
            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleBlock, ArticleBlockDto>();
            CreateMap<GalleryBlock, GalleryBlockDto>();
            CreateMap<ImageBlock, ImageBlockDto>();
            CreateMap<TextBlock, TextBlockDto>();
            CreateMap<VideoBlock, VideoBlockDto>();
            CreateMap<GalleryBlock, GalleryBlockDto>();
        }
    }
}
