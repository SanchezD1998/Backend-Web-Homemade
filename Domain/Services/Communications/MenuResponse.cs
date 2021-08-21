using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homemade.Domain.Models;

namespace Homemade.Domain.Services.Communications
{
    public class MenuResponse : BaseResponse<Menu>
    {
        public MenuResponse(Menu resource) : base(resource)
        {
        }

        public MenuResponse(string message) : base(message)
        {
        }
    }
}
