using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;

class Build : NukeBuild
{
    public static int Main () => Execute<Build>(x => x.Run);

    /// <summary>
    /// online converter: https://dom111.github.io/image-to-ansi/
    /// </summary>
    Target Run => _ => _
        .Executes(() =>
        {
            var logo = File.ReadAllText(RootDirectory / "clown.txt");
            logo = Regex.Replace(logo, @"(\r\n|\n)", Environment.NewLine);
            Console.WriteLine(logo);
        });

}
