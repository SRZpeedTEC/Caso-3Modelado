using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso_3Modelado.StrategyPattern;

namespace Caso_3Modelado.Players
{
    public class Player1 : Player
    {
        public IArteMarcial arteMarcialseleccionada;

        public Player1()
        {
            
        }

        public void SeleccionarArteMarcial(IArteMarcial arteMarcialElegida)
        {
            this.arteMarcialseleccionada = arteMarcialElegida;
        }
       
        public void Atacar(Player Atacante, Player Contrincante)
        {
            
            for (int i = 0; i < 3; i++)
            {
                int numeroAleatorio = random.Next(1, 4);

                switch (numeroAleatorio)
                {
                    case 1:
                        arteMarcialseleccionada.Tecnica1(Atacante, Contrincante);
                        BitacoraAtaques.Add($"{arteMarcialseleccionada.Nombre}: {arteMarcialseleccionada.DescripcionesGolpes["Tecnica1"].descripcion} - {arteMarcialseleccionada.DescripcionesGolpes["Tecnica1"].poder}");
                        break;
                    case 2:
                        arteMarcialseleccionada.Tecnica2(Atacante, Contrincante);
                        BitacoraAtaques.Add($"{arteMarcialseleccionada.Nombre}: {arteMarcialseleccionada.DescripcionesGolpes["Tecnica2"].descripcion} - {arteMarcialseleccionada.DescripcionesGolpes["Tecnica2"].poder}");
                        break;
                    case 3:
                        arteMarcialseleccionada.Tecnica3(Atacante, Contrincante);
                        BitacoraAtaques.Add($"{arteMarcialseleccionada.Nombre}: {arteMarcialseleccionada.DescripcionesGolpes["Tecnica3"].descripcion} - {arteMarcialseleccionada.DescripcionesGolpes["Tecnica3"].poder}");
                        break;
                }
            }
        }


    }
}
