using System;
class Program
{
static double Sum (int[,] array)
{
    int s=0;
    for(int i =0; i<array.GetLength(0); i++)
    {
        for (int j=0 ; j<array.GetLength(1);j++)
        {
             s=s+ array [i,j];
        }
    }
    return s;
}
static double Product (int [,] array)
{
  int p=1;
  for(int i=0 ; i <array.GetLength(0); i++)
  {
    for(int j =0 ; j <array.GetLength(1);j++)
    {
      p=p*array[i,j];
    }
  }
  return p;
}
static double Max(int [,] array)
{
  int maxelement= array[0,0];
  for ( int i = 0; i< array.GetLength(0) ; i++)
  {
    for(int j = 0; j< array.GetLength(1) ; j++)
    {
      if (array [i, j]> maxelement)
      {
        maxelement= array[i,j];
      }
    }
  }
  return maxelement;
}
static double Min(int [,] array)
{
  int minelement = array [0,0];
  for ( int i =0 ; i< array.GetLength (0) ; i++) 
  {
    for ( int j=0 ; j< array.GetLength(1) ; j++)
    {
      if (array [i,j] < minelement)
      {
        minelement = array [ i,j];
      }
    }

  }
  return minelement;

}
  static void Main  (string []args)
  {

    int n,m; 
    int [,] array;
    Console.WriteLine("Massivin olcusunu daxiledin:\n");
    n = Convert.ToInt32(Console.ReadLine());
    m=  Convert.ToInt32(Console.ReadLine());
    array= new int[n,m];
    Console.WriteLine("Massivin elementlerini daxil edin :\n");
    for(int i = 0; i < n; i++)
  {
      for(int j  = 0; j < m; j++)
      {
	      Console.Write("element - [{0},{1}] : ",i,j);
		    array[i, j] = Convert.ToInt32(Console.ReadLine()); 
      }
  } 
  Console.Write("Matrix formasi : \n");
  for(int i=0 ; i < n ; i++)
  {
      Console.Write("\n");
      for(int j = 0; j < m; j++)
      {
         Console.Write("{0}\t",array[i,j]);
      }
   Console.Write("\n\n");
  }
     Console.WriteLine($"Massivin elementlerinin cemi {Sum(array)} dir");
     Console.WriteLine($"Massivin elementlerinin hasili {Product(array)} dir");
     Console.WriteLine($"Massivin maximum elementi {Max(array)} dir");
     Console.WriteLine($"Massivin minimum elementi {Min(array)} dir");
  }
}