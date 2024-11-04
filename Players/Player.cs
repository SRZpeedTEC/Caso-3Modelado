using Caso_3Modelado.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso_3Modelado.FactoryPattern;
using System.Diagnostics;

namespace Caso_3Modelado.Players
{
    public class Player
    {
        public int vida = 200;
        public List<IArteMarcial> artesMarciales = new List<IArteMarcial>();
        public static readonly Random random = new Random();
        public List<string> BitacoraAtaques = new List<string>();


        public void setArtesMarciales() 
        {
            this.artesMarciales = new ArteMarcialFactory().CreateArteMarcial();           
        }

        public int getVida()
        {
            return vida;
        }
        public void setVida(int vida)
        {
            this.vida = vida;
        }

        public void AgregarBitacora() { }

        public virtual void Atacar(Player Atacante, Player Contrincante)
        {
            //OVERRIDE
        }
    }
}
