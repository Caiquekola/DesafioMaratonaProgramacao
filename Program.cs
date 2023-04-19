int numCasos = int.Parse(Console.ReadLine());

string[] casoDecimal = new string[4];
string[] lamiceDosac = new string[4];
int[] valorUnitario = new int[32];
double[] totalBit = new double[32];

int bits=0;


for (int j = 0; j<numCasos; j++)
{
    string[] casos = new string[numCasos];
    casos[j] = Console.ReadLine();
    for (var f = 0; f < 4; f++)
    {
        casoDecimal[f] = casos[j].Substring(bits,8);
        int contadorBits=7;
        bits+=8;
        Console.WriteLine(casoDecimal[f]);
        Console.WriteLine(casoDecimal[f].Reverse().ToArray());
        
          for (int p = 0; p <8; p++)
          {
            valorUnitario[p] = int.Parse(casoDecimal[f].Substring(p,1));
            if (valorUnitario[p]==1){
                totalBit[f] += Math.Pow(2,contadorBits);
            }
            Console.WriteLine(totalBit[f]);
             contadorBits -= 1;
          } 
          
      
        
    }
    Console.WriteLine(totalBit[0]+"."+totalBit[1]+"."+totalBit[2]+"."+totalBit[3]+".");
    
   
}
//012345678903216549870147582963032
//11001011100001001110010110000000





