using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using MediatR;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    internal class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;

        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            _carFeatureRepository.CreateCarFeatureByCar(new CarFeature
            {
                CarID = request.CarID,
                FeatureID = request.FeatureID,
                Available = false
            });
        }
    }
}
