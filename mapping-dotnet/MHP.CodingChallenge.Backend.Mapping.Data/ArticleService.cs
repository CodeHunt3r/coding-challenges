using System;
using System.Collections.Generic;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO;

namespace MHP.CodingChallenge.Backend.Mapping.Data
{
    public class ArticleService
    {
        private ArticleRepository _articleRepository;
        private ArticleMapper _articleMapper;

        public ArticleService(ArticleRepository articleRepository, ArticleMapper articleMapper)
        {
            _articleRepository = articleRepository;
            _articleMapper = articleMapper;
        }

        public List<ArticleDto> GetAll()
        {
            List<Article> articles = _articleRepository.GetAll();
            // TODO
            return new List<ArticleDto>();
        }

        public object GetById(long id)
        {
            Article article = _articleRepository.FindById(id);
            return _articleMapper.Map(article);
        }

        public object Create(ArticleDto articleDto)
        {
            Article create = _articleMapper.Map(articleDto);
            _articleRepository.Create(create);
            return _articleMapper.Map(create);
        }
    }
}
