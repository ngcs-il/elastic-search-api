using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConvertYamlToSql
{
    class Program
    {
        private static string GetValue(string[] lines, ref int index)
        {
            var line = lines[index];
            index += 1;
            var i = line.IndexOf(": ", StringComparison.InvariantCulture);
            line = line.Substring(i + 2).Trim();
            return line;
        }

        static void Main(string[] args)
        {
            var courtsLevelDic = new Dictionary<string, int>();

            var lines = File.ReadAllLines("Courts.yml");

            var sb = new StringBuilder();

            var index = 0;
            while (index < lines.Length)
            {
                var id = GetValue(lines, ref index);
                var name = GetValue(lines, ref index);
                var level = GetValue(lines, ref index);
                if (!courtsLevelDic.TryGetValue(level, out var levelId))
                {
                    levelId = courtsLevelDic.Count + 1;
                    courtsLevelDic.Add(level, levelId);
                    sb.AppendLine();
                    sb.AppendLine("GO");
                    sb.AppendLine($"INSERT INTO [dbo].[CourtLevels] ([id], [name]) VALUES ({levelId}, N'{level}');");
                }

                sb.AppendLine();
                sb.AppendLine("GO");
                sb.AppendLine($"INSERT INTO [dbo].[Courts] ([id], [name], [levelId]) VALUES ({id}, N'{name}', {levelId});");
            }

            File.WriteAllText("Courts.sql", sb.ToString());
        }
    }
}
