using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy.Entities
{
    internal class PatientPartialClass
    {
        public string AdminControlsVisibility
        {
            get
            {
                if (App.CurrentUser.Roled == 1)
                {
                    return "Visible";
                }
                else
                {
                    return "Collapsed";
                }
            }
        }

    }
}
