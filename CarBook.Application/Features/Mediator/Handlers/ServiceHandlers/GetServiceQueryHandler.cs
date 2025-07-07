using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetServiceQuery,List<GetServiceQueryResult>>
    {
  
        private readonly IRepository<Service> _repository;

        public GetSocialMediaQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
               ServiceID = x.ServiceID,
                Description = x.Description,
                IconUrl = x.IconUrl,  
                Title = x.Title
            }).ToList();
        }
    }
}
