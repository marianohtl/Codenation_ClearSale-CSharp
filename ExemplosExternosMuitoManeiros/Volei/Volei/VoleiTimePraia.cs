using System;
using System.Collections.Generic;
using System.Text;

namespace Volei
{
    public class VoleiTimePraia
    {
        public Jogadora[] GetTime() {

            var time = new Jogadora[2];

            time[0] = new Jogadora("Ana", 0);
            time[1] = new Jogadora("Banana", 1);
            return time;
        }

    }

}
