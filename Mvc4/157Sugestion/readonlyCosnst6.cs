using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _157Sugestion
{
    //readonly 有更多的灵活性， 可以为每个实例拥有一个自己不可变的的变量
   public class readonlyCosnst6
   {
       public readonly int ReadOnlyValue;

       public readonlyCosnst6(int value)
       {
           ReadOnlyValue = value;

           A a = new A();
           B b = new B();

          // a = b;
           b = (B)a;//unable to cast from a to b

           b.g();
       }
   }

    public class A
    {
        public void f()
        {
            
        }
    }

    public class B : A
    {
        public void g()
        {
            
        }
    }
}
