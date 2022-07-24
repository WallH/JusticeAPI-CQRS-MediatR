using Application.Models.Request;
using Application.Models.Response;
using Application.Services;
using Domain;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.Queries
{
    public class GetChapterQueryHandler : IRequestHandler<GetChapterRequestModel, GetChapterResponseModel>
    {
        private readonly IChapterService chapterService;

        public GetChapterQueryHandler(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }
        
        public async Task<GetChapterResponseModel> Handle(GetChapterRequestModel request, CancellationToken cancellationToken)
        {
            return await chapterService.GetChaptersByActive(0);
            //return new GetChapterResponseModel { Chapters =  };//chapterService.GetChaptersByActive(request.Active ?? 1);
        }
        /*   public async Task<GetChapterResponseModel> Handle(GetChapterRequestModel request, CancellationToken cancellationToken)
  {
      return await chapterService.GetChaptersByActive(request.Active ?? 1);
  }*/
    }
}
