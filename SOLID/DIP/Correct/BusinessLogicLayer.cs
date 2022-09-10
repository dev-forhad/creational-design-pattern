using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Correct
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace SOLID.DIP
    {
        public class BusinessLogicLayer
        {
            private readonly IRepositoryLayer DAL;
            public BusinessLogicLayer(IRepositoryLayer _DAL)
            {
                DAL = _DAL;
            }

            public void Save(Object details)
            {
                DAL.Save(details);
            }
        }

        public interface IRepositoryLayer
        {
            void Save(Object details);
        }

        public class DataAccessLayer : IRepositoryLayer
        {
            public void Save(Object details)
            {
                // Save code here
            }
        }
    }

}
