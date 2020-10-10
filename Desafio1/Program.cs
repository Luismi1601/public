using System;

namespace Letras
{
    class Program
    {
        static void Main(string[] args)
        {
            Letra_E();
            Letra_P();
            Letra_P1();
        }

        static void Letra_E()
        {
            char[,] E = new char[7, 7] { {'*','*','*','*','*','*','*'}
                                       , {'*',' ',' ',' ',' ',' ',' '}
                                       , {'*',' ',' ',' ',' ',' ',' '}
                                       , {'*','*','*','*','*',' ',' '}
                                       , {'*',' ',' ',' ',' ',' ',' '}
                                       , {'*',' ',' ',' ',' ',' ',' '}
                                       , {'*','*','*','*','*','*','*'}};
            int length = 7;

            for (int horizontal = 0; horizontal < length; horizontal++) 
            {
                for (int vertical = 0; vertical < length; vertical++)
                {
                    Console.Write(E[horizontal,vertical]);
                }   
                Console.WriteLine();
            }
        }

        static void Letra_P()
        {
            char[,] E = new char[7, 7] { {'*','*','*','*','*','*',' '}
                                       , {'*',' ',' ',' ',' ',' ','*'}
                                       , {'*',' ',' ',' ',' ',' ','*'}
                                       , {'*','*','*','*','*','*',' '}
                                       , {'*',' ',' ',' ',' ',' ',' '}
                                       , {'*',' ',' ',' ',' ',' ',' '}
                                       , {'*',' ',' ',' ',' ',' ',' '}};
            int length = 7;

            for (int horizontal = 0; horizontal < length; horizontal++) 
            {
                for (int vertical = 0; vertical < length; vertical++)
                {
                    Console.Write(E[horizontal,vertical]);
                }   
                Console.WriteLine();
            }
        }
    
        static void Letra_P1()
        {
            char[,] P = new char[7, 7]; 
            int length = 7;
            char asterisco='*';
            char vacio=' ';
            int horizontal=default;
            int vertical=default;

            for (horizontal = 0; horizontal < length; horizontal++) 
            {
                for (vertical = 0; vertical < length; vertical++)
                {
                    P[horizontal,vertical]=(
                        (vertical==0 || 
                        (horizontal==0 && vertical<6) ||
                        (vertical==6 && (horizontal==1 || horizontal==2)) ||
                        (horizontal==3 && vertical<6)
                        ? asterisco : vacio));

                    Console.Write(P[horizontal,vertical]);
                }   
                Console.WriteLine();
            }
        }
    }
}