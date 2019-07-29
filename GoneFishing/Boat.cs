using System;

namespace GoneFishing
{
    class Boat
    {
        public int SmallFish {get; set;}
        public int MediumFish {get; set;}
        public int BigFish {get; set;}

        public Boat()
        {
            this.SmallFish = 0;
            this.MediumFish = 0;
            this.BigFish = 0;
        }

        public void CaughtSmallFish()
        {
            this.SmallFish++;
        }

        public void CaughtSmallFish(int totalCatch)
        {
            this.SmallFish += totalCatch;
        }

        public void CaughtMediumFish()
        {
            this.MediumFish++;
        }

        public void CaughtMediumFish(int totalCatch)
        {
            this.MediumFish += totalCatch;
        }

        public void CaughtBigFish()
        {
            this.BigFish++;
        }

        public void CaughtBigFish(int totalCatch)
        {
            this.BigFish += totalCatch;
        }

        public int GetTotalWeight()
        {
            return this.SmallFish + (this.MediumFish * 5) + (this.BigFish * 10);
        }

        public bool IsCloseToSinking()
        {
            int totalWeight = GetTotalWeight();

            return totalWeight > 200 && totalWeight <= 210;
        }

        public bool IsSunk()
        {
            int totalWeight = GetTotalWeight();

            return totalWeight > 210;
        }
    }
}