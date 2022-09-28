using Application.Models.Response;
using Application.Models.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services;
using Domain.Entities;

namespace Application.Handlers.Commands
{
    public class ChapterCommandHandler : IRequestHandler<PostChapterRequestModel, PostChapterResponseModel>
    {
        private readonly IChapterService chapterService;

        public ChapterCommandHandler(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }

        public async Task<PostChapterResponseModel> Handle(PostChapterRequestModel request, CancellationToken cancellationToken)
        {
            return await chapterService.SaveNewChapter(new Chapter() { Title = request.Title, Description = request.Description });
        }
    }
}