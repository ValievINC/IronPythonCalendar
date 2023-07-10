using IronPython.Hosting;
using System;
using System.Text;
using Aveva.Core.PMLNet;


namespace AquaLibCSharp
{
    [PMLNetCallable]
    public partial class Calendar : UserControl
    {
        [PMLNetCallable]
        public static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            string filePath = "calendar.py";
            string fileContent = System.IO.File.ReadAllText(filePath, Encoding.Unicode);

            engine.Execute(fileContent, scope);
        }
    }
}