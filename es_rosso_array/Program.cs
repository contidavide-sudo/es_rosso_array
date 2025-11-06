namespace es_rosso_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] v1 = { 2, 5, 7, 8, 3 };
            int [] v2 = { 2, 6, 1, 8, 5 };

            int contV3 = 0;
            
            for(int i=0; i<v1.Length; i++)
            {
                for(int j=0; j<v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        contV3 = contV3 + 1;
                    }
                }
                
            }

            int[] v3 = new int[contV3];

            int indV3 = 0;

           
            for (int i = 0; i < v1.Length; i++) 
            {
                for(int j=0; j<v2.Length; j++)
                {
                   if (v1[i] == v2[j])
                   {
                      v3[indV3] = v1[i];
                      indV3 = indV3 + 1;
                   }
                }

            }


            for (int i = 0; i < v3.Length; i++) {

                Console.Write($"[{v3[i]}]");

            }
        }
    }
}
