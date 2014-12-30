using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace RA2_YR_Config
{
    public static class Utils
    {
        public static void CompressFileLZMA(string inFile, string outFile)
        {
            SevenZip.Compression.LZMA.Encoder coder = new SevenZip.Compression.LZMA.Encoder();
            using (FileStream input = new FileStream(inFile, FileMode.Open))
            using (FileStream output = new FileStream(outFile, FileMode.Create))
            {
                // Write the encoder properties
                coder.WriteCoderProperties(output);

                // Write the decompressed file size.
                output.Write(BitConverter.GetBytes(input.Length), 0, 8);

                // Encode the file.
                coder.Code(input, output, input.Length, -1, null);
                output.Flush();
                output.Close();
            }
        }

        public static void DecompressFileLZMA(byte[] sourceBytes, string outFile)
        {
            SevenZip.Compression.LZMA.Decoder coder = new SevenZip.Compression.LZMA.Decoder();

            using (var memoryStream = new MemoryStream(sourceBytes))
            using (var output = new FileStream(outFile, FileMode.Create, FileAccess.Write))
            {
                // Read the decoder properties
                byte[] properties = new byte[5];
                memoryStream.Read(properties, 0, 5);

                // Read in the decompress file size.
                byte[] fileLengthBytes = new byte[8];
                memoryStream.Read(fileLengthBytes, 0, 8);
                long fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

                coder.SetDecoderProperties(properties);
                coder.Code(memoryStream, output, memoryStream.Length, fileLength, null);
                output.Flush();
                output.Close();
            }
        }

        public static void DecompressFileLZMA(string inFile, string outFile)
        {
            SevenZip.Compression.LZMA.Decoder coder = new SevenZip.Compression.LZMA.Decoder();
            using (FileStream input = new FileStream(inFile, FileMode.Open, FileAccess.Read))
            using (FileStream output = new FileStream(outFile, FileMode.Create, FileAccess.Write))
            {
                // Read the decoder properties
                byte[] properties = new byte[5];
                input.Read(properties, 0, 5);

                // Read in the decompress file size.
                byte[] fileLengthBytes = new byte[8];
                input.Read(fileLengthBytes, 0, 8);
                long fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

                coder.SetDecoderProperties(properties);
                coder.Code(input, output, input.Length, fileLength, null);
                output.Flush();
                output.Close();
            }
        }


        public static string GetMD5Checksum(string file)
        {
            string checksum = "";
            if (!File.Exists(file)) return "FileDoesNotExist";
            try
            {
                using (var mD5 = MD5CryptoServiceProvider.Create())
                using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    checksum = BitConverter.ToString(mD5.ComputeHash(fileStream)).Replace("-", "").ToLower();
                return checksum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return checksum;
            }
        }

        public static string GetSHA1Checksum(string file)
        {
            string checksum = "";
            if (!File.Exists(file)) return "FileDoesNotExist";
            try
            {
                using (var sHA1 = new SHA1CryptoServiceProvider())
                using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    checksum = BitConverter.ToString(sHA1.ComputeHash(fileStream)).Replace("-", "").ToLower();
                return checksum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return checksum;
            }
        }

        public static string[] ReadWebsite(string uRL, char[] separator)
        {
            try
            {
                using (var webClient = new TWebClient())
                {
                    using (var stream = webClient.OpenRead(uRL))
                    using (var streamReader = new StreamReader(stream))
                    {
                        var lines = new List<String>();
                        var streamReaderLines = streamReader.ReadToEnd().Split(separator);
                        foreach (string line in streamReaderLines)
                        {
                            if (line.Length > 0) lines.Add(line);
                        }
                        return lines.ToArray();
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public static string[] ReadCSV(string line)
        {
            while (line.StartsWith(" ")) line = line.Substring(1, line.Length - 1);
            var result = new List<string>();
            bool ccontinue = false;
            string value = "";
            string[] tempValues = line.Split(',');

            foreach (string tempValue in tempValues)
            {
                if (ccontinue)
                {
                    // End of field
                    if (tempValue.EndsWith("\""))
                    {
                        value += "," + tempValue.Substring(0, tempValue.Length - 1);
                        result.Add(value);
                        value = "";
                        ccontinue = false;
                        continue;

                    }
                    else
                    {
                        // Field still not ended
                        value += "," + tempValue;
                        continue;
                    }
                }

                // Fully encapsulated with no comma within
                if (tempValue.StartsWith("\"") && tempValue.EndsWith("\""))
                {
                    if ((tempValue.EndsWith("\"\"") && !tempValue.EndsWith("\"\"\"")) && tempValue != "\"\"")
                    {
                        ccontinue = true;
                        value = tempValue;
                        continue;
                    }

                    result.Add(tempValue.Substring(1, tempValue.Length - 2));
                    continue;
                }

                // Start of encapsulation but comma has split it into at least next field
                if (tempValue.StartsWith("\"") && !tempValue.EndsWith("\""))
                {
                    ccontinue = true;
                    value += tempValue.Substring(1);
                    continue;
                }

                // Non encapsulated complete field
                result.Add(tempValue);

            }

            return result.ToArray();
        }

    }
}
