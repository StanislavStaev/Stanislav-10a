using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерни_масиви_и_ДРУГИ_алгоритмични_структури
{
    internal class Program
    {
        static void Main(string[] args)
        {
                ArrayList klas10A = Input();
                int studentbroi = klas10A.Count;
                int testsbr = 3;
                List<string> names = new List<string>();
                int[,] grades = new int[studentbroi, testsbr];
                for (int i = 0; i < klas10A.Count; i++)
                {
                    ArrayList student = (ArrayList)klas10A[i];
                    string name = "";
                    int[] studentGrades = null;
                    foreach (object item in student)
                    {
                        if (item is string)
                            name = (string)item;
                        if (item is int[])
                            studentGrades = (int[])item;
                    }
                    if (name != "" && studentGrades != null)
                    {
                        names.Add(name);

                        for (int j = 0; j < testsbr; j++)
                            grades[i, j] = studentGrades[j];
                    }
                }
                Console.WriteLine("1zad sreden uspeh na u4enicite");
                for (int i = 0; i < studentbroi; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < testsbr; j++)
                        sum += grades[i, j];
                    double avg = sum / testsbr;
                    Console.WriteLine($"{names[i]} sredno {avg:F2}");
                }
                Console.WriteLine("2zad sreden uspeh po kontrolno");
                for (int j = 0; j < testsbr; j++)
                {
                    double sum = 0;
                    for (int i = 0; i < studentbroi; i++)
                        sum += grades[i, j];

                    Console.WriteLine($"Test {j + 1} sredno {(sum / studentbroi):F2}");
                }
                Console.WriteLine("3zad imaena zapo4va6ti s bukva");
                Console.Write("Vuvedi ime  ");
                char letter = char.ToUpper(Console.ReadLine()[0]);

                for (int i = 0; i < names.Count; i++)
                {
                    if (char.ToUpper(names[i][0]) == letter)
                        Console.WriteLine(names[i]);
                }
            }
            static ArrayList Input()
            {
                ArrayList klas10A = new ArrayList();
                ArrayList s1 = new ArrayList();
                s1.Add("Ivan");
                s1.Add(new int[] { 5, 6, 6 });
                ArrayList s2 = new ArrayList();
                s2.Add("Maria");
                s2.Add(new int[] { 6, 6, 5 });
                ArrayList s3 = new ArrayList();
                s3.Add("Georgi");
                s3.Add(new int[] { 4, 5, 5 });
                klas10A.Add(s1);
                klas10A.Add(s2);
                klas10A.Add(s3);
                return klas10A;
            }
        }
    }
