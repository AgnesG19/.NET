

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
    [TestClass]
    public class MonitorDatos_Tests
    {
        private MonitorDatos _monitores;

        [TestInitialize]
        public void Init()
        {
            _monitores = new MonitorDatos();
        }

        [TestMethod]
        public void LeerMonitores_LeeTodo()
        {
            Assert.IsTrue(_monitores.LeerMonitores().Count > 0);
        }

        [TestMethod]
        public void ActualizaMonitor_Test()
        {
            var monitor = _monitores.LeerMonitores()[0];
            var newName = monitor.NombreMonitor + "T";
            monitor.NombreMonitor = newName;
            _monitores.ActualizarMonitor(monitor);
            var updatedMonitor = _monitores.LeerMonitores()[0];
            Assert.AreEqual(newName, updatedMonitor.NombreMonitor);
        }
    }
}