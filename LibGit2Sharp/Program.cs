using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGit2Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repository.Clone("https://github.com/EdiWang/EnvSetup.git", @"D:\EnvSetup");
            var repo = new Repository(@"D:\EnvSetup");
            //using (var repo = new Repository(@"D:\EnvSetup"))
            {
                var branches = repo.Branches;
                foreach (var b in branches)
                {
                    Console.WriteLine(b.FriendlyName);
                }
            }
            foreach (var commit in repo.Commits)
            {
                Console.WriteLine(
                    $"{commit.Id.ToString().Substring(0, 7)} " +
                    $"{commit.Author.When.ToLocalTime()} " +
                    $"{commit.MessageShort} " +
                    $"{commit.Author.Name}");
            }
	    Console.ReadKey();
            Console.ReadKey();
        }
    }
}
