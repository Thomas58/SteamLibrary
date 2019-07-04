using System;
using System.IO;
using System.Xml.Serialization;

namespace Tools
{
    class FileService
    {
        private static string File = "save.obj";
        private static string TempFile = "temp.obj";

        public static void SaveFile(object obj)
        {
            lock (File)
            {
                FileInfo TempFileInfo = new FileInfo(Environment.CurrentDirectory + Path.DirectorySeparatorChar + TempFile);
                if (TempFileInfo.Exists)
                    TempFileInfo.Delete();
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                using (FileStream stream = TempFileInfo.OpenWrite())
                {
                    serializer.Serialize(stream, obj);
                }
                FileInfo FileInfo = new FileInfo(Environment.CurrentDirectory + Path.DirectorySeparatorChar + File);
                if (FileInfo.Exists)
                    FileInfo.Delete();
                TempFileInfo.MoveTo(FileInfo.FullName);
            }
        }

        public static T LoadFile<T>()
        {
            lock (File)
            {
                T obj = default(T);
                FileInfo FileInfo = new FileInfo(Environment.CurrentDirectory + Path.DirectorySeparatorChar + File);
                if (!FileInfo.Exists)
                    throw new IOException("File doesn't exist");
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (FileStream stream = FileInfo.OpenRead())
                {
                    obj = (T)serializer.Deserialize(stream);
                }
                return obj;
            }
        }
    }
}
