using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application
{
    public interface IFeriadosNacionaisService
    {
        public DateTime ObterDataValida(DateTime dataConsiderada);
    }
}
