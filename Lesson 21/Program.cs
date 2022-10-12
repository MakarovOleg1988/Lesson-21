using System;
using System.Reflection;

namespace Lesson_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var _cl = new ReflectionMethod();
            var _type = _cl.GetType();
            _type = typeof(ReflectionMethod);

            var _fields = _type.GetFields();

            var _fieldName = _fields[0].Name;

            var _field = _type.GetField("_fieldint");
            _field.SetValue(_cl, 12);
        }
    }

    public class ReflectionMethod
    {
        private int _fieldint;
        protected short _fieldshort;
        public long _fieldlong;

        private char _protectedchar { get; set; }
        protected string _protectedshort { get; set; }
        public DateTime __publicDateTime { get; set; }

        private void _setInt(int t) { }
        protected object _getObject => null;
        public TimeSpan _getTimeSpan() => TimeSpan.MaxValue; 
    }
}
