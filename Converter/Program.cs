using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = ("Original");
            DirectoryInfo dir = new DirectoryInfo(filepath);
            foreach (var file in dir.GetFiles("*.wav"))
            {
                using (var reader = new WaveFileReader(file.FullName))
                {
                    var newFormat = new WaveFormat(16000, 16, 1);
                    using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))
                    {
                        WaveFileWriter.CreateWaveFile("Converted\\" + file.Name, conversionStream);
                    }
                }
            }
        }
    }
}
