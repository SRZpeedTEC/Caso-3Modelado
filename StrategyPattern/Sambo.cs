using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    public class Sambo : IArteMarcial
    {      
        public string Nombre => "Sambo";
        public Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; } = new Dictionary<string, (string, int)>
        {
        { "Tecnica1", ("Udarnaya Tekhnika (vida + 5)", 20) },
        { "Tecnica2", ("Pryzhok Kolenom", 8) },
        { "Tecnica3", ("Loktya Udar (daño + 10)", 30) }
        };

        public Sambo() { }       

        public void Tecnica1(Player Atacante, Player Contrincante)
        {
            int dano = DescripcionesGolpes["Tecnica1"].poder;
            int bonificacionVida = 5;
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
            int bonificacionDano = 10;
            Contrincante.setVida(Contrincante.getVida() - (dano + bonificacionDano));
        }

    }
    
    
}
