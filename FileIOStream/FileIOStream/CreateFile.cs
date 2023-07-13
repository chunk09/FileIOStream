using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream.FileIOStream
{
	internal class CreateFile
	{
		/// <summary>
		/// 지정한 경로에 파일만 생성하는 함수
		/// </summary>
		/// <param name="path">상대경로 매개변수</param>
		/// <param name="encoding"></param>
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

		/// <summary>
		/// 지정한 경로에 내용이 있는 파일을 저장, 파일이 있으면 덮어씌움
		/// </summary>
		/// <param name="path">상대경로 매개변수</param>
		/// <param name="content">파일에 작성할 내용</param>
		/// <param name="encoding"></param>
		public void CreateWithWrite(string path, string content, Encoding encoding)
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

		// 지정한 경로에 폴더가 없을 경우 폴더를 생성하고 그 폴더 안에 파일을 생성함
		// 만들어야함
	}
}
