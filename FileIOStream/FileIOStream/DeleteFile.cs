using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream.FileIOStream
{
	internal class DeleteFile
	{
		/// <summary>
		/// 지정한 경로에 있는 파일을 삭제하는 함수
		/// </summary>
		/// <param name="path">상대경로 매개변수</param>
		public void Delete(string path)
		{
			if (!File.Exists(path))
			{
				Console.WriteLine("지정한 경로에 파일이 존재하지 않습니다.");
				return;
			}

			File.Delete(path);
			Console.WriteLine(path + " 경로 파일 삭제 완료");
		}
	}
}
