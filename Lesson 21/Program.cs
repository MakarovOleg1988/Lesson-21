using System;
using System.Reflection;

namespace Lesson_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var _cl = new ReflectionMethod();
            var _cl1 = new ReflectionMethod();
            var _type = _cl.GetType();
            _type = typeof(ReflectionMethod);

            var _fields = _type.GetProperty("_protectedString", BindingFlags.NonPublic | BindingFlags.Instance);
            _fields.SetValue(_cl, "this is test");

            Console.WriteLine(_fields.GetValue(_cl));

            var _fields1 = _type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            var _field = _type.GetField("_fieldint", BindingFlags.NonPublic | BindingFlags.Instance);
            _field.SetValue(_cl, 12);

            var _method = _fields.GetMethod;

            Console.WriteLine(_field.GetValue(_cl));

            var _field1 = _type.GetField("_fieldlong", BindingFlags.NonPublic | BindingFlags.Instance);
            _field1.SetValue(_cl1, (long)1124);

            Console.WriteLine(_field.GetValue(_cl1));
        }
    }

    public class ReflectionMethod
    {
        private int _fieldint;
        protected short _fieldshort;
        protected long _fieldlong;

        private char _protectedchar { get; set; }
        protected string _protectedString { get; set; }
        public DateTime __publicDateTime { get; set; }

        private void _setInt(int t) { }
        protected object _getObject => null;
        public TimeSpan _getTimeSpan() => TimeSpan.MaxValue; 
    }
}
