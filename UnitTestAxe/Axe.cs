using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAxe
{
    public class Axe
    {
        public int AxeAttack;
        public int AxeDurability;
        public int DurabilityPoints;
      
     
        public Axe(int axeAttack, int axeDurability)
        {
            this.AxeAttack = axeAttack;
            this.AxeDurability = axeDurability;
        }
        public void Attack(Dummy D)
        {
            if(D.DummyHealth !=0)
            { DurabilityPoints = AxeDurability - 1;
                D.DummyHealth -= 1;
            }
            else
            {
                DurabilityPoints = AxeDurability;
                //throw new Exception("Dead Dummy");
            }
            
            if(D.DummyHealth == 0)
            {
                DurabilityPoints += D.DummyXP;
                D.DummyXP = 0;
            }
            
        }
    }
}
