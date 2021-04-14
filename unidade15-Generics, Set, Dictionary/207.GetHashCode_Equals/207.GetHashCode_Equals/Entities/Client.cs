using System;
using System.Collections.Generic;
using System.Text;

namespace _207.GetHashCode_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Client)) // se nao é um objeto do tipo client
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
