using Autodesk.AdvanceSteel.CADAccess;
using Autodesk.AdvanceSteel.DocumentManagement;
using Autodesk.AdvanceSteel.Runtime;
using System.Windows.Forms;

namespace HelloWorld
{
    public class TestClass
    {
        [CommandMethodAttribute("TEST_GROUP", "HelloWorld", "HelloWorld", CommandFlags.Modal)]
        public void SayHelloWorld()
        {
            MessageBox.Show("Hello World#!");
        }
    }
}