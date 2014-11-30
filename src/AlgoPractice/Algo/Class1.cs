using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo
{
    public interface IAlgo<TInput,TOutput>
    {
        TOutput Compute(TInput input);
    }
}
