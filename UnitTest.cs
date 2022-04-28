#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluginDemo;
using System.IO;
using System.Reflection;
using PlugIn;
using System.Collections.Generic;

#endregion

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void LoadPlugins_WithValidPath_FoundedPlugins()
        {
            // Arrange
            FrmMain form = new FrmMain();
            PrivateObject privateObject = new PrivateObject(form);

            // Act
            privateObject.Invoke("LoadPlugins",
                Path.GetDirectoryName(Assembly.GetAssembly(typeof(FrmMain)).Location));

            // Assert
            List<IPlugin> plugins = (List<IPlugin>)privateObject.GetField("_plugins");
            Assert.AreEqual(plugins[0].ToString(), "Plugin1.PlugIn");
            Assert.AreEqual(plugins[1].ToString(), "Plugin2.PlugIn");
        }
    }
}
