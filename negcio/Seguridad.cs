using dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dom;
using negcio;

namespace negcio
{
    public static class Seguridad
    {
        public static bool sessionActiva(object user)
        {
            trainee trainee = user != null ? (trainee)user: null;
            if (trainee != null && trainee.id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool esAdmin(object user) {
        
            trainee trainee = user != null ? (trainee)user : null;
            return trainee != null ? trainee.admin : false;
        
        }
    }
}
