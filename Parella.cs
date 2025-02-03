using System;
using System.Collections;

namespace T4Activitats
{
    public class Parella<T1, T2>
    {
        public T1 Primer { get; set; }
        public T2 Segon { get; set; }
        public Parella(T1 primer, T2 segon)
        {
            Primer = primer;
            Segon = segon;
        }
        public override string ToString()
        {
            return $"{Primer}, {Segon}";
        }
    }
}