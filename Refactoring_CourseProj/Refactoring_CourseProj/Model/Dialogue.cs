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
        private static string l,k;
        private static string quest,addr;

        public static string GetFileAddr()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "xml files (*.xml)|*.xml";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
               l = open.FileName;
            }
             addr = l;
            return addr;
        }

        public static string GetQuestion(string m)
        {
           
                XDocument doc = XDocument.Load(l);

                foreach (XElement el in doc.Root.Elements())
                {
                    if (el.Attribute("id").Value == m)
                    {
                       k = el.Attribute("text").Value;
                    }

                }
            quest = k;
            return quest;

        }


    }

}

