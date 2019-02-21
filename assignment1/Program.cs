using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    class CountrySide
    {
        static void Main()
        {
            new CountrySide().Run();
        }
        
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;
        public void Run()
        {
            this.TravelVillages(Alst);
            Alst = new Village("Alset", false);
            Schvenig = new Village("Schving", false);
            Wessig = new Village("Wessing", true);

            Alst.distanceToEastVillage = 14;
            Alst.distanceToWestVillage = 19;
            Alst.west = Schvenig;
            Alst.east = Wessig;

            //Schvenig.distanceToNextVillage = 14;
            Schvenig.west = null;
            Schvenig.east = null;

            //Alst.distanceToNextVillage = 19;
            Wessig.west = null;
            Wessig.east = null;
            

        }

        public void TravelVillages(Village CurrentVillage)
        {

            if (CurrentVillage.isAstrildgeHere) {
                Console.WriteLine("Astrildge is found in{}", CurrentVillage.VillageName);
                Console.WriteLine("***** FEELING HAPPY!****");
                return;
                    }
            TravelVillages(CurrentVillage.west);
            TravelVillages(CurrentVillage.east);
        }
    }
    class Village
    {

        public Village(string _villageName, bool _isAHere)
        {
            isAstrildgeHere = _isAHere;
            VillageName = _villageName;
        }

        public Village west;
        public Village east;
        public string VillageName;
        public int distanceToEastVillage;
        public int distanceToWestVillage;
        public bool isAstrildgeHere;
       

    }
    
}
