using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
<<<<<<< HEAD
        
=======
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        private int age = 0;
        private int height = 0;
        private bool treeAlive = false;
        private int numOranges = 0;
<<<<<<< HEAD
        private int orangesEaten = 0;


        public int Age
        {
            set 
            {  
                if (value >= 0)
                { 
                    age = value; 
                }
                else
                {
                    age = 0;
                }
            }
            get { return age; } 
        }
        
        public int Height
        {
            set { height = value; }
            get { return height; }
        }

        public bool TreeAlive 
        {
            set {  treeAlive = value; }
            get { return treeAlive; }
        }

        public int NumOranges
        {
            get { return numOranges; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        /*
=======
        private int orangesEaten = 0; 

>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        public int GetNumOranges()
        {
            return numOranges;
        }
        public int GetOrangesEaten()
        {
            return orangesEaten;
        }
<<<<<<< HEAD
        */
=======
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d

        public void OneYearPasses() 
        {
            age++;
<<<<<<< HEAD
            numOranges = 0;
            orangesEaten = 0;

            if (age < 80)
            {
                TreeAlive = true;
                height = height + 2;
                numOranges = (age - 1 ) * 5;
=======

            if (age < 80)
            {
                height = height + 2;
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
             /* Træets alder øges med 1 (age-feltet)
                Træet højde øges med 2, hvis træets alder er under 80, ellers ikke (height-feltet)
                Træet er i live, hvis træets alder er under 80, ellers dødt (treeAlive)
                Træet giver ikke frugt første år, men derefter øges dets produktion med 5 appelsiner for hvert år (dvs. 5 appelsiner 2. år, 10 appelsiner det 3. år, 15 appelsiner det 4. år osv.). Frugt fra forrige år føres ikke med over til et nyt år (numOranges-feltet) 
                 */
            }
            else 
            {
<<<<<<< HEAD
                TreeAlive = false;
             
            }
            
=======
                treeAlive = false;
            }
            numOranges = (age - 1) * 5;
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
            // Første år (1-1)*5 = 0
            // Andet år (2-1)*5 = 5
            // Tredje år (3-1)*5 = 10
        }
        
        public void EatOrange(int count) 
        {
            //EatOrange(count); Reccursion. Dette laver et uendeligt loop hvilket man ikke må
            
            if(numOranges >= count)
            {
                numOranges -= count;
                orangesEaten += count;
            }

        }

      
    }
}
