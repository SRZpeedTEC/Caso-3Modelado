using Caso_3Modelado.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3Modelado.Players
{
    public class Player2 : Player
    {
        public Player2()
        {

        }

        public void Atacar(Player Atacante, Player Contrincante)
        {
            
            for (int i = 0; i < 3; i++)
            {               
                IArteMarcial arteMarcialUtilizar = artesMarciales[random.Next(artesMarciales.Count)];
                int numeroAleatorio = random.Next(1, 4);

                switch(numeroAleatorio) 
                {
                    case 1:
                        arteMarcialUtilizar.Tecnica1(Atacante, Contrincante);
                        BitacoraAtaques.Add($"{arteMarcialUtilizar.Nombre}: {arteMarcialUtilizar.DescripcionesGolpes["Tecnica1"].descripcion} - {arteMarcialUtilizar.DescripcionesGolpes["Tecnica1"].poder}");
                        break;
                    case 2:
                        arteMarcialUtilizar.Tecnica2(Atacante, Contrincante);
                        BitacoraAtaques.Add($"{arteMarcialUtilizar.Nombre}: {arteMarcialUtilizar.DescripcionesGolpes["Tecnica2"].descripcion} - {arteMarcialUtilizar.DescripcionesGolpes["Tecnica2"].poder}");
                        break;
                    case 3:
                        arteMarcialUtilizar.Tecnica3(Atacante, Contrincante);
                        BitacoraAtaques.Add($"{arteMarcialUtilizar.Nombre}: {arteMarcialUtilizar.DescripcionesGolpes["Tecnica3"].descripcion} - {arteMarcialUtilizar.DescripcionesGolpes["Tecnica3"].poder}");
                        break;
                }

            }
        }
    }
}
