using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactoring_CourseProj
{
    class Controller
    {

        public void SaveLog(DialogueView dialogueView)
        {
            SaveFileDialog savelog = new SaveFileDialog();
            savelog.InitialDirectory = "c:\\";
            savelog.Filter = "txt files (*.txt)|*.txt";
            savelog.FilterIndex = 2;
            savelog.RestoreDirectory = true;

            if (savelog.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(savelog.FileName);
                foreach (var item in dialogueView.history)
                    writer.WriteLine(item);
                writer.Close();
            }
        }
    }
}
