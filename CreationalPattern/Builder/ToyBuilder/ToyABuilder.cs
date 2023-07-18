using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPattern.Builder.ToyBuilder
{
    public class ToyABuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public Toy GetToy()
        {
            return toy;
        }

        public void SetBody()
        {
            toy.Body = "Plastic";
        }

        public void SetHead()
        {
            toy.Body = "1";
        }

        public void SetLegs()
        {
            toy.Body = "2";
        }

        public void SetLimbs()
        {
            toy.Body = "4";
        }

        public void SetModel()
        {
            toy.Body = "Toy A";
        }
    }
}
