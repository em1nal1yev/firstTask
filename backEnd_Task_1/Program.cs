// See https://aka.ms/new-console-template for more information


#region task 1
// 11.

//int x = 135;
//int iks = x;
//int y = 0;
//int hasil = 1;
//while(iks > 0)
//{
//    iks /= 10;
//    y++;
//}

//for(int i = 0; i<y; i++)
//{
//    iks = x % 10;
//    hasil = iks * hasil;
//    x = x / 10;
//}
//Console.WriteLine(hasil);
#endregion


#region task 2
//int x = 15;
//int counter = 0;
//int y;
//for(int i =1; i<x; i++)
//{
//    y = x % i;


//    if (y == 0)
//    {
//        counter++;
//    }
//}
//if(counter > 1)
//{
//    Console.WriteLine("Murekkebdir");
//}
//else
//{
//    Console.WriteLine("sadedir");
//}

#endregion


#region task 3
//string[] arr1 = { "salam", "sagol", "necesen", "hardasan", "neter" };
//string[] arr2 = new String[arr1.Length];
//int counter = 0;
//for (int i = arr1.Length - 1; i>=0; i--)
//{
//    arr2[counter] = arr1[i];
//    counter++;
//}

//arr1 = arr2;

//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.Write(arr2[i] + " ");
//}
#endregion


#region task4
//int[] numbers = { 2, 5, 4, 3 };
//Console.WriteLine("n ededi daxil edin n =");
//int n = int.Parse(Console.ReadLine());
//bool chekBox = false;
//for(int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < n)
//    {
//        chekBox = true;
//    }
//}
//Console.WriteLine(chekBox);
#endregion


#region task 5
//string[] arr1 = { "Emin", "Ilham", "Murad","Emil", "Emil", "Emin" };


//for (int i = 0; i < arr1.Length ; i++)
//{
//    for (int j = i+1; j < arr1.Length ; j++)
//    {
//        if (arr1[i] == arr1[j])
//        {
//            Console.WriteLine(arr1[i]);
//            break;
//        }
//    }
//}
#endregion


#region task 6
//int n = 987;
//int x = 1;
//int y = 0;
//while (y<=n)
//{
//    Console.WriteLine(y);
//    if (x > n)
//    {
//        break;
//    }
//    Console.WriteLine(x);
//    y = y + x;
//    x = x + y;

//}
#endregion