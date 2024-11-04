using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso_3Modelado.StrategyPattern;

namespace Caso_3Modelado.FactoryPattern
{
    abstract class AbstractFactory
    {
        public abstract List<IArteMarcial> CreateArteMarcial();
        public readonly Random random = new Random();
    }
}
