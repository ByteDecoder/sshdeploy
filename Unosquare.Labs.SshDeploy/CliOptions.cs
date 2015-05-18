﻿using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unosquare.Labs.SshDeploy
{
    public class CliOptions
    {
        public const string PushVerb = "push";
        public const string RunVerb = "run";
        public const string ShellVerb = "shell";

        [HelpVerbOption]
        public string GetUsage(string verb)
        {
            return HelpText.AutoBuild(this, verb);
        }

        [VerbOption(PushVerb, HelpText = "Transfers the files and folders from a source path in the local machine to a target path in the remote machine")]
        public PushVerbOptions PushVerbOptions { get; set; }

        [VerbOption(RunVerb, HelpText = "Runs the specified command on the target machine")]
        public RunVerbOptions RunVerbOptions { get; set; }

        [VerbOption(ShellVerb, HelpText = "Opens an interactive mode shell.")]
        public ShellVerbOptions ShellVerbOptions { get; set; }
    }
}
