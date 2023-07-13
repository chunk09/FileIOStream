using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream.FileIOStream
{
	internal class CreateFile
	{
		public void Create(string path, Encoding encoding)
		{
			if (File.Exists(path))
			{
				Console.WriteLine("지정한 경로에 파일이 존재합니다.");

				return;
			}

			File.WriteAllText(path, string.Empty, encoding);

			Console.WriteLine($"{path} 경로에 파일이 생성되었습니다.");
		}
		
		public void Create(string path, string content, Encoding encoding)
		{
			if (File.Exists(path))
			{
				File.WriteAllText(path, content, encoding);
				Console.WriteLine(path + " 경로에 파일이 덮어씌어졌습니다.");
			}
			else
			{
				File.WriteAllText(path, content, encoding);
				Console.WriteLine(path + " 경로에 파일이 생성되고 작성을 완료했습니다.");
			}
		}

		public void CreateWithDirectory(string path, Encoding encoding)
		{
			var splitPath = path.Split(@"\");
			var dirPath = splitPath[0];

			for (int i = 1; i < splitPath.Length - 1; i++)
			{
				dirPath = @$"{dirPath}\{splitPath[i]}";
			}

			Console.WriteLine($"dir : {dirPath}");

			if (Directory.Exists(dirPath))
			{
				Console.WriteLine("지정한 경로에 폴더가 존재하기에 폴더를 생성하지 않고 원래 있던 폴더에 파일을 생성하겠습니다.");
				File.WriteAllText(path, string.Empty, encoding);
			}
			else
			{
				Directory.CreateDirectory(dirPath);
				Console.WriteLine(dirPath + " 경로에 폴더 생성");

				File.WriteAllText(path, string.Empty, encoding);
				Console.WriteLine("파일 생성 완료");
			}
		}

		public void CreateWithDirectory(string path, string content, Encoding encoding)
		{
			var splitPath = path.Split(@"\");
			var dirPath = splitPath[0];

			for (int i = 1; i < splitPath.Length - 1; i++)
			{
				dirPath = @$"{dirPath}\{splitPath[i]}";
			}

			Console.WriteLine($"dir : {dirPath}");

			if (Directory.Exists(dirPath))
			{
				Console.WriteLine("지정한 경로에 폴더가 존재하기에 폴더를 생성하지 않고 원래 있던 폴더에 파일을 생성하겠습니다.");
				File.WriteAllText(path, content, encoding);
			}
			else
			{
				Directory.CreateDirectory(dirPath);
				Console.WriteLine(dirPath + " 경로에 폴더 생성");

				File.WriteAllText(path, content, encoding);
				Console.WriteLine("파일 생성 완료");
			}
		}
	}
}
