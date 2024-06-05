﻿using System.Collections.Generic;
using System.Linq;

namespace ChkRestorer
{
    internal static class Signature
    {
        internal static readonly Dictionary<byte[], string> SignatureExtensions = new Dictionary<byte[], string>
        {
            { new byte[] { 0x02, 0x00, 0x5A, 0x57, 0x52, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, ".cwk" },
            { new byte[] { 0x00, 0x00, 0x02, 0x00, 0x06, 0x04, 0x06, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00 }, ".wk1" },
            { new byte[] { 0x00, 0x00, 0x1A, 0x00, 0x00, 0x10, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00 }, ".wk3" },
            { new byte[] { 0x00, 0x00, 0x1A, 0x00, 0x02, 0x10, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00 }, ".wk4" },
            { new byte[] { 0x00, 0x00, 0x49, 0x49, 0x58, 0x50, 0x52 }, ".qxd" },
            { new byte[] { 0x00, 0x00, 0x4D, 0x4D, 0x58, 0x50, 0x52 }, ".qxd" },
            { new byte[] { 0x50, 0x57, 0x53, 0x33 }, ".psafe3" },
            { new byte[] { 0xD4, 0xC3, 0xB2, 0xA1 }, ".pcap" },
            { new byte[] { 0xA1, 0xB2, 0xC3, 0xD4 }, ".pcap" },
            { new byte[] { 0x0A, 0x0D, 0x0D, 0x0A }, ".pcapng" },
            { new byte[] { 0x53, 0x51, 0x4C, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x20, 0x33, 0x00 }, ".sqlite" },
            { new byte[] { 0x53, 0x50, 0x30, 0x31 }, ".bin" },
            { new byte[] { 0x49, 0x57, 0x41, 0x44 }, ".wad" },
            { new byte[] { 0x00, 0x00, 0x01, 0x00 }, ".ico" },
            { new byte[] { 0x69, 0x63, 0x6E, 0x73 }, ".icns" },
            { new byte[] { 0x66, 0x74, 0x79, 0x70, 0x33, 0x67 }, ".3gp" },
            { new byte[] { 0x66, 0x74, 0x79, 0x70, 0x68, 0x65, 0x69, 0x63 }, ".heic" },
            { new byte[] { 0x66, 0x74, 0x79, 0x70, 0x6D }, ".heic" },
            { new byte[] { 0x1F, 0x9D }, ".z" },
            { new byte[] { 0x1F, 0xA0 }, ".z" },
            { new byte[] { 0x2D, 0x68, 0x6C, 0x30, 0x2D }, ".lzh" },
            { new byte[] { 0x2D, 0x68, 0x6C, 0x35, 0x2D }, ".lzh" },
            { new byte[] { 0x42, 0x41, 0x43, 0x4B, 0x4D, 0x49, 0x4B, 0x45, 0x44, 0x49, 0x53, 0x4B }, ".bac" },
            { new byte[] { 0x49, 0x4E, 0x44, 0x58 }, ".idx" },
            { new byte[] { 0x62, 0x70, 0x6C, 0x69, 0x73, 0x74 }, ".plist" },
            { new byte[] { 0x42, 0x5A, 0x68 }, ".bz2" },
            { new byte[] { 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 }, ".gif" },
            { new byte[] { 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 }, ".gif" },
            { new byte[] { 0x49, 0x49, 0x2A, 0x00 }, ".tif" },
            { new byte[] { 0x4D, 0x4D, 0x00, 0x2A }, ".tiff" },
            { new byte[] { 0x49, 0x49, 0x2A, 0x00, 0x10, 0x00, 0x00, 0x00, 0x43, 0x52 }, ".cr2" },
            { new byte[] { 0x80, 0x2A, 0x5F, 0xD7 }, ".cin" },
            { new byte[] { 0x4E, 0x55, 0x52, 0x55, 0x49, 0x4D, 0x47 }, ".nui" },
            { new byte[] { 0x4E, 0x55, 0x52, 0x55, 0x50, 0x41, 0x4C }, ".nup" },
            { new byte[] { 0x53, 0x44, 0x50, 0x58 }, ".dpx" },
            { new byte[] { 0x58, 0x40, 0x44, 0x53 }, ".dpx" },
            { new byte[] { 0x76, 0x2F, 0x31, 0x01 }, ".exr" },
            { new byte[] { 0x42, 0x50, 0x47, 0xFB }, ".bpg" },
            { new byte[] { 0xFF, 0xD8, 0xFF, 0xE0, 0x00, 0x10, 0x4A, 0x46, 0x49, 0x46, 0x00, 0x01 }, ".jpeg" },
            { new byte[] { 0xFF, 0xD8, 0xFF, 0xEE }, ".jpeg" },
            { new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 }, ".jpg" },
            { new byte[] { 0x00, 0x00, 0x00, 0x0C, 0x6A, 0x50, 0x20, 0x20, 0x0D, 0x0A, 0x87, 0x0A }, ".jpf" },
            { new byte[] { 0xFF, 0x4F, 0xFF, 0x51 }, ".jpf" },
            { new byte[] { 0x71, 0x6F, 0x69, 0x66 }, ".qoi" },
            { new byte[] { 0x4C, 0x5A, 0x49, 0x50 }, ".lz" },
            { new byte[] { 0x30, 0x37, 0x30, 0x37, 0x30, 0x37 }, ".cpio" },
            { new byte[] { 0x4D, 0x5A }, ".dll" },
            { new byte[] { 0x5A, 0x4D }, ".exe" },
            { new byte[] { 0x50, 0x4B, 0x03, 0x04 }, ".zip" },
            { new byte[] { 0x50, 0x4B, 0x05, 0x06 }, ".zip" },
            { new byte[] { 0x50, 0x4B, 0x07, 0x08 }, ".zip" },
            { new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 }, ".rar" },
            { new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x01, 0x00 }, ".rar" },
            { new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }, ".png" },
            { new byte[] { 0x0E, 0x03, 0x13, 0x01 }, ".hdf4" },
            { new byte[] { 0x89, 0x48, 0x44, 0x46, 0x0D, 0x0A, 0x1A, 0x0A }, ".hdf5" },
            { new byte[] { 0xC9 }, ".com" },
            { new byte[] { 0xCA, 0xFE, 0xBA, 0xBE }, ".class" },
            { new byte[] { 0xEF, 0xBB, 0xBF }, ".txt" },
            { new byte[] { 0xFF, 0xFE }, ".txt" },
            { new byte[] { 0xFE, 0xFF }, ".txt" },
            { new byte[] { 0xFF, 0xFE, 0x00, 0x00 }, ".txt" },
            { new byte[] { 0x00, 0x00, 0xFE, 0xFF }, ".txt" },
            { new byte[] { 0x0E, 0xFE, 0xFF }, ".txt" },
            { new byte[] { 0x25, 0x21, 0x50, 0x53 }, ".ps" },
            { new byte[] { 0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F, 0x62, 0x65, 0x2D, 0x33, 0x2E, 0x30, 0x20, 0x45, 0x50, 0x53, 0x46, 0x2D, 0x33, 0x2E, 0x30 }, ".epsf" },
            { new byte[] { 0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F, 0x62, 0x65, 0x2D, 0x33, 0x2E, 0x31, 0x20, 0x45, 0x50, 0x53, 0x46, 0x2D, 0x33, 0x2E, 0x30 }, ".epsf" },
            { new byte[] { 0x49, 0x54, 0x53, 0x46, 0x03, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00 }, ".chm" },
            { new byte[] { 0x3F, 0x5F }, ".hlp" },
            { new byte[] { 0x25, 0x50, 0x44, 0x46, 0x2D }, ".pdf" },
            { new byte[] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11, 0xA6, 0xD9, 0x00, 0xAA, 0x00, 0x62, 0xCE, 0x6C }, ".asf" },
            { new byte[] { 0x4F, 0x67, 0x67, 0x53 }, ".ogg" },
            { new byte[] { 0x38, 0x42, 0x50, 0x53 }, ".psd" },
            { new byte[] { 0xFF, 0xFB }, ".mp3" },
            { new byte[] { 0xFF, 0xF3 }, ".mp3" },
            { new byte[] { 0xFF, 0xF2 }, ".mp3" },
            { new byte[] { 0x49, 0x44, 0x33 }, ".mp3" },
            { new byte[] { 0x42, 0x4D }, ".bmp" },
            { new byte[] { 0x43, 0x44, 0x30, 0x30, 0x31 }, ".iso" },
            { new byte[] { 0x43, 0x44, 0x30, 0x30, 0x31 }, ".cdi" },
            { new byte[] { 0x6D, 0x61, 0x69, 0x6E, 0x2E, 0x62, 0x73 }, ".mgw" },
            { new byte[] { 0x4E, 0x45, 0x53 }, ".nes" },
            { new byte[] { 0xA0, 0x32, 0x41, 0xA0, 0xA0, 0xA0 }, ".d64" },
            { new byte[] { 0x47, 0x53, 0x52, 0x2D, 0x31, 0x35, 0x34, 0x31 }, ".g64" },
            { new byte[] { 0xA0, 0x33, 0x44, 0xA0, 0xA0 }, ".d81" },
            { new byte[] { 0x43, 0x36, 0x34, 0x20, 0x74, 0x61, 0x70, 0x65, 0x20, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x20, 0x66, 0x69, 0x6C, 0x65 }, ".t64" },
            { new byte[] { 0x43, 0x36, 0x34, 0x20, 0x43, 0x41, 0x52, 0x54, 0x52, 0x49, 0x44, 0x47, 0x45, 0x20, 0x20, 0x20 }, ".crt" },
            { new byte[] { 0x53, 0x49, 0x4D, 0x50, 0x4C, 0x45, 0x20, 0x20, 0x3D, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x54 }, ".fits" },
            { new byte[] { 0x66, 0x4C, 0x61, 0x43 }, ".flac" },
            { new byte[] { 0x4D, 0x54, 0x68, 0x64 }, ".mid" },
            { new byte[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, ".doc" },
            { new byte[] { 0x64, 0x65, 0x78, 0x0A, 0x30, 0x33, 0x35, 0x00 }, ".dex" },
            { new byte[] { 0x4B, 0x44, 0x4D }, ".vdmk" },
            { new byte[] { 0x23, 0x20, 0x44, 0x69, 0x73, 0x6B, 0x20, 0x44, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F }, ".vdmk" },
            { new byte[] { 0x43, 0x72, 0x32, 0x34 }, ".crx" },
            { new byte[] { 0x41, 0x47, 0x44, 0x33 }, ".fh8" },
            { new byte[] { 0x05, 0x07, 0x00, 0x00, 0x42, 0x4F, 0x42, 0x4F, 0x05, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 }, ".cwk" },
            { new byte[] { 0x06, 0x07, 0xE1, 0x00, 0x42, 0x4F, 0x42, 0x4F, 0x06, 0x07, 0xE1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 }, ".cwk" },
            { new byte[] { 0x45, 0x52, 0x02, 0x00, 0x00, 0x00 }, ".toast" },
            { new byte[] { 0x8B, 0x45, 0x52, 0x02, 0x00, 0x00, 0x00 }, ".toast" },
            { new byte[] { 0x6B, 0x6F, 0x6C, 0x79 }, ".dmg" },
            { new byte[] { 0x78, 0x61, 0x72, 0x21 }, ".xar" },
            { new byte[] { 0x50, 0x4D, 0x4F, 0x43, 0x43, 0x4D, 0x4F, 0x43 }, ".dat" },
            { new byte[] { 0x4E, 0x45, 0x53, 0x1A }, ".nes" },
            { new byte[] { 0x75, 0x73, 0x74, 0x61, 0x72, 0x00, 0x30, 0x30 }, ".tar" },
            { new byte[] { 0x75, 0x73, 0x74, 0x61, 0x72, 0x20, 0x20, 0x00 }, ".tar" },
            { new byte[] { 0x74, 0x6F, 0x78, 0x33 }, ".tox" },
            { new byte[] { 0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C }, ".7z" },
            { new byte[] { 0x1F, 0x8B }, ".gz" },
            { new byte[] { 0xFD, 0x37, 0x7A, 0x58, 0x5A, 0x00 }, ".xz" },
            { new byte[] { 0x04, 0x22, 0x4D, 0x18 }, ".iz4" },
            { new byte[] { 0x4D, 0x53, 0x43, 0x46 }, ".cab" },
            { new byte[] { 0x46, 0x4C, 0x49, 0x46 }, ".flif" },
            { new byte[] { 0x1A, 0x45, 0xDF, 0xA3 }, ".mkv" },
            { new byte[] { 0x4D, 0x49, 0x4C, 0x20 }, ".stg" },
            { new byte[] { 0x30, 0x82 }, ".der" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x43, 0x45, 0x52, 0x54, 0x49, 0x46, 0x49, 0x43, 0x41, 0x54, 0x45, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".pem" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x43, 0x45, 0x52, 0x54, 0x49, 0x46, 0x49, 0x43, 0x41, 0x54, 0x45, 0x20, 0x52, 0x45, 0x51, 0x55, 0x45, 0x53, 0x54, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".pem" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x50, 0x52, 0x49, 0x56, 0x41, 0x54, 0x45, 0x20, 0x4B, 0x45, 0x59, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".pem" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x44, 0x53, 0x41, 0x20, 0x50, 0x52, 0x49, 0x56, 0x41, 0x54, 0x45, 0x20, 0x4B, 0x45, 0x59, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".pem" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x52, 0x45, 0x41, 0x20, 0x50, 0x52, 0x49, 0x56, 0x41, 0x54, 0x45, 0x20, 0x4B, 0x45, 0x59, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".pem" },
            { new byte[] { 0x50, 0x75, 0x54, 0x54, 0x59, 0x2D, 0x55, 0x73, 0x65, 0x72, 0x2D, 0x4B, 0x65, 0x79, 0x2D, 0x46, 0x69, 0x6C, 0x65, 0x2D, 0x32, 0x3A }, ".ppk" },
            { new byte[] { 0x50, 0x75, 0x54, 0x54, 0x59, 0x2D, 0x55, 0x73, 0x65, 0x72, 0x2D, 0x4B, 0x65, 0x79, 0x2D, 0x46, 0x69, 0x6C, 0x65, 0x2D, 0x33, 0x3A }, ".ppk" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x53, 0x53, 0x48, 0x32, 0x20, 0x4B, 0x45, 0x59, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".pub" },
            { new byte[] { 0x44, 0x49, 0x43, 0x4D }, ".dcm" },
            { new byte[] { 0x77, 0x4F, 0x46, 0x46 }, ".woff" },
            { new byte[] { 0x77, 0x4F, 0x46, 0x32 }, ".woff2" },
            { new byte[] { 0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20 }, ".xml" },
            { new byte[] { 0x3C, 0x00, 0x3F, 0x00, 0x78, 0x00, 0x6D, 0x00, 0x6C, 0x00, 0x20 }, ".xml" },
            { new byte[] { 0x00, 0x3C, 0x00, 0x3F, 0x00, 0x78, 0x00, 0x6D, 0x00, 0x6C, 0x00, 0x20 }, ".xml" },
            { new byte[] { 0x3C, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x78, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x00, 0x00, 0x6C, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00 }, ".xml" },
            { new byte[] { 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x78, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x00, 0x00, 0x6C, 0x00, 0x00, 0x00, 0x20 }, ".xml" },
            { new byte[] { 0x4C, 0x6F, 0xA7, 0x94, 0x93, 0x40 }, ".xml" },
            { new byte[] { 0x00, 0x61, 0x73, 0x6D }, ".wasm" },
            { new byte[] { 0xCF, 0x84, 0x01 }, ".lep" },
            { new byte[] { 0x43, 0x57, 0x53 }, ".swf" },
            { new byte[] { 0x46, 0x57, 0x53 }, ".swf" },
            { new byte[] { 0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E, 0x0A }, ".deb" },
            { new byte[] { 0x7B, 0x5C, 0x72, 0x74, 0x66, 0x31 }, ".rtf" },
            { new byte[] { 0x47 }, ".mpeg" },
            { new byte[] { 0x00, 0x00, 0x01, 0xBA }, ".mpeg" },
            { new byte[] { 0x00, 0x00, 0x01, 0xB3 }, ".mpeg" },
            { new byte[] { 0x66, 0x74, 0x79, 0x70, 0x69, 0x73, 0x6F, 0x6D }, ".mp4" },
            { new byte[] { 0x66, 0x74, 0x79, 0x70, 0x4D, 0x53, 0x4E, 0x56 }, ".mp4" },
            { new byte[] { 0x78, 0x01 }, ".zlib" },
            { new byte[] { 0x78, 0x5E }, ".zlib" },
            { new byte[] { 0x78, 0xC9 }, ".zlib" },
            { new byte[] { 0x78, 0xDA }, ".zlib" },
            { new byte[] { 0x78, 0x020 }, ".zlib" },
            { new byte[] { 0x78, 0x07D }, ".zlib" },
            { new byte[] { 0x78, 0xBB }, ".zlib" },
            { new byte[] { 0x78, 0xF9 }, ".zlib" },
            { new byte[] { 0x62, 0x76, 0x78, 0x32 }, ".lzfse" },
            { new byte[] { 0x4F, 0x52, 0x43 }, ".orc" },
            { new byte[] { 0x4F, 0x62, 0x6A, 0x01 }, ".avro" },
            { new byte[] { 0x53, 0x45, 0x51, 0x36 }, ".rc" },
            { new byte[] { 0x3C, 0x72, 0x6F, 0x62, 0x6C, 0x6F, 0x78, 0x21 }, ".rbxl" },
            { new byte[] { 0x65, 0x87, 0x78, 0x56 }, ".obt" },
            { new byte[] { 0x55, 0x55, 0xAA, 0xAA }, ".pcv" },
            { new byte[] { 0x78, 0x56, 0x34 }, ".pbt" },
            { new byte[] { 0x45, 0x4D, 0x58, 0x32 }, ".ez2" },
            { new byte[] { 0x45, 0x4D, 0x55, 0x33 }, ".ez3" },
            { new byte[] { 0x1B, 0x4C, 0x75, 0x61 }, ".luac" },
            { new byte[] { 0x62, 0x6F, 0x6F, 0x6B, 0x00, 0x00, 0x00, 0x00, 0x6D, 0x61, 0x72, 0x6B, 0x00, 0x00, 0x00, 0x00 }, ".alias" },
            { new byte[] { 0x5B, 0x5A, 0x6F, 0x6E, 0x65, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x66, 0x65, 0x72, 0x5D }, ".identifier" },
            { new byte[] { 0x52, 0x65, 0x63, 0x65, 0x69, 0x76, 0x65, 0x64, 0x3A }, ".eml" },
            { new byte[] { 0x20, 0x02, 0x01, 0x62, 0xA0, 0x1E, 0xAB, 0x07, 0x02, 0x00, 0x00, 0x00 }, ".tde" },
            { new byte[] { 0x37, 0x48, 0x03, 0x02, 0x00, 0x00, 0x00, 0x00, 0x58, 0x35, 0x30, 0x39, 0x4B, 0x45, 0x59 }, ".kdb" },
            { new byte[] { 0x28, 0xB5, 0x2F, 0xFD }, ".zst" },
            { new byte[] { 0x52, 0x53, 0x56, 0x4B, 0x44, 0x41, 0x54, 0x41 }, ".rs" },
            { new byte[] { 0x3A, 0x29, 0x0A }, ".sml" },
            { new byte[] { 0x31, 0x0A, 0x30, 0x30 }, ".srt" },
            { new byte[] { 0x34, 0x12, 0xAA, 0x55 }, ".vpk" },
            { new byte[] { 0x2A, 0x2A, 0x41, 0x43, 0x45, 0x2A, 0x2A }, ".ace" },
            { new byte[] { 0x60, 0xEA }, ".arj" },
            { new byte[] { 0x49, 0x53, 0x63, 0x28 }, ".cab" },
            { new byte[] { 0x5A, 0x4F, 0x4F }, ".zoo" },
            { new byte[] { 0x50, 0x31, 0x0A }, ".pbm" },
            { new byte[] { 0x50, 0x34, 0x0A }, ".pbm" },
            { new byte[] { 0x50, 0x32, 0x0A }, ".pgm" },
            { new byte[] { 0x50, 0x35, 0x0A }, ".pgm" },
            { new byte[] { 0x50, 0x33, 0x0A }, ".ppm" },
            { new byte[] { 0x50, 0x36, 0x0A }, ".ppm" },
            { new byte[] { 0xD7, 0xCD, 0xC6, 0x9A }, ".wmf" },
            { new byte[] { 0x67, 0x69, 0x6D, 0x70, 0x20, 0x78, 0x63, 0x66 }, ".xcf" },
            { new byte[] { 0x2F, 0x2A, 0x20, 0x58, 0x50, 0x4D, 0x20, 0x2A, 0x2F }, ".xpm" },
            { new byte[] { 0x41, 0x46, 0x46 }, ".aff" },
            { new byte[] { 0x45, 0x56, 0x46, 0x32 }, ".ex01" },
            { new byte[] { 0x45, 0x56, 0x46 }, ".e01" },
            { new byte[] { 0x51, 0x46, 0x49 }, ".qcow" },
            { new byte[] { 0x46, 0x4C, 0x56 }, ".flv" },
            { new byte[] { 0x3C, 0x3C, 0x3C, 0x20, 0x4F, 0x72, 0x61, 0x63, 0x6C, 0x65, 0x20, 0x56, 0x4D, 0x20, 0x56, 0x69, 0x72, 0x74, 0x75, 0x61, 0x6C, 0x42, 0x6F, 0x78, 0x20, 0x44, 0x69, 0x73, 0x6B, 0x20, 0x49, 0x6D, 0x61, 0x67, 0x65, 0x20, 0x3E, 0x3E, 0x3E }, ".vdi" },
            { new byte[] { 0x63, 0x6F, 0x6E, 0x65, 0x63, 0x74, 0x69, 0x78 }, ".vhd" },
            { new byte[] { 0x76, 0x68, 0x64, 0x78, 0x66, 0x69, 0x6C, 0x65 }, ".vhdx" },
            { new byte[] { 0x49, 0x73, 0x5A, 0x21 }, ".isz" },
            { new byte[] { 0x44, 0x41, 0x41 }, ".daa" },
            { new byte[] { 0x4C, 0x66, 0x4C, 0x65 }, ".evt" },
            { new byte[] { 0x45, 0x6C, 0x66, 0x46, 0x69, 0x6C, 0x65 }, ".evtx" },
            { new byte[] { 0x73, 0x64, 0x62, 0x66 }, ".sdb" },
            { new byte[] { 0x50, 0x4D, 0x43, 0x43 }, ".grp" },
            { new byte[] { 0x4B, 0x43, 0x4D, 0x53 }, ".icm" },
            { new byte[] { 0x72, 0x65, 0x67, 0x66 }, ".dat" },
            { new byte[] { 0x21, 0x42, 0x44, 0x4E }, ".pst" },
            { new byte[] { 0x44, 0x52, 0x41, 0x43, 0x4F }, ".drc" },
            { new byte[] { 0x47, 0x52, 0x49, 0x42 }, ".grib" },
            { new byte[] { 0x42, 0x4C, 0x45, 0x4E, 0x44, 0x45, 0x52 }, ".blend" },
            { new byte[] { 0x00, 0x00, 0x00, 0x0C, 0x4A, 0x58, 0x4C, 0x20, 0x0D, 0x0A, 0x87, 0x0A }, ".jxl" },
            { new byte[] { 0xFF, 0x0A }, ".jxl" },
            { new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00 }, ".ttf" },
            { new byte[] { 0x4F, 0x54, 0x54, 0x4F }, ".otf" },
            { new byte[] { 0x4D, 0x53, 0x57, 0x49, 0x4D, 0x00, 0x00, 0x00, 0xD0, 0x00, 0x00, 0x00, 0x00 }, ".wim" },
            { new byte[] { 0x21, 0x2D, 0x31, 0x53, 0x4C, 0x4F, 0x42, 0x1F }, ".slob" },
            { new byte[] { 0x43, 0x72, 0x65, 0x61, 0x74, 0x69, 0x76, 0x65, 0x20, 0x56, 0x6F, 0x69, 0x63, 0x65, 0x20, 0x46, 0x69, 0x6C, 0x65, 0x1A, 0x1A, 0x00 }, ".voc" },
            { new byte[] { 0x2E, 0x73, 0x6E, 0x64 }, ".snd" },
            { new byte[] { 0x48, 0x5A, 0x4C, 0x52, 0x00, 0x00, 0x00, 0x18 }, "hazelrules" },
            { new byte[] { 0x46, 0x4C, 0x68, 0x64 }, ".flp" },
            { new byte[] { 0x31, 0x30, 0x4C, 0x46 }, ".flm" },
            { new byte[] { 0x00, 0x01, 0x00, 0x00, 0x4D, 0x53, 0x49, 0x53, 0x41, 0x4D, 0x20, 0x44, 0x61, 0x74, 0x61, 0x62, 0x61, 0x73, 0x65 }, ".mmy" },
            { new byte[] { 0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x41, 0x43, 0x45, 0x20, 0x44, 0x42 }, ".accdb" },
            { new byte[] { 0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x4A, 0x65, 0x74, 0x20, 0x44, 0x42 }, ".mdb" },
            { new byte[] { 0x01, 0xFF, 0x02, 0x04, 0x03 }, ".drw" },
            { new byte[] { 0x02, 0x64, 0x73, 0x73 }, ".dss" },
            { new byte[] { 0x03, 0x64, 0x73, 0x73 }, ".dss" },
            { new byte[] { 0x03, 0x00, 0x00, 0x00, 0x41, 0x50, 0x50, 0x52 }, ".adx" },
            { new byte[] { 0x06, 0x06, 0xED, 0xF5, 0xD8, 0x1D, 0x46, 0xE5, 0xBD, 0x31, 0xEF, 0xE7, 0xFE, 0x74, 0xB7, 0x1D }, ".indd" },
            { new byte[] { 0x06, 0x0E, 0x2B, 0x34, 0x02, 0x05, 0x01, 0x01, 0x0D, 0x01, 0x02, 0x01, 0x01, 0x02 }, ".mxf" },
            { new byte[] { 0x07, 0x53, 0x4B, 0x46 }, ".skf" },
            { new byte[] { 0x07, 0x64, 0x74, 0x32, 0x64, 0x64, 0x74, 0x64 }, ".dtd" },
            { new byte[] { 0x0A, 0x16, 0x6F, 0x72, 0x67, 0x2E, 0x62, 0x69, 0x74, 0x63, 0x6F, 0x69, 0x6E, 0x2E, 0x70, 0x72 }, ".wallet" },
            { new byte[] { 0x0D, 0x44, 0x4F, 0x43 }, ".doc" },
            { new byte[] { 0x0E, 0x4E, 0x65, 0x72, 0x6F, 0x49, 0x53, 0x4F }, ".nri" },
            { new byte[] { 0x0E, 0x57, 0x4B, 0x53 }, ".wks" },
            { new byte[] { 0x0F, 0x53, 0x49, 0x42, 0x45, 0x4C, 0x49, 0x55, 0x53 }, ".sib" },
            { new byte[] { 0x23, 0x20, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x44, 0x65, 0x76, 0x65, 0x6C, 0x6F, 0x70, 0x65, 0x72, 0x20, 0x53, 0x74, 0x75, 0x64, 0x69, 0x6F }, ".dsp" },
            { new byte[] { 0x23, 0x21, 0x41, 0x4D, 0x52 }, ".amr" },
            { new byte[] { 0x23, 0x21, 0x53, 0x49, 0x4C, 0x4B, 0x0A }, ".sil" },
            { new byte[] { 0x23, 0x3F, 0x52, 0x41, 0x44, 0x49, 0x41, 0x4E, 0x43, 0x45, 0x0A }, ".hdr" },
            { new byte[] { 0x23, 0x40, 0x7E, 0x5E }, ".vbe" },
            { new byte[] { 0x0D, 0xF0, 0x1D, 0xC0 }, ".cdb" },
            { new byte[] { 0x23, 0x45, 0x58, 0x54, 0x4D, 0x33, 0x55 }, ".m3u" },
            { new byte[] { 0x6D, 0x64, 0x66, 0x00 }, ".m" },
            { new byte[] { 0x4B, 0x50, 0x4B, 0x41 }, ".pak" },
            { new byte[] { 0x41, 0x52, 0x43 }, ".arc" },
            { new byte[] { 0xD0, 0x4F, 0x50, 0x53 }, ".pl" },
            { new byte[] { 0x6E, 0x2B, 0x31, 0x00 }, ".nii" },
            { new byte[] { 0x6E, 0x69, 0x31, 0x00 }, ".hdr" },
            { new byte[] { 0x4D, 0x53, 0x48, 0x7C }, ".hl7" },
            { new byte[] { 0x42, 0x53, 0x48, 0x7C }, ".hl7" },
            { new byte[] { 0x70, 0x77, 0x72, 0x64, 0x61, 0x74, 0x61 }, ".pwrdata" },
            { new byte[] { 0x1A, 0x08 }, ".arc" },
            { new byte[] { 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x42, 0x45, 0x47, 0x49, 0x4E, 0x20, 0x50, 0x47, 0x50, 0x20, 0x50, 0x55, 0x42, 0x4C, 0x49, 0x43, 0x20, 0x4B, 0x45, 0x49, 0x20, 0x42, 0x4C, 0x4F, 0x43, 0x4B, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D }, ".asc" },
            { new byte[] { 0x3A, 0x42, 0x61, 0x73, 0x65 }, ".cnt" },
            { new byte[] { 0x41, 0x53, 0x54, 0x4D, 0x2D, 0x45, 0x35, 0x37 }, ".e57" }
        };

        internal static string? GetExtension(byte[] header)
        {
            foreach (var signature in SignatureExtensions.Keys)
            {
                if (header.Length >= signature.Length && header.Take(signature.Length).SequenceEqual(signature))
                {
                    return SignatureExtensions[signature];
                }
            }

            return null;
        }
    }
}

