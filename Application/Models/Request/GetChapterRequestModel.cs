using Application.Models.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class GetChapterRequestModel :  IRequest<GetChapterResponseModel>
    {
        public GetChapterRequestModel()
        {
        }

        public int ?Active { get; set; }
    }
}
