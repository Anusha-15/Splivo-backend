using System;
using System.Collections.Generic;
using System.Text;

namespace Splivo.Infrastructure.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
