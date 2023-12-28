namespace spacebattle.Lib
{
    public class Vector
    {
        public int[] vector;
        public int size;
        public Vector(params int[] array)
        {
            size = array.Length;
            vector = new int[size];
            for(int i = 0;i < size;i++)
            {
                vector[i] = array[i];
            }
        }
        public override bool Equals(object? ob)
        {
            var item = ob as Vector;
            if (item is Vector)
            {
                return ob is Vector && item == this;
            }
            return false;
        }
        public override int GetHashCode(){
            return HashCode.Combine(vector);
        }
        public override string ToString()
        {  
            string stroka = "Vector(";
            for (int i = 0; i < size - 1; i++)
            {
                stroka += vector[i] + ", ";
            } 
            stroka += vector[size - 1] + ")";
            return stroka;
        }
        public int this[int index]
        {
            get {
                return vector[index];
            }
            set {
                vector[index] = value;
            }
        }
        public static Vector operator + (Vector x, Vector y)
        {
            if (x.size != y.size){ 
                throw new System.ArgumentException();
            }
            else {
                int[] newvector = new int[x.size]; 
                for (int i = 0; i < x.size; i++)
                { 
                    newvector[i] = x[i] + y[i];
                }
                return new Vector(newvector);
            }
        }
        public static Vector operator - (Vector x, Vector y)
        {
            if (x.size != y.size)
            { 
                throw new System.ArgumentException();
            }
            else 
            {
                int[] newvector = new int[x.size];
                
                for (int i = 0; i < x.size; i++)
                { 
                    newvector[i] = x[i] - y[i];
                }
                return new Vector(newvector);
            }
        }
        public static Vector operator * (int n, Vector x)
        {
            int[] newvector = new int[x.size];
            
            for (int i = 0; i < x.size; i++)
            { 
                newvector[i] = n * x[i];
            }
            return new Vector(newvector);
        }
        public static bool operator == (Vector x, Vector y)
        {
            if (x.size != y.size)
            {
                return false;
            }
            else {
                for (int i = 0; i < x.size; i++)
                {
                    if (x[i] != y[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator != (Vector x, Vector y)
        {
            if (x == y)
            {
                return false;    
            }
            return true;
        }
        public static bool operator < (Vector x, Vector y)
        {

            if (x == y)
            {
                return false;
            }
            if (x.size > y.size)
            {
                return false;
            }
            for (int i = 0; i < x.size; i++)
            {
                if (x[i] > y[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator > (Vector x, Vector y)
        { 
            return y < x;
        }
    }
}