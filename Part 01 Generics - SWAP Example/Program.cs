
namespace Part_01_Generics___SWAP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic SWAP


            //int x=15 ,y=10 ;
            //Console.WriteLine($"X= {x}");
            //Console.WriteLine($"Y= {y}");
            //// complier can be detect the type T
            //Helper.SWAP(ref x,ref y);
            //Console.WriteLine($"X= {x}");
            //Console.WriteLine($"Y= {y}");
            #endregion
            #region Search
            //Employee employee01 = new Employee(1, "eslam", 20_000);
            //Employee employee02 = new Employee(2, "ahmed", 25_000);

            //Employee[] employes = { employee01, employee02  , new Employee(3, "ali", 200) };

            ////int result =  Helper<Employee>.SearchArray(employes, new Employee(2, "ahmed", 25_000));
            //Console.WriteLine(result);
            #endregion
            #region Sort
            // Struct
            Employee2[] employee2 =
            {
                new Employee2(1, "test1" , 170),
                new Employee2(2, "test2" , 200),
                new Employee2(3, "test3" , 150),
                new Employee2(4, "test4" , 190),
            };
            Helper<Employee2>.BubbleSort(employee2);

            //Class
            Employee[] employee =
          {
                new Employee(1, "ahmed" , 170),
                new Employee(2, "eslam" , 200),
                new Employee(3, "eee" , 150),
                new Employee(4, "tttt" , 190),
            };
            // base Class
            Helper<Employee>.BubbleSort(employee);
            // base Struct
            Helper<Employee2>.BubbleSort(employee2);


            foreach (var item in employee)
                Console.WriteLine(item);

            Console.WriteLine("================================");
            foreach (var item in employee2)
                Console.WriteLine(item);
            #endregion

        }
        
    }
}
