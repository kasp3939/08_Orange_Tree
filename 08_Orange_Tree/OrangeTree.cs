using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
       
        public int Age;
        public int Height;
        public int NumOranges;
        public bool TreeAlive;
        public int OrangesEaten;

        public OrangeTree(int Age, int Height)
        {
            this.Age = Age;
                    
            this.Height = Height;
      
        }

        //public int OrangesEaten
        //{
        //    get { return this.OrangesEaten; }

        //    internal set { this.OrangesEaten = value; }
        //}

        //public int NumOranges
        //{
        //    get { return this.NumOranges; }   

        //    internal set { this.NumOranges = value; } 
        //}

        //public int Height
        //{
        //    get { return this.Height; }

        //    internal set { this.Height = value; }
        //}
        //public int Age
        //{
        //    get { return Age; }

        //    internal set { Age = value; }
        //}

        internal void OneYearPasses()
        {
            this.Age++;
            this.Height = Height + 2;

            if (this.Age > 1)
            this.NumOranges = NumOranges + 5;
        }

        internal void EatOrange(int v)
        {
            this.OrangesEaten = OrangesEaten + v;
            if (NumOranges < OrangesEaten)
                throw new IndexOutOfRangeException ("You can't eat an orange that isn't there!  There are 0 oranges available to eat");


        }
    }
}