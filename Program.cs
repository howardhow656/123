﻿using System;

namespace pp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your height:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your dimension:");
            int D = Convert.ToInt32(Console.ReadLine());
            
            


            if(D==2)
            {
                int amount = num*(num+1)/2;
                twodimension(num,amount);
            }
            if(D==3)
            {
                int amount = num * num * num;
                threedimension(num,amount);
            }
        }


        static void twodimension(int num, int amount)
        {
            bool check = true;
            int[,] square = new int[num,num];
                while(check == true)
                {
                    /*build the square*/
                    
                    int number = 1;
                    for(int i = 0 ; i < num * num ; i++)
                    {
                        Random rand1 = new Random();
                        Random rand2 = new Random();
                        int y = rand1.Next();
                        int x = rand1.Next();
                        if(square[y%num,x%num] == 0)
                        {
                            square[y%num,x%num] =number;
                            number++;
                        }
                        else
                        {
                            i--;
                        }
                    }

                    /*check*/
                    int add1 = 0;
                    int add2 = 0;

                    for(int i = 0 ; i < num ; i++)
                    {
                        for(int w = 0 ; w < num ;w++)
                        {
                            add1 += square[i,w];
                            add2 += square[w,i];
                        }
                        if((add1 == amount/num) & (add2 == amount/num))
                        {
                            check = false;
                            add1 = 0;
                            add2 = 0;
                        }
                        else
                        {
                            check = true;
                            break;
                        }
                    }

                    if(check ==true)
                    {
                        for(int i = 0 ; i < num ; i++)
                        {
                            for(int w = 0 ; w < num ; w++)
                            {
                                square[i,w] = 0;
                            }
                        }
                    }
                }
                for(int i = 0 ; i < num ; i++)
                {
                    for(int w = 0 ; w < num ; w++)
                    {
                       Console.Write(square[i,w] + "\t");         
                    }
                    Console.WriteLine("\r\n");
                }
        }


        static void threedimension(int num , int amount)
        {
            int[,,] cube = new int[num,num,num];
            int number = 1;
            bool check = true;

            while(check == true)
            {
                for(int i = 0 ; i < amount ; i++)
                {
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    Random rand3 = new Random();
                    int z = rand1.Next();
                    int x = rand2.Next();
                    int y = rand3.Next();
                    if(cube[z%num,x%num,y%num] == 0)
                    {
                        cube[z%num,x%num,y%num] = number;
                        number++;
                    }
                    else
                    {
                        i--;
                    }
                }

                /*check*/
                int add1 = 0 ;
                int add2 = 0 ;
                int add3 = 0;
                for(int i = 0 ; i < num ; i++)
                {
                    for(int k = 0 ; k < num ; k++)
                    {
                        for(int l = 0 ; l < num ; l++)
                        {
                            add1 += cube[i,k,l];
                            add2 += cube[k,l,i];
                            add3 += cube[l,i,k];
                        }
                        if((add1 == ((amount+1)*num/2))&(add2 == ((amount+1)*num/2))&(add3 == ((amount+1)*num/2))) 
                        {
                            check = false;
                            add1=0;
                            add2=0;
                            add3=0;
                        }
                        else 
                        {
                            check = true;
                            add1=0;
                            add2=0;
                            add3=0;
                            break;
                        }
                    }
                    if(check == true)
                    {
                        break;
                    }
                }

                /*check the diagnal*/
                if(check == false)
                {
                    for(int i = 0 ; i < num ; i++)
                    {
                        add1 += cube[i,i,i];
                    }
                    if(add1 == (amount+1)*num/2)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                }


                /*delete*/
                if(check ==true)
                {
                    for(int i = 0 ; i <num ; i++)
                        for(int w = 0 ; w < num ; w++)
                            for(int k = 0 ; k < num ; k++)
                            {
                                cube[i,w,k] = 0;
                            }
                }
            }
            int count = 1;
            for(int i = 0 ; i < num ; i++)
            {
                Console.WriteLine("第{0}層:",count);
                for(int w = 0 ; w < num ;w++)
                {
                    for(int k = 0 ; k < num ; k++)
                    {
                        Console.Write(cube[i,w,k] + "\t");
                    }
                    Console.WriteLine("\r\n");
                }
                count++;
            }
        }
    }
}
