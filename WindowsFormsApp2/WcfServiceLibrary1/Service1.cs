using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<Model> GetData(int value)
        {
            List<Model> _lista = new List<Model>();
            string a = " ";
            using (var repo = new Repository(@"D:\Projekty"))
            {
                foreach (Commit c in repo.Commits)
                {
                    Model asa = new Model();
                    asa.Imie = c.Author.Name;
                    asa.Data = c.Author.When;
                    _lista.Add(asa);
                }
                //var RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";

                //foreach (Commit c in repo.Commits.Take(15))
                //{
                //    Console.WriteLine(string.Format("commit {0}", c.Id));

                //    if (c.Parents.Count() > 1)
                //    {
                //        Console.WriteLine("Merge: {0}",
                //            string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray()));
                //    }

                //    Console.WriteLine(string.Format("Author: {0} <{1}>", c.Author.Name, c.Author.Email));
                //    Console.WriteLine("Date:   {0}", c.Author.When.ToString(RFC2822Format, CultureInfo.InvariantCulture));
                //    Console.WriteLine();
                //    Console.WriteLine(c.Message);
                //    Console.WriteLine();
                //    a = "Date:  " + c.Author.Name;
                //}
            }
            return _lista;
        }
    }
}
