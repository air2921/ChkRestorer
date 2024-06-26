﻿using System;
using System.IO;

namespace ChkRestorer
{
    public static class Determinant
    {
        private static byte[] GetSourceSignature<T>(T src, int size = 32) where T : notnull
        {
            var fileHeader = new byte[size];

            if (src is Stream stream)
            {
                stream.Read(fileHeader, 0, fileHeader.Length);
                return fileHeader;
            }
            if (src is string filePath)
            {
                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                fs.Read(fileHeader, 0, fileHeader.Length);
                return fileHeader;
            }

            throw new NotSupportedException("Not supported generic type");
        }

        private static void ChangeExtension(string filePath, string targetPath, string extension)
        {
            var fileInfo = new FileInfo(filePath);
            var newFileName = $"{Path.GetFileNameWithoutExtension(fileInfo.Name)}{extension}";

            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            File.Move(filePath, Path.Join(targetPath, newFileName));
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
                        if (header[i] != signature[i])
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
            if (autoCreate && !Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            var files = Directory.GetFiles(folderPath, "*.CHK", SearchOption.TopDirectoryOnly);
            if (files.Length == 0)
                throw new FileNotFoundException($"No .CHK files found in {folderPath}");

            foreach (var filePath in files)
            {
                var header = GetSourceSignature(filePath);
                var extension = CompareExtension(header);
                if (extension != null)
                {
                    ChangeExtension(filePath, targetPath, extension);
                }
            }
        }

        public static void ChangeSourceExtension(string filePath, string targetPath)
        {
            var header = GetSourceSignature(filePath);
            var extension = CompareExtension(header) ?? throw new NotSupportedException("Could not match file extension");

            ChangeExtension(filePath, targetPath, extension);
        }

        public static string GetExtension<T>(T src) where T : notnull
        {
            var header = GetSourceSignature(src);
            var extension = CompareExtension(header) ?? throw new NotSupportedException("Could not match file extension");

            return extension;
        }
    }
}

