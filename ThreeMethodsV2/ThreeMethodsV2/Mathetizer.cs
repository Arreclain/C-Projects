namespace ThreeMethodsV2;

public class Mathetizer
{

    
        public int Doublify(int a)
        {
            return a + a;
        }

        public decimal Doublify(decimal a)
        {
            return (int)(a * 2);
        }

        public int Doublify(string a)
        {
            int data = int.Parse(a);
            data = data * 2 +2;
            return data;
        }
    
}