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
        Task<PostChapterResponseModel> SaveNewChapter(Chapter chapter);
    }
    public class ChapterService : IChapterService
    {
        private readonly JusticeDbContext justiceDbContext;
        public ChapterService(JusticeDbContext context)
        {
            justiceDbContext = context;
        }

        public async Task DeleteChapter(int id)
        {
            var Chapter = await justiceDbContext.Chapters.FindAsync(id);
            justiceDbContext.Chapters.Remove(Chapter);

            await justiceDbContext.SaveChangesAsync();
        }

        public async Task UpdateChapter(int id, Chapter chapter)
        {
            if(id != chapter.Id)
            {
                return;
            }
            justiceDbContext.Entry(chapter).State = EntityState.Modified;

            await justiceDbContext.SaveChangesAsync();
        }

        public async Task<PostChapterResponseModel> SaveNewChapter(Chapter chapter)
        {

            var result = await justiceDbContext.Chapters.AddAsync(chapter);
            var response = await justiceDbContext.SaveChangesAsync();

            return new PostChapterResponseModel() { Id = response };
        }

        public async Task<GetChapterResponseModel> GetChaptersByActive(int active)
        {
            var result = await justiceDbContext.Chapters.ToListAsync();
            var result2 = justiceDbContext.Articles.ToList().FirstOrDefault();
            
            return new GetChapterResponseModel()
            {
                Chapters = (List<Chapter>)result
            };
        }

        //public async Task<>
    }
}
