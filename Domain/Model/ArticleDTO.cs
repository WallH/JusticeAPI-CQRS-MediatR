using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ChapterId { get; set; }
        public int Ticket { get; set; }
        public int LicensePoint { get; set; }
        public int Minutes { get; set; }
        public Boolean Cumulative { get; set; }
    }

    public class ArticlesOutput
    {
        public List<ArticleDTO> Articles { get; set; }
    }
}
