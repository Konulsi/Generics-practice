


#region Fibenocci
//Fibonacci(8);


//static void Fibonacci(int n)
//{
//    int a = 1;
//    int b = 1;
//    int c;

//    Console.WriteLine(a);
//    Console.WriteLine(b);

//    for (int i = 1; i <= n; i++)
//    {
//        c = a + b; //2

//        a = b; //1
//        b = c; //2

//        Console.WriteLine(c);
//    }
//}


//double for

//Test();

//static void Test()
//{
//    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = 0; j < arr.Length - 1; j++)
//        {
//            Console.WriteLine(arr[i] + " " + arr[j]);
//        }


//    }
//}

#endregion

#region Student
//static void ShowSameStudentsCount()
//{
//    Student stu1 = new Student()
//    {
//        Id= 1,
//        Name = "Roya"
//    };

//    Student stu2 = new Student()
//    {
//        Id = 2,
//        Name = "Roya"
//    };

//    Student stu3 = new Student()
//    {
//        Id = 3,
//        Name = "Roya"
//    };

//    Student stu4 = new Student()
//    {
//        Id = 4,
//        Name = "Roya"
//    };

//    Student[] students = { stu1, stu2, stu3, stu4 };
//    int count = 0;
//    for (int i = 0; i < students.Length; i++)
//    {
//        for (int j = 1; j < students.Length - 1; j++)
//        {
//            if (students[i].Name == students[j].Name)
//            {
//                count++;
//            }
//        }
//    }
//    Console.WriteLine(count);
//}
#endregion

#region Manat
//Manat manat = new Manat(340);

//Dollar dollar = manat;

//Console.WriteLine(dollar.Usd);
#endregion


//StringList list1 = new StringList();

//list1.Add("Konul");
//list1.Add("Roya");
//list1.Add("Cinara");
//list1.GetAll();

//IntList list2 = new IntList();

//list2.Add(1);
//list2.Add(2);
//list2.Add(3);
//list2.Add(4);
//list2.GetAll();


//StudentList list3 = new StudentList();

//list3.Add(new Student { Id = 1, Name = "Konul" });
//list3.Add(new Student { Id = 2, Name = "Roya" });
//list3.Add(new Student { Id = 3, Name = "Cinara" });
//list3.GetAll();



//DataList<string> students= new DataList<string>();

//students.Add("Konul");
//students.Add("Roya");
//students.Add("Cinara");
//students.GetAll();

//DataList<int> numbers = new DataList<int>();

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.GetAll();

//DataList<Student> studentList= new DataList<Student>();

//studentList.Add(new Student { Id = 1, Name = "Konul" });
//studentList.Add(new Student { Id = 2, Name = "Roya" });
//studentList.Add(new Student { Id = 3, Name = "Cinare" });
//studentList.GetAll();


//List<int> nums = new List<int>();

//nums.Add(100);
//nums.Add(22);

////foreach (var item in nums)
////{
////    Console.WriteLine(item);
////}

//for (int i = 0; i <= nums.Count; i++)
//{
//	for (int j = i; j <= nums.Count - 1; j++)
//	{
//		if (nums[i] > nums[j])
//		{
//			Console.WriteLine("Boyukdur");
//			break;
//		}
//	}
//}



//Repository<Studentt> student = new Repository<Studentt>();

//Repository<int> num= new Repository<int>();

//Repository<string> str = new Repository<string>();

//Repository<bool> married = new Repository<bool>();

//Repository<Test1, Test2> data = new Repository<Test1, Test2>();