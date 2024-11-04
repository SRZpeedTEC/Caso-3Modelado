using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    
    public interface IArteMarcial
    {
        string Nombre { get; }
        Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; }

        public void Tecnica1(Player Atacante, Player Contrincante);
        public void Tecnica2(Player Atacante, Player Contrincante);
        public void Tecnica3(Player Atacante, Player Contrincante);

    }
}
