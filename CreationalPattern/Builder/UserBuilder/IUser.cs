using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPattern.Builder.UserBuilder
{
    public interface IUser
    {
        string Name { get; }
        int Age { get; }
        string Address { get; }
    }
}
