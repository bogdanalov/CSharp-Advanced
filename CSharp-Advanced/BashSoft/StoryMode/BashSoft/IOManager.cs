﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
	public static class IOManager
	{
		public static void TraverseDirectory(string path)
		{
			OutputWriter.WriteEmptyLine();
			int initialIdentation = path.Split('\\').Length;
			Queue<string> subFolders = new Queue<string>();
			subFolders.Enqueue(path);

			while (subFolders.Count != 0)
			{
				string currentPath = subFolders.Dequeue();
				int identation = currentPath.Split('\\').Length - initialIdentation;
				foreach (var directory in Directory.GetDirectories(currentPath))
				{
					subFolders.Enqueue(directory);
					
				}

				OutputWriter.WriteMessageOnNewLine(string.Format($"{new string('-', identation)}{currentPath}"));

			}
		}
	}
}
