#region Metods && Metod Overloading Practic

//ShowName();
//static void ShowName()
//{

//    Console.WriteLine("Mirze Beshirzade");
//}
//--------------------------------------------------

//ShoWMarried();
//static void ShoWMarried()
//{
//    bool IsMarried = true;

//    if (IsMarried)
//    {
//        Console.WriteLine("Evlidir");
//    }
//    else
//    {
//        Console.WriteLine("Subaydir");
//    }

//}

//---------------------------------------------------


//static string GetPhone()
//{
//    return "SamSung Galaxy";

//}
//var result = GetPhone();

//Console.WriteLine(result);

//----------------------------------------------------

//    sum();
//   static void sum()
//{
//    int n = 8;
//    int m = 26;
//    int sum = n + m;
//    Console.WriteLine(sum);

//}

//------------------------------------------------------

//Sum(19, 26);
//static void Sum(int num1, int num2)
//{
//    int result = num1 + num2;
//    Console.WriteLine(result);

//}

//-------------------------------------------------------


//static int SumOddNums(int n, int m)
//{ 
//    int sum = 0;

//	for (int i = n; i <=m; i++)
//	{
//		if (i%2==1)
//		{
//			sum += i;
//		}
//	}
//	   return sum;
//}

//int result = SumOddNums(19, 26);

//Console.WriteLine(result);

//------------------------------------------------------------


//static int GetCountorEvenNumsfromArray(int[] nums)
//{ int count = 0;
//	foreach (var item in nums)
//	{
//		if (item%2==0)
//		{
//			count++;
//		}
//	}
//	 return count;	
//}

//int[] arr = { 1, 3, 4, 2, 5, 6, 8, 7, 9, 12 };
//var result = GetCountorEvenNumsfromArray(arr);
//Console.WriteLine(result);

//----------------------------------------------------------------

#endregion


#region Arr Class Constructor

//using System.Text;

//string surname = "Beshir";
//string surname2 = "zade";
//string name = "Mir";
//string name2 = "ze";
//StringBuilder   stringBuilder = new StringBuilder("Beshirzade Mirze");
//Console.WriteLine(stringBuilder);

//---------------------------------------------------------------------------


//string name = "Mirze";
//var result = ReverseStr(name);
//Console.WriteLine(result);

//static string ReverseStr(string str)
//{

//    var ReversedArray = str.Reverse().ToArray();
//    string res = "";
//    foreach (var item in ReversedArray)
//    {
//        res+= item;
//    }
//      return res;

//}

//--------------------------------------------------------------------------

//TesT(new int[] { 1, 2, 3, 6, 5,100 });
//static void TesT(int[] array)
//{
//	foreach (var item in array)
//	{
//		if (item ==100)
//		{
//			return;
//		}
//	}

//	Console.WriteLine("Salam");

//}

//--------------------------------------------









#endregion




#region OOP-Inheritance-Encapsulation-AccessModifiers


//using HomeWork;

//Account Account= new Account();
//Account.Login("Username", "Cavid1993");

//-------------------------------------------------



//using HomeWork;

//Factorial factorial = new Factorial();
//Factorial.FactorialNum(5);


//----------------------------------------------------


//using HomeWork;

//Animal Animal=new Animal();
//Bird bird =new Bird();
//bird.name = "Goyercin";
//Console.WriteLine(bird.name);



#endregion


