using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    public class MyException:Exception//имя придется поменять
    {
        public MyException()
        {
            /*значения свойств по умолчанию*/
        }
        /*будут свойства*/
    }

    public class MyException2 : MyException//имя придется поменять
    {
        public MyException2()
        {
            /*значения свойств по умолчанию*/
        }
        /*будут свойства*/
    }

    public class MyException3 : MyException2//имя придется поменять
    {
        public MyException3()
        {
            /*значения свойств по умолчанию*/
        }
        /*будут свойства*/
    }
}
