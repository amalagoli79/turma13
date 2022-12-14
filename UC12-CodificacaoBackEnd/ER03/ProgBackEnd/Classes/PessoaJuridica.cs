using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgBackEnd.Interfaces;

// - Pessoa jurídica
// Para Rendimentos até 3000, 3%
// Para rendimentos entre 3000 e 6000, 5%
// Para rendimentos entre 6000 e 10000, 7%
// Para rendimentos acima de 10000, 9%

namespace ProgBackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set; }

        public override float CalcularImposto(float rendimento)
                {
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f; // 3%
            }
            else if ( rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.05f; // 5%
            }

            else if ( rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.07f; // 7%
            }
            else
            {
                return rendimento * 0.09f; // 9%
            }
            
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}