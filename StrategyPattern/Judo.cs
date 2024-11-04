﻿using Caso_3Modelado.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.StrategyPattern
{
    public class Judo : IArteMarcial
    {
        public string Nombre => "Judo";
        public Dictionary<string, (string descripcion, int poder)> DescripcionesGolpes { get; } = new Dictionary<string, (string, int)>
        {
        { "Tecnica1", ("Atemi Waza (vida + 5)", 5) },
        { "Tecnica2", ("Tsuki", 12) },
        { "Tecnica3", ("Hiji Ate (daño + 15)", 30) }
        };

        public Judo() { }        

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
            int bonificacionDano = 15;
            Contrincante.setVida(Contrincante.getVida() - (dano + bonificacionDano));
        }
    }
    
}