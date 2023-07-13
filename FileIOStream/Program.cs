using System.Text;
using FileIOStream.FileIOStream;

var path = @"";

var cf = new CreateFile();
cf.CreateWithWrite(path, "HEllo", Encoding.UTF8);

var rf = new ReadFile();
var content = rf.Read(path);

Console.WriteLine(content);