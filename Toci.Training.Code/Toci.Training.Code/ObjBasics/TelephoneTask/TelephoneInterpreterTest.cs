using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.Training.Code.ObjBasics.TelephoneTask
{
    [TestClass]
    public class TelephoneInterpreterTest
    {
        [TestMethod]
        public void TestTelephoneInterpreter()
        {
            var elements = GetAllInterpreters();

            foreach (var element in elements)
            {
                element.GetUserChoice(2);
            }
        }

        private IEnumerable<TelephoneInterpreter> GetAllInterpreters()
            {
            List<TelephoneInterpreter> objects = new List<TelephoneInterpreter>();
                foreach (Type type in Assembly.GetAssembly(typeof(TelephoneInterpreter)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(TelephoneInterpreter))))
                {
                        objects.Add((TelephoneInterpreter)Activator.CreateInstance(type));
                }
                return objects;
            }
    }
}
