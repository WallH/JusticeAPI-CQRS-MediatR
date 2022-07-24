using Application.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public interface IChapterService
    {
        Task<GetChapterResponseModel> GetChaptersByActive(int active);
    }
    public class ChapterService : IChapterService
    {
        private readonly JusticeDbContext justiceDbContext;
        public ChapterService(JusticeDbContext context)
        {
            justiceDbContext = context;
        }
        public async Task<GetChapterResponseModel> GetChaptersByActive(int active)
        {
            /*using(JusticeDbContext justiceDbContext = new JusticeDbContext())
            {*/
                var result = await justiceDbContext.Chapters.ToListAsync();
                var result2 = justiceDbContext.Articles.ToList().FirstOrDefault();
                //Console.WriteLine(result2.Chapter.Description);
                return new GetChapterResponseModel()
                {
                    Chapters = (List<Chapter>)result
                };

           // }
        }

        //public async Task<>
    }
}
