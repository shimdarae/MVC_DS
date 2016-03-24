using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace Refactoring_CourseProj
{

    class Dialogue
    {

        public static string GetQuestion(string quest)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "xml files (*.xml)|*.xml";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;
            string m = "1";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string k = open.FileName;
                //читаем данные из файла
                XDocument doc = XDocument.Load(k);

                foreach (XElement el in doc.Root.Elements())
                {
                    if (el.Attribute("id").Value == m)
                    {
                        quest = el.Attribute("text").Value;
                    }

                }
            }
            return quest;
        }

    }
}
