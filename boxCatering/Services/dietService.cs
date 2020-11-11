using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boxCatering.Classes;
using boxCatering.Forms;

namespace boxCatering.Services
{
    class dietService
    {
        IDiet diet = new lowCaloriesDiet();
    }
}
