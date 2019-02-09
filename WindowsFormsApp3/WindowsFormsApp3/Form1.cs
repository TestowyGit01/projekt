using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public void A()
        //{
        //    string directory = @"D:\GIT\projekt"; // directory of the git repository

        //    using (PowerShell powershell = PowerShell.Create())
        //    {
        //        // this changes from the user folder that PowerShell starts up with to your git repository
        //        powershell.AddScript(String.Format(@"cd {0}", directory));

        //        powershell.AddScript(@"git init");
        //        powershell.AddScript(@"git add *");
        //        powershell.AddScript(@"git commit -m 'git commit from PowerShell in C#'");
        //        powershell.AddScript(@"git push");

        //        Collection<PSObject> results = powershell.Invoke();
        //    }
        //}

        public static string ListShaWithFiles(string path)
        {
            var output = RunProcess(string.Format(" --git-dir={0}/.git --work-tree={1} log --name-status", path.Replace("\\", "/"), path.Replace("\\", "/")));
            return output;
        }

        private static string RunProcess(string command)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.FileName = Config.GitExectuable;
            p.StartInfo.Arguments = command;
            p.Start();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        public void B()
        {
            string gitCommand = "git";
            string gitAddArgument = @"add -A";
            string gitCommitArgument = @"commit ""explanations_of_changes"" ";
            string gitPushArgument = @"push our_remote";

            Process.Start(gitCommand, gitAddArgument);
            Process.Start(gitCommand, gitCommitArgument);
            Process.Start(gitCommand, gitPushArgument);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B();
            //A();
        }
    }
}
