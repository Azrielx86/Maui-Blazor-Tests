using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Blazor_Basics
{
	public class FileAccessHelper
	{
		public static string GetLocalFilePath(string filename)
		{
#if ANDROID
			var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			return System.IO.Path.Combine(documentsPath, filename);
#else

			return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
#endif
		}
	}
}
