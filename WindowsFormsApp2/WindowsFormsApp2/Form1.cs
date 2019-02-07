using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client _cl = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = _cl.GetData(1);
            //// string gitCommand = "git";
            //// //string gitAddArgument = @"add -A";

            //// //string gitCommitArgument = @"commit ""explanations_of_changes"" ";
            //string gitPushArgument = @"log --pretty = format:""%h - %an, %ar : %s""";

            ////var a =  Process.Start(gitCommand, gitPushArgument);
            //ListShaWithFiles("");

        }
        //public static string ListShaWithFiles(string path)
        //{
        //    string a = @"log --pretty = format:""%h - %an, %ar : %s""";
        //    var output = RunProcess(a);
        //    return output;
        //}
        //private static string RunProcess(string command)
        //{
        //    // Start the child process.
        //    Process p = new Process();
        //    // Redirect the output stream of the child process.
        //    p.StartInfo.UseShellExecute = false;
        //    p.StartInfo.RedirectStandardOutput = true;
        //    p.StartInfo.FileName = "git.exe";
        //    p.StartInfo.Arguments = command;
        //    p.Start();
        //    // Read the output stream first and then wait.
        //    string output = p.StandardOutput.ReadToEnd();
        //    p.WaitForExit();
        //    return output;
        //}
    }
}
