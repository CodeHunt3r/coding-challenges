using System.Collections.Generic;

namespace MHP.CodingChallenge.Backend.Mapping.Data.DTO.Blocks
{
    public class GalleryBlockDto : ArticleBlockDto
    {
        public List<ImageDto> Images { get; set; }
    }
}
