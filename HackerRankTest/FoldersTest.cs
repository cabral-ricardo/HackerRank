using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    /// <summary>
    /// This class return the folders that starting letter receive in parameter
    /// </summary>
    [TestClass]
    public class FoldersTest
    {
        [TestMethod]
        public void GetFoldersUninstallInformationAndUsers()
        {
            Assert.AreEqual("uninstallinformation-users", GetFolders('u'));
        }

        [TestMethod]
        public void GetFoldersC()
        {
            Assert.AreEqual("c", GetFolders('c'));
        }

        [TestMethod]
        public void GetFoldersProgramFiles()
        {
            Assert.AreEqual("programfiles", GetFolders('p'));
        }

        [TestMethod]
        public void GetFoldersEmpty()
        {
            Assert.AreEqual("", GetFolders('x'));
        }

        private string GetFolders(char startingLetter)
        {
            string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

            var folders = new StringBuilder();

            foreach (string name in Folders.FolderNames(xml, startingLetter))
            {
                folders.AppendFormat("{0}-", name.ToLower().Replace(" ", ""));
            }

            var names = string.Empty;

            if (folders.Length > 0)
            {
                names = folders.ToString();
                names = names.Substring(0, names.Length - 1);
            }

            return names;
        }
    }
}
