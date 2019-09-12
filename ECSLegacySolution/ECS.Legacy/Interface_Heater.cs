using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    interface Interface_Heater
    {
    	void TurnOn();
    	void TurnOff();
    	bool RunSelfTest();
    }
}
