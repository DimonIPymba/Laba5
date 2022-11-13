using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        public List<Pupil> Pupils;

        public ClassRoom(List<Pupil> pupils)
        {
            Pupils = pupils;
        }

        public void Print()
        {
            foreach (Pupil pupil in Pupils)
            {
                pupil.Study();
                pupil.Write();
                pupil.Relax();
                pupil.Read();
                Console.WriteLine();
            }
        }
    }
}
