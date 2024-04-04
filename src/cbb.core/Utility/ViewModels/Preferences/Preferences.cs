using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cbb.core
{
    public class Preferences
    {
        private string file = "prefs.cbb";
        public List<string> Repository {  get; set; }

        public Preferences()
        {

        }

        public void Save()
        {
            var dataFile = Path.Combine(Path.GetDirectoryName(CoreAssembly.GetAssemblyLocation().ToString()), file);

            using (var stream = new FileStream(dataFile, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Preferences));
                serializer.Serialize(stream, this);
            }
        }

        public static Preferences Load()
        {
            var dataFile = Path.Combine(Path.GetDirectoryName(CoreAssembly.GetAssemblyLocation().ToString()), "prefs.cbb");

            using (var stream = new FileStream(dataFile, FileMode.Open))
            {
                var deserializer = new XmlSerializer(typeof(Preferences));
                return (Preferences)deserializer.Deserialize(stream);
            }
        }
    }
}
