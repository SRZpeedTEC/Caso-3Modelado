using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso_3Modelado.StrategyPattern;

namespace Caso_3Modelado.FactoryPattern
{
    internal class ArteMarcialFactory : AbstractFactory
    {
        private List<Func<IArteMarcial>> artesMarciales;
        
        
        public ArteMarcialFactory()
        {
            artesMarciales = new List<Func<IArteMarcial>>
            {
            () => new Karate() ,
            () => new Taekwondo() ,
            () => new Jiu_Jitsu() ,
            () => new Boxeo() ,
            () => new MuayThai() ,
            () => new Capoeira() ,
            () => new KravMaga() ,
            () => new Sambo() ,
            () => new Kung_Fu() ,
            () => new Judo()
            };
        }
     

        public override List<IArteMarcial> CreateArteMarcial()
        {
            
            List<IArteMarcial> artesMarcialesSeleccionadas = new List<IArteMarcial>();
            
            while (artesMarcialesSeleccionadas.Count < 3) 

            {
                IArteMarcial arteMarcialSeleccionada = artesMarciales[random.Next(artesMarciales.Count)]();

                if (!artesMarcialesSeleccionadas.Any(a => a.Nombre == arteMarcialSeleccionada.Nombre))
                {
                    artesMarcialesSeleccionadas.Add(arteMarcialSeleccionada);
                }

            }

            return artesMarcialesSeleccionadas;
                                          
        }
    }
    
}
