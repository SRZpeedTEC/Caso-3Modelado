using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    public class Boxeo : IArteMarcial
    {
        public string Nombre => "Boxeo";
        public Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; } = new Dictionary<string, (string, int)>
        {
        { "Tecnica1", ("Jab (daño + 5)", 12) },
        { "Tecnica2", ("Cross (vida + 5)", 10) },
        { "Tecnica3", ("Uppercut", 35) }
        };
        public Boxeo() { }       

        public void Tecnica1(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica1"].poder;
            int bonificacionDano = 10;
            Contrincante.setVida(Contrincante.getVida() - (dano + bonificacionDano));
        }

        public void Tecnica2(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica2"].poder;
            int bonificacionVida = 5;
            Atacante.setVida(Atacante.getVida() + bonificacionVida);
            Contrincante.setVida(Contrincante.getVida() - dano);
        }

        public void Tecnica3(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica3"].poder;            
            Contrincante.setVida(Contrincante.getVida() - dano);
        }
    }
    
    
}
