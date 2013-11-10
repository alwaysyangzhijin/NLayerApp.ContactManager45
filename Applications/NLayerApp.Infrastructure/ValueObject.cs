using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Infrastructure
{
    public class ValueObject<T> where T : ValueObject<T>
    {
    }
}
