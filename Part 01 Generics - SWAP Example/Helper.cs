using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Part_01_Generics___SWAP_Example
{
    internal class Helper<T> where  T : IComparable<T> , new()
    {
        //generic method
        public static void SWAP(ref T x , ref T y)
        {
            //Console.WriteLine("============ SWAPING");
            T temp = x; 
            x = y;
            y = temp;
        }
        public static int SearchArray(T[] arr, T value)
        {
            for (int i = 0; i < arr?.Length; i++)
                if(value.Equals(arr[i]))
                    return i;
            
             return -1;
            
        }
        public  static void BubbleSort(T[]arr)
        {
            for(int i = 0;  i < arr?.Length; i++)
            {
                for (int j = 0; j < arr.Length -i -1; j++)
                {
                    if (arr[j].CompareTo(arr[j+1])==1)
                        SWAP(ref arr[j], ref arr[j+1]);
                }
            }
        }

    }
    public class Employee :  IComparable<Employee> 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id && this.Name == other.Name;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{this.Id}:: {this.Name} :: {this.Salary}";
        }

        ///========================================= non-generic 
        //public int CompareTo(object? obj)
        //{

        //    #region is Casting Operator 
        //    //Employee employee2 = (Employee)obj; // unsafe Casting 
        //    /**using is Conditional Operator:
        //     return True in 3 Cases:
        //    1.obj is Employee 
        //    2.obj object form class Inhert from employee
        //    3.is null
        //     **/
        //    //if (obj is Employee employee2)
        //    //{
        //    //    if(obj is null) return 1;
        //    //    if (this.Salary > employee2.Salary)
        //    //        return 1;
        //    //    else if (this.Salary < employee2.Salary)
        //    //        return -1;

        //    //}
        //    #endregion

        //    #region as Casting Operator
        //    // If Casting failed, return null, No Exception Will be throw   
        //    Employee employee2 = obj as Employee;
        //    if (employee2 == null) return 0;
        //    if (this.Salary > employee2.Salary)
        //        return 1;
        //    else if (this.Salary < employee2.Salary)
        //        return -1;
        //    return 1;
        //    #endregion
        //}
        ///================================================
       ///================================ generic 
        public int CompareTo(Employee? employee2)
        {

            if (this.Salary > employee2.Salary)
                return 1;
            else if (this.Salary < employee2.Salary)
                return -1;
            else
                return 0;
        }
    }
    public struct Employee2 : IComparable<Employee2>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee2(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id && this.Name == other.Name;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{this.Id}:: {this.Name} :: {this.Salary}";
        }

        public int CompareTo(Employee2 employee2)
        {
            
            if (this.Salary > employee2.Salary)
                return 1;
            else if (this.Salary < employee2.Salary)
                return -1;
            else
            return 0;
        }
    }
}
