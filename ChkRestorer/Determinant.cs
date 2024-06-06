using System;
using System.IO;

namespace ChkRestorer
{
    public static class Determinant
    {
        private static byte[] GetSourceSignature(string filePath, int size = 36)
        {
            try
            {
                byte[] fileHeader = new byte[size];

                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                fs.Read(fileHeader, 0, fileHeader.Length);

                return fileHeader;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        private static byte[] GetSourceSignature(Stream stream, int size = 36)
        {
            byte[] fileHeader = new byte[size];

            stream.Read(fileHeader, 0, fileHeader.Length);
            return fileHeader;
        }

        private static void ChangeExtension(string filePath, string targetPath, string extension)
        {
            try
            {
                var fileInfo = new FileInfo(filePath);
                var newFileName = $"{Path.GetFileNameWithoutExtension(fileInfo.Name)}{extension}";

                if (!Directory.Exists(targetPath))
                    Directory.CreateDirectory(targetPath);

                File.Move(filePath, Path.Join(targetPath, newFileName));
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        private static string? CompareExtension(byte[] header)
        {
            foreach (var signature in Signature.SignatureExtensions.Keys)
            {
                if (header.Length >= signature.Length)
                {
                    bool match = true;
                    for (int i = 0; i < signature.Length; i++)
                    {
                        if (!header[i].Equals(signature[i]))
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        return Signature.SignatureExtensions[signature];
                    }
                }
            }

            return null;
        }

        public static void ChangeSourceExtensionRange(string folderPath, string targetPath, bool autoCreate = true)
        {
            try
            {
                if (autoCreate)
                    if (!Directory.Exists(targetPath))
                        Directory.CreateDirectory(targetPath);

                var files = Directory.GetFiles(folderPath, "*.CHK", SearchOption.TopDirectoryOnly);
                if (files is null || files.Length <= 0)
                    throw new FileNotFoundException($"No one .CHK file was not found in {folderPath}");

                foreach (var filePath in files)
                {
                    var header = GetSourceSignature(filePath);
                    var extension = CompareExtension(header);
                    if (extension is null)
                        continue;

                    ChangeExtension(filePath, targetPath, extension);
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public static void ChangeSourceExtension(string filePath, string targetPath)
        {
            try
            {
                var header = GetSourceSignature(filePath);
                var extension = CompareExtension(header) ?? throw new NotSupportedException("Could not match file extension");

                ChangeExtension(filePath, targetPath, extension);
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public static string GetExtension(string filePath)
        {
            try
            {
                var header = GetSourceSignature(filePath);
                var extension = CompareExtension(header) ?? throw new NotSupportedException("Could not match file extension");

                return extension;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public static string GetExtension(Stream stream)
        {
            try
            {
                var header = GetSourceSignature(stream);
                var extension = CompareExtension(header) ?? throw new NotSupportedException("Could not match file extension");

                return extension;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }
    }
}

