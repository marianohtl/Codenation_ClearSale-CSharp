using System;

namespace Codenation.Challenge
{
    public class Country
    {        
        public State[] Top10StatesByArea()
        {
            var countrys = new State[10];
            countrys[0] = new State("Amazonas", "AM");
            countrys[1] = new State("Pará", "PA");
            countrys[2] = new State("Mato Grosso", "MT");
            countrys[3] = new State("Minas Gerais", "MG");
            countrys[4] = new State("Bahia", "BA");
            countrys[5] = new State("Mato Grosso do Sul", "MS");
            countrys[6] = new State("Goiás", "GO");
            countrys[7] = new State("Maranhão", "MA");
            countrys[8] = new State("Rio Grande do Sul", "RS");
            countrys[9] = new State("Tocantins", "TO");

            return countrys;            
        }
    }
}
