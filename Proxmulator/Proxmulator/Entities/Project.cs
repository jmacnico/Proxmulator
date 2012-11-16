using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Proxmulator.Entities
{
    public class Project
    {
        public string Name { get; set; }
        public string BusinessId { get; set; }
        public List<TestStep> Steps { get; set; }
        internal string CurrentPath { get; set; }


        public Project()
        {
            Steps = new List<TestStep>();
        }


        public void Save()
        {
            var serializer = new XmlSerializer(typeof(Project));
            var writer = new StreamWriter(GetPath(),false, Encoding.UTF8);
            serializer.Serialize(writer, this);
            writer.Close();
        }


        public static Project Load(string file)
        {
            var serializer = new XmlSerializer(typeof(Project));

            var reader = new StreamReader(file, Encoding.UTF8);
            var obj = serializer.Deserialize(reader);

            reader.Close();

            var proj = obj as Project;
            if (proj != null)
                proj.CurrentPath = file;


            return proj;
        }


        private string GetPath()
        {
            if (CurrentPath == null)
            {
                var path = GetProjectDirectory();
                CurrentPath = Path.Combine(path, this.BusinessId + ".xml");
            }

            return CurrentPath;
        }


        public static string GetProjectDirectory()
        {
            var path = Path.Combine("C:\\", "Proxmulator", "Projects Saved");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

    }
}
