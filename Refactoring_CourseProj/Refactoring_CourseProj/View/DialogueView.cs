using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactoring_CourseProj
{
    public partial class DialogueView : Form
    {
        

        public DialogueView()
        {
            InitializeComponent();
        }

        private Controller controller = new Controller();
        private DialogueView dialogueView;

        private void DialogueView_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Программный продукт реализует макет диалогово-технологического 
комплекса генерации сложныхпрограммных систем. 

Данный макет реализован на основе автомата Мили.

Курсовой проект выполнен студенткой 2 курса группы 09-411 
Рябовой Дарьей.");
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Для запуска сценария диалога выберите (Открыть...) на вкладке
(Меню)

Для ввода используйте клавиатуру, для записи ответа нажмите
на кнопку (Ответить)

Возможные варианты ответа представлены в соответствующем
поле

Ход диалога документируется в соответствующем поле

Чтобы сохранить ход диалога, выберите (Сохранить лог диалога) на
 вкладке  (Меню)");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogue.GetFileAddr();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxlog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<string> history
        {
            get
            {
                List<string> history = new List<string>();
                foreach (var item in listBoxlog.Items)
                    history.Add(item.ToString());
                return history;
            }
        }

        private void сохранитьЛогДиалогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SaveLog(dialogueView);
        }
    }
}
