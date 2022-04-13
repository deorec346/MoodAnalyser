using System;
using System.Reflection;
namespace Mood_Analyzer_problem
{
    public class FactoryMood<Gtype>
    {
        //tyof is a class it will take anything class
        //and can take metadata 
        Type type = typeof(Gtype);

        public object  GetObjectByDefaultConstructor()
        {
            //reff     var              con
            // MyClass myClsObj = new MyClass()
            //get constructor
            ConstructorInfo[] constructor = type.GetConstructors();
            ConstructorInfo mycon = constructor[0];
            //it will create obj and assign memory in new obj
            //invoke is a method inside this constructor infomation
            var myObj = mycon.Invoke(new object[0]);
            return myObj;
        }
    }
}
