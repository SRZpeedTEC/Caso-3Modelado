using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    public class Karate : IArteMarcial
    {       
        public string Nombre => "Karate";
        public Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; } = new Dictionary<string, (string, int)>
        {
        { "Tecnica1", ("Mae Geri (vida + 10)", 10) },
        { "Tecnica2", ("Gyaku Zuki", 20) },
        { "Tecnica3", ("Mawashi Geri (daño + 5)", 25) }
        };
        public Karate() 
        {            
        }

        public void Tecnica1(Player Atacante, Player Contrincante)
        {           
            int dano = DescripcionesGolpes["Tecnica1"].poder;   
            int bonificacionVida = 10;
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
            int bonificacionDano = 5;
            Contrincante.setVida(Contrincante.getVida() - (dano + bonificacionDano));
        }
    }
}
