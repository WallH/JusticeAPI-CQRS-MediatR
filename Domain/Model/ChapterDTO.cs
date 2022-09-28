using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ChapterDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<ArticleDTO> Articles { get; set; }
    }

    public class ChaptersOutput
    {
        public List<ChapterDTO> Chapters { get; set; }
    }
}
