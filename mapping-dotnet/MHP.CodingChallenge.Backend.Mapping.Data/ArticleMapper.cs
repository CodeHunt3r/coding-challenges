using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO.Blocks;

namespace MHP.CodingChallenge.Backend.Mapping.Data
{
    public class ArticleMapper
    {
        private IMapper _mapper;

        // Dependency Injection von Automapper Objekt
        public ArticleMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ArticleDto Map(Article article)
        {
            if (article == null)
            {
                return null;
            }

            var articleBlocksDto = new List<ArticleBlockDto>();

            // Für jeden ArticleBlock den genauen Typ bestimmen und dann mit Auto Mapper zu Data Transfer Object (DTO) mappen
            foreach(var articleBlock in article.Blocks)
            {
                switch(articleBlock)
                {
                    case GalleryBlock galleryBlock:
                        var block = _mapper.Map<GalleryBlockDto>(galleryBlock);
                        articleBlocksDto.Add(block);
                        break;
                    case ImageBlock imageBlock:
                        var block2 = _mapper.Map<ImageBlockDto>(imageBlock);
                        articleBlocksDto.Add(block2);
                        break;
                    case TextBlock textBlock:
                        articleBlocksDto.Add(_mapper.Map<TextBlockDto>(textBlock));
                        break;
                    case VideoBlock videoBlock:
                        articleBlocksDto.Add(_mapper.Map<VideoBlockDto>(videoBlock));
                        break;
                    default:
                        // Inform user
                        break;
                };

            }

            return new ArticleDto
            {
                Id = article.Id,
                Author = article.Author,
                // Article Blocks nach dem Sort Index sortieren
                Blocks = articleBlocksDto.OrderBy(x => x.SortIndex).ToList(),
                Description = article.Description,
                Title = article.Title,
            };
        }

        public Article Map(ArticleDto articleDto)
        {
            // Nicht Teil dieser Challenge.
            return new Article();
        }
    }
}
