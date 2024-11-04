using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    public class Jiu_Jitsu : IArteMarcial
    {       
        public string Nombre => "Jiu Jitsu";

        public Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; } = new Dictionary<string, (string, int)>
        {
        { "Tecnica1", ("Hammerfist (vida + 20)", 5) },
        { "Tecnica2", ("Slap", 10) },
        { "Tecnica3", ("Palm Strike (daño + 20)", 15) }
        };

        public Jiu_Jitsu() { }
        

        public void Tecnica1(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica1"].poder;
            int bonificacionVida = 20;
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
            int bonificacionDano = 20;
            Contrincante.setVida(Contrincante.getVida() - (dano + bonificacionDano));
        }


    }
    
    
}
