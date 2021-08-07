using System;

namespace report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the dimension of your square:");
            int D = Convert.ToInt32(Console.ReadLine());
            
            if((num % 2 != 0) & (D == 2))
            {
                oddnumber(num);
            }
            if((D==2)&(num % 2 == 0)&(num % 4 == 0))
            {
                twoevennumber(num);
            }


            if((D==2)&(num % 2 == 0) & (num % 4 != 0))
            {
                twooddnumber(num);
            }
            if((D==3)&(num % 2 != 0))
            {
                threeodddimension(num,D); 
            }
            if((D==3)&(num % 2 == 0)&(num % 4 == 0))
            {
                threeevendimension(num,D);
            }


            Console.ReadKey();
        }

        static void oddnumber(int num)
        {
            int[,] square = new int[num,num];
            int amount = num * num;
            int number = 1;
            int[] string1 = new int[(amount-1)/2];
            int[] string2 = new int[(amount-1)/2];
            bool check = true;


            /*create the number sequence*/
            for(int i = 0 ; i < (amount-1)/2 ; i++)
            {
                string1[i] = number;
                number++;
            }
            number++;
            for(int i = 0 ; i < (amount-1)/2 ; i++)
            {
                string2[i] = number;
                number++;
            }
            Array.Reverse(string2);  

            /*put the number in the square*/
            while(check == true)
            {
                square[(num-1)/2,(num-1)/2] = (amount+1)/2;
                for(int i = 0 ; i <(amount-1)/2 ; i++)
                {
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    int k = rand1.Next();
                    int j = rand2.Next();
                    if(square[k%num,j%num] == 0)
                    {
                        square[k%num,j%num] = string1[i];
                        square[num -k%num -1,num -j%num -1] = string2[i];
                    }
                    else 
                    {
                        i--;
                    }
                }

                int add1 = 0;
                int add2 = 0;
                for(int i = 0 ; i < num ; i++)
                {

                    for(int w = 0 ;w < num ; w++)
                    {
                        add1 += square[i,w];
                        add2 += square[w,i];
                    }
                    if((add1 == ((amount+1)*num/2))&(add2 == ((amount+1)*num/2))) 
                    {
                        check = false;
                        add1 = 0;
                        add2 = 0;
                    }
                    else 
                    {
                        check = true;
                        add1 = 0;
                        add2 = 0;
                    }
                }

                if(check ==true)
                {
                    for(int i = 0 ; i < num ; i++)
                    {
                        for(int w = 0 ;w < num ; w++)
                        {
                            square[i,w] = 0;
                        }
                    }
                }  
            }

            for(int i = 0 ; i < num ; i++)
                {
                    for(int k = 0 ; k < num ; k++)
                    {
                        Console.Write(square[i,k] + "\t");
                        
                    }
                    Console.WriteLine("\r\n");
                }            
        }


        static void twoevennumber(int num)
        {
            int k = num / 4;
            int[,] square = new int[num,num];
            int[,] square1 = new int[num,num];
            int number = 1;
            for(int i = 0 ; i < num ; i++)
                for(int w = 0 ; w < num ; w++)
                {
                    square[i,w] = number;
                    square1[i,w] = number;
                    number += 1 ;
                }


            for(int n = 0 ; n < num ; n++)//rewrite the square
                {
                    if(n == k)
                    {
                        n += 2*k;
                    }
                    for(int m = 0 ; m < num ; m++)
                    {
                        if (m == k)
                        {
                            m += 2*k ;
                        }
                        square[n,m] = square1[num-n-1,num-m-1];
                    }
                }

            for(int i = 0; i < num ; i++)
            {
                for(int o = 0 ; o < num ; o++)
                {
                    Console.Write(square[i,o] + "\t");
                }
                Console.WriteLine("\r\n");
            }
        }




        static void twooddnumber(int num)
        {
            int k = (num-2) / 4;
            int lg = 2*k+1;

            /*square1*/
            int[,] square1 = new int[lg,lg];
            int y1 =0;
            int x1 =(lg-1)/2;
            square1[y1,x1] = 1;
            for(int number = 2 ; number <= lg*lg ; number++)
            {
                y1 -= 1;
                x1 += 1;
                if(y1 < 0) y1 += lg;
                if(x1 >= lg) x1 -= lg;
                if(square1[y1,x1] != 0)
                {
                    y1 += 2;
                    x1 -= 1;
                    if((y1 >= lg) | (x1 < 0))
                    {
                        y1 -= lg;
                        x1 += lg;
                    }
                }

                square1[y1,x1] = number; 

            }

            /*square2*/
            int[,] square2 = new int[lg,lg];
            int y2 = 0;
            int x2 = (lg-1)/2;
            square2[y2,x2] = 1+lg*lg;
            for(int number = 2 + lg*lg ; number <= 2*lg*lg ; number++)
            {
                y2 -= 1;
                x2 += 1;
                if(y2 < 0) y2 += lg;
                if(x2 >= lg) x2 -= lg;
                if(square2[y2,x2] != 0)
                {
                    y2 += 2;
                    x2 -= 1;
                    if((y2 >= lg) | (x2 < 0))
                    {
                        y2 -= lg;
                        x2 += lg;
                    }
                }

                square2[y2,x2] = number; 
            }


            /*square3*/
            int[,] square3 = new int[lg,lg];
            int y3 = 0;
            int x3 = (lg-1)/2;
            square3[y3,x3] = 1+2*lg*lg;
            for(int number = 2 + 2*lg*lg ; number <= 3*lg*lg ; number++)
            {
                y3 -= 1;
                x3 += 1;
                if(y3 < 0) y3 += lg;
                if(x3 >= lg) x3 -= lg;
                if(square3[y3,x3] != 0)
                {
                    y3 += 2;
                    x3 -= 1;
                    if((y3 >= lg) | (x3 < 0))
                    {
                        y3 -= lg;
                        x3 += lg;
                    }
                }

                square3[y3,x3] = number; 
            }



            /*square4*/
            int[,] square4 = new int[lg,lg];
            int y4 = 0;
            int x4 = (lg-1)/2;
            square4[y4,x4] = 1+3*lg*lg;
            for(int number = 2 + 3*lg*lg ; number <= 4*lg*lg ; number++)
            {
                y4 -= 1;
                x4 += 1;
                if(y4 < 0) y4 += lg;
                if(x4 >= lg) x4 -= lg;
                if(square4[y4,x4] != 0)
                {
                    y4 += 2;
                    x4 -= 1;
                    if((y4 >= lg) | (x4 < 0))
                    {
                        y4 -= lg;
                        x4 += lg;
                    }
                }

                square4[y4,x4] = number; 
            }



            /*conbine the square*/

            int[,] square = new int[num,num];
            for(int i = 0 ; i < lg ; i++)
            {
                for(int j = 0 ; j < lg ;j++)
                {
                    square[i,j] = square1[i,j];
                    square[i,j+lg] = square3[i,j];
                    square[i+lg,j] = square4[i,j];
                    square[i+lg,j+lg] = square2[i,j];
                }
            }


            /*change the position*/
            for(int i = 0 ; i < lg ; i++)//change the k th column
            {
                square[i,k-1] = square4[i,k-1];
                square[i+lg,k-1] = square1[i,k-1];
            }
            square[k,k-1] = square1[k,k-1];
            square[k+lg,k-1] = square4[k,k-1];

            for(int i = 0 ; i < lg ; i++)//change the (k-1) column on both sides.
            {
                if(k == 1) break;
                square[i,k-2] = square4[i,k-2];
                square[i+lg,k-2] = square1[i,k-2];
                square[i,2*lg - (k-1)] = square2[i,lg-(k-1)];
                square[i+lg,2*lg - (k-1)] = square3[i,lg-(k-1)];
            }

            square[k,k] = square4[k,k];
            square[k+lg,k] = square1[k,k];


            /*printout*/
            for(int i = 0 ; i < num ; i++)
            {
                for(int w = 0 ; w < num ; w++)
                {
                    Console.Write(square[i,w] + "\t");
                }
                Console.WriteLine("\r\n");
            }
        }


        static void threeodddimension(int num , int D)
        {
            int amount = num*num*num;
            int[,,] cube = new int[num,num,num];
            int[] string1 = new int[(amount-1)/2];
            int[] string2 = new int[(amount-1)/2];
            int number = 1;
            bool check = true;
            int count = 1;

            /*create the number sequence*/
            for(int i = 0 ; i < (amount-1)/2 ; i++)
            {
                string1[i] = number;
                number++;
            }
            number++;
            for(int i = 0 ; i < (amount-1)/2 ; i++)
            {
                string2[i] = number;
                number++;
            }
            Array.Reverse(string2);

            /*put the number in the cube*/
            while(check == true)
            {
                cube[(num-1)/2,(num-1)/2,(num-1)/2] = (amount+1)/2;
                for(int i = 0 ; i < (amount-1)/2 ; i++)
                {
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    Random rand3 = new Random();
                    int k = rand1.Next();
                    int j = rand2.Next();
                    int l = rand3.Next();
                    if(cube[k%num,j%num,l%num] == 0)
                    {
                        if(k%num == (num-1)/2)
                        {
                            cube[k%num,j%num,l%num] = string1[i];
                            cube[k%num,num-j%num-1,num - l%num -1] = string2[i];
                        }
                        else
                        {
                            cube[k%num,j%num,l%num] = string1[i];
                            cube[num-k%num-1,num-j%num-1,num-l%num-1] = string2[i];
                        }
                    }
                    else
                    {
                        i--;
                    }
                }

                /*check the cube*/
                int add1=0;
                int add2=0;
                int add3=0;
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
                    if((add1 != ((amount+1)*num*num/2))||(add2 != ((amount+1)*num*num/2))||(add3 == ((amount+1)*num*num/2)))
                    {
                        break;
                    }
                }

                /*if not, delete all number in the cube.*/
                if(check == true)
                {
                    for(int i = 0 ; i < num ; i++)
                    {
                        for(int k = 0 ; k < num ; k++)
                        {
                            for(int l = 0 ; l < num ; l++)
                            {
                                cube[i,k,l] = 0;
                            }
                        }
                    }
                }
            }

            for(int i = 0 ; i < num ; i++)
                {
                    Console.WriteLine("第{0}層:",count);
                    for(int k = 0 ; k < num ; k++)
                    {
                        for(int l = 0 ; l < num ; l++)
                        {
                            Console.Write(cube[i,k,l] + "\t");
                        }
                        Console.WriteLine("\r\n");
                    }
                    count++;
                }
            
        }





        static void threeevendimension(int num , int D)
        {
            int amount = num*num*num;
            int[,,] cube = new int[num,num,num];
            int[] string1 = new int[(amount)/2];
            int[] string2 = new int[(amount)/2];
            int number = 1;
            bool check = true;
            int count = 1;

            /*create the number sequence*/
            for(int i = 0 ; i < (amount)/2 ; i++)
            {
                string1[i] = number;
                number++;
            }
            for(int i = 0 ; i < (amount)/2 ; i++)
            {
                string2[i] = number;
                number++;
            }
            Array.Reverse(string2);

            /*put the number in the cube*/
            while(check == true)
            {
                cube[(num-1)/2,(num-1)/2,(num-1)/2] = (amount+1)/2;
                for(int i = 0 ; i < (amount-1)/2 ; i++)
                {
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    Random rand3 = new Random();
                    int k = rand1.Next();
                    int j = rand2.Next();
                    int l = rand3.Next();
                    if(cube[k%num,j%num,l%num] == 0)
                    {
                        cube[k%num,j%num,l%num] = string1[i];
                        cube[num-k%num-1,num-j%num-1,num-l%num-1] = string2[i];
                    }
                    else
                    {
                        i--;
                    }
                }

                /*check the cube*/
                int add1=0;
                int add2=0;
                int add3=0;
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

                /*if not, delete all number in the cube.*/
                if(check == true)
                {
                    for(int i = 0 ; i < num ; i++)
                    {
                        for(int k = 0 ; k < num ; k++)
                        {
                            for(int l = 0 ; l < num ; l++)
                            {
                                cube[i,k,l] = 0;
                            }
                        }
                    }
                }
            }

            for(int i = 0 ; i < num ; i++)
                {
                    Console.WriteLine("第{0}層:",count);
                    for(int k = 0 ; k < num ; k++)
                    {
                        for(int l = 0 ; l < num ; l++)
                        {
                            Console.Write(cube[i,k,l] + "\t");
                        }
                        Console.WriteLine("\r\n");
                    }
                    count++;
                }
        }
    }
}
