using Application.Models.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class PostChapterRequestModel : IRequest<PostChapterResponseModel>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
