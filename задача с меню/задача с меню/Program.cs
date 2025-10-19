using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_с_меню
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte izbor= 0;
            do
            {
                //Console.WriteLine("vuvedi 4islo ot 1 do 4");
               
                //Console.WriteLine("sumata ot do n");
                //Console.WriteLine("da se vuvedat 4isla po golemi ot 0.Da se iz4islqva sumata na vuvedenite 4isla,nai golqmoto i naj malkoto");
                //Console.WriteLine("da se umnojat vsi4ki vuvedeni 4isla.Krai e vuvejdaneto na 0");
                Console.WriteLine("izberete ot 1 до 4 ");
                izbor=byte.Parse(Console.ReadLine());

            }while( izbor >4||izbor<1 );
            switch (izbor)
            {
                case 1:
                    Console.Write("vuvedi 4islo ");
                    int chislo = int.Parse(Console.ReadLine());
                    bool prosto = true;
                    if (chislo <= 1)
                        prosto = false;
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(chislo); i++)
                        {
                            if (chislo % i == 0)
                            {
                                prosto = false;
                                break;
                            }
                        }
                    }
                    if (prosto)
                        Console.WriteLine("prosto ");
                    else
                        Console.WriteLine("ne prosto ");
                    break; 
                case 2:
                    Console.Write("vuvedi цяло polojitelno 4islo ");
                    int n = int.Parse(Console.ReadLine());
                    int sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Sumata ot 1 do {n} e {sum}");
                    break;

                case 3:
                    int suma = 0;
                    int broi = 0;
                    int a;
                    do
                    {
                        Console.Write("vuvedi 4islo 0 e kraj ");
                        a = int.Parse(Console.ReadLine());
                        if (a > 0)
                        {
                            suma += a;
                            broi++;
                        }
                    } while (a > 0);

                    if (broi > 0)
                        Console.WriteLine($"Sumata e {suma}");
                    break;

                case 4:
                    double proizvedenie = 1;
                    double num;
                    do
                    {
                        Console.Write("vuedi 4islo 0 e karj ");
                        num = double.Parse(Console.ReadLine());
                        if (num != 0)
                            proizvedenie *= num;
                    } while (num != 0);
                    Console.WriteLine($"proizvedenieto e {proizvedenie}");
                    break;
            }
        }
    }
}
