using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public static void DeleteFilesAndFoldersRecursively(string target_dir)
        {
            foreach (string file in Directory.GetFiles(target_dir))
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            foreach (string subDir in Directory.GetDirectories(target_dir))
            {
                DeleteFilesAndFoldersRecursively(subDir);
            }
            Thread.Sleep(1); // This makes the difference between whether it works or not. Sleep(0) is not enough.
            Directory.Delete(target_dir);
        }

        public List<Model> GetData(int value)
        {
            List<Model> _lista = new List<Model>();            
            string url = "https://github.com/TestowyGit01/projekt";
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = Path.Combine(projectPath, "Git_tmp");

            string clonedRepoPath = Repository.Clone(url, folderName);
            using (var repo = new Repository(clonedRepoPath))
            {
                foreach (Commit c in repo.Commits)
                {
                    Model asa = new Model();
                    asa.Imie = c.Author.Name;
                    asa.Data = c.Author.When;
                    _lista.Add(asa);
                }
            }
            DeleteFilesAndFoldersRecursively(folderName);

            return _lista;
        }
    }
}
