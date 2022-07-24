using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ChapterId { get; set; }
        [ForeignKey("ChapterId")]
        public virtual Chapter Chapter { get; set; }

        public int Ticket { get; set; }
        public int LicensePoint { get; set; }
        public int Minutes { get; set; }

        public int ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article? ArticleFather { get; set; }
        public virtual ICollection<Article> Articles { get; set; }

        public Boolean Cumulative {get; set; }

    }
}
