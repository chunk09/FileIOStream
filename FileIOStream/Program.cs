using System.Text;
using FileIOStream.FileIOStream;

var path = @"C:\Users\user\hello\aaa\test.txt";

var cf = new CreateFile();
cf.CreateWithDirectory(path, Encoding.UTF8);