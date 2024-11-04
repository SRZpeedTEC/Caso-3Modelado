using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    public class KravMaga : IArteMarcial
    {
        public string Nombre => "Krav Maga";
        public Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; } = new Dictionary<string, (string, int)>
        {
        { "Tecnica1", ("Palm Heel Strike (vida + 15)", 15) },
        { "Tecnica2", ("Groin Kick", 20) },
        { "Tecnica3", ("Hammerfist (daño + 15)", 15) }
        };
        public KravMaga() { }
        

        public void Tecnica1(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica1"].poder;
            int bonificacionVida = 15;
            Atacante.setVida(Atacante.getVida() + bonificacionVida);
            Contrincante.setVida(Contrincante.getVida() - dano);
        }

        public void Tecnica2(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica2"].poder;
            Contrincante.setVida(Contrincante.getVida() - dano);
        }

        public void Tecnica3(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica3"].poder;
            int bonificacionDano = 15;
            Contrincante.setVida(Contrincante.getVida() - (dano + bonificacionDano));
        }
    }
    
    
}
