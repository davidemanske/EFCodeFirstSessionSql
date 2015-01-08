using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Web;

namespace SessionStateSql.Migrations
{
    public class DbMigrationExtensions
    {
        public static string[] PrpareSqlScripts(string script)
        {
            var scriptsToExecute = new List<string>();
            StringBuilder commandBuilder = new StringBuilder();
            var lines = script.Split(new string[]{"\n"}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                if (line.Trim().ToLower() == "go")
                {
                    if (!string.IsNullOrWhiteSpace(commandBuilder.ToString()))
                    {
                        scriptsToExecute.Add(commandBuilder.ToString());
                    }
                    commandBuilder.Clear();
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        commandBuilder.Append(line);
                        commandBuilder.Append("\n");
                    }
                }
            }

            if (commandBuilder.Length > 0)
            {
                scriptsToExecute.Add(commandBuilder.ToString());
            }

            return scriptsToExecute.ToArray();
        }
    }
}