using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream.FileIOStream
{
	internal class ReadFile
	{
		/// <summary>
		/// 지정한 경로 파일에 내용을 가져옵니다.
		/// </summary>
		/// <param name="path">상대경로 매개변수</param>
		/// <returns>파일 내용을 가져옵니다.</returns>
		public string Read(string path)
		{
			if (!File.Exists(path))
			{
				Console.WriteLine("지정한 경로에 파일이 존재하지 않습니다.");
				return "Error";
			}
			return File.ReadAllText(path);
		}
	}
}
