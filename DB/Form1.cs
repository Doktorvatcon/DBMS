using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DB
{
    public partial class Form : System.Windows.Forms.Form
    {
        public int unsave_count=0; // кол-во несохраннеых элементов
        public string filePath; // переменная для пути файла
        public bool b_status = false; // нужна чтобы при загрузке БД стастус не менялся
        public int stroke_count = 0;// переменная для автоматической нумерации;
        public Form()
        {
            InitializeComponent();
            filePath = "provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database_main1.mdb";
            
        }
        //Функция вывода информации об программе
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("версия 1.0", "об программе");
        }
        //функция загрузки файла бд
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_status = false;
            unsave_count = 0;
            dataGridView1.Rows.Clear(); //очищение datagrid
            dataGridView1.Columns.Clear();
            OleDbConnection oleDbConnection = new OleDbConnection(filePath); //установление соединения с бд файлом
            oleDbConnection.Open(); //открытие файла
            string table_name = "SELECT * FROM DB"; //команда импорта данных в datagrid
            label_name.Text = "DB";
            OleDbCommand dbCommand = new OleDbCommand(table_name, oleDbConnection); //инструкция для файла бд по выполнению команды 
            OleDbDataReader dataReader = dbCommand.ExecuteReader();//Чтение строк данных с файла
            Upload(dataReader);//вызов функция записи данных из файла в datagrid
            dataReader.Close();//закрытие чтение строк
            oleDbConnection.Close();//закрытие соединения
            b_status = true;
            try
            {
                stroke_count = Convert.ToInt32(dataGridView1[0, dataGridView1.RowCount - 2].Value) + 1;// получить номер последней строки
            }
            catch
            {
                stroke_count = 1;
            }
            }
        // Функция чтения название столбцов из файла
        private void SetColumnName(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataGridView1.Columns.Add(table.Columns[0].ColumnName, table.Rows[i][0].ToString());
            }
            dataGridView1.Columns.Add("status", "Статус");// столбец для отображения статуса строки
        }
        // Функция записи данных из файла в datagrid
        private void Upload(OleDbDataReader dataReader)
        {
                SetColumnName(dataReader.GetSchemaTable());
                while (dataReader.Read())
                {

                    Object[] column = new Object[dataReader.VisibleFieldCount];
                    for (int i = 0; i < dataReader.VisibleFieldCount; i++)
                    {
                        column[i] = dataReader[i];
                    }
                dataGridView1.Rows.Add(column);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1[dataGridView1.Columns.Count-1, dataGridView1.RowCount - 2].Value = "Сохранено";
                }
        }
        // Функция удаления строки из файла и datagrid
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Предуприждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OleDbConnection dbConnection = new OleDbConnection(filePath);
                    dbConnection.Open();

                    string num = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string delete = "DELETE FROM DB WHERE №= " + num;

                    OleDbCommand command = new OleDbCommand(delete,dbConnection);
                    try
                    {
                        b_status = false;
                        command.ExecuteNonQuery();
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                        dataGridView1.Refresh();
                        b_status = true;
                    }
                    
                    catch
                    {
                        MessageBox.Show("Попробуйте снова", "Ошибка");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Выдилите строку для удаления", "Ошибка");
            }
        }
        //изменение цвета и статуса строки при ее создании


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==1)
            {
                int n = dataGridView1.SelectedRows[0].Index;
                Add(n);
            }
            else
            {
                MessageBox.Show("Выделете одну строку для добавления","Ошибка");
            }
        }
        // функция добавления строки из datagrid в файл
        private void Add(int n)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Rows[n].Cells[i].Value == null)
                {
                    MessageBox.Show("Вы оставили пустые поля", "Ошибка");
                    dataGridView1.CurrentCell = dataGridView1.Rows[n].Cells[i];
                    return;
                }
            }
            string num = dataGridView1[0, n].Value.ToString();
            string first_name = "'" + dataGridView1[2, n].Value.ToString() + "'";
            string second_name = "'" + dataGridView1[3, n].Value.ToString() + "'";
            string last_name = "'" + dataGridView1[1, n].Value.ToString() + "'";
            string birthday = "'" + dataGridView1[4, n].Value.ToString() + "'";
            string id = "'" + dataGridView1[5, n].Value.ToString() + "'";
            string number = "'" + dataGridView1[6, n].Value.ToString() + "'";
            string adress = "'" + dataGridView1[7, n].Value.ToString() + "'";
            string father_name = "'" + dataGridView1[8, n].Value.ToString() + "'";
            string mother_name = "'" + dataGridView1[9, n].Value.ToString() + "'";

            OleDbConnection dbConnection = new OleDbConnection(filePath);
            try
            {
                b_status = false;
                dbConnection.Open();
                string insert = "INSERT INTO DB VALUES (" + num + "," + last_name + "," + first_name + "," + second_name + "," + birthday + "," + id + "," + number + "," + adress + "," + father_name + "," + mother_name + ")";
                OleDbCommand command = new OleDbCommand(insert, dbConnection);
                command.ExecuteNonQuery();
                dbConnection.Close();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1[dataGridView1.Columns.Count - 1, n].Value = "Сохранено";
                unsave_count--;
                b_status = true;
            }
            catch
            {
                MessageBox.Show("Попробуйте снова", "Ошибка");
            }
        }
        // Функция обновление строки
        private void Update(int n)
        {
            string num = dataGridView1[0, n].Value.ToString();
            string first_name = "'" + dataGridView1[2, n].Value.ToString() + "'";
            string second_name = "'" + dataGridView1[3, n].Value.ToString() + "'";
            string last_name = "'" + dataGridView1[1, n].Value.ToString() + "'";
            string birthday = "'" + dataGridView1[4, n].Value.ToString() + "'";
            string id = "'" + dataGridView1[5, n].Value.ToString() + "'";
            string number = "'" + dataGridView1[6, n].Value.ToString() + "'";
            string adress = "'" + dataGridView1[7, n].Value.ToString() + "'";
            string father_name = "'" + dataGridView1[8, n].Value.ToString() + "'";
            string mother_name = "'" + dataGridView1[9, n].Value.ToString() + "'";

            OleDbConnection dbConnection = new OleDbConnection(filePath);

            dbConnection.Open();
            string update = "UPDATE DB SET Фамилия=" + last_name + ", Имя=" + first_name + ", Отчество=" + second_name + ", ИИН=" + id + ", Адрес=" + adress + ", [Дата рождения]=" + birthday + ", [Номер телефона]=" + number + ",[ФИО отца]=" + father_name + ",[ФИО матери]=" + mother_name + " WHERE №=" + num;
            OleDbCommand command = new OleDbCommand(update, dbConnection);
            try
            {
                b_status = false;
                command.ExecuteNonQuery();
                dbConnection.Close();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1[dataGridView1.Columns.Count - 1, n].Value = "Сохранено";
                unsave_count--;
                b_status = true;
            }
            catch
            {
                MessageBox.Show("Попробуйте снова", "Ошибка");
            }

        }
        private void update_row_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int n = dataGridView1.SelectedRows[0].Index;
                Update(n);
            }
            else
            {
                MessageBox.Show("Выделете одну строку для обновления", "Ошибка");
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsave_count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти? У вас имеется несохраненных строк:"+ unsave_count.ToString()+".", "Предуприждение", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1[dataGridView1.ColumnCount - 1, e.RowIndex].Value.ToString()=="Сохранено" && b_status)
            {
                unsave_count++;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                dataGridView1[dataGridView1.ColumnCount - 1, e.RowIndex].Value = "Изменено";
            }
        }

        private void InstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form help = new Form();
            help.Text = "Инструкция";
            help.MaximizeBox = false;
            help.MinimizeBox = false;
            help.Size = new Size(500, 200);
            ListView listView = new ListView();
            help.Controls.Clear();

            RichTextBox text = new RichTextBox();
            text.Size = new Size(500, 200);
            text.Location = new Point(0, 0);
            string add_text = "Для сохранения введенных данных выделите нужную строку, щелкнув по треугольнику слева, и нажмите Добавить или нажмите кнопку Добавить все.\n\nДля обновления введенных данных выделите нужную строку, щелкнув по треугольнику слева, и нажмите Обновить или нажмите кнопку Обновить все.";
            text.Text = add_text;
            text.ReadOnly = true;
            text.Font = new Font("Arial", 14);
            help.Controls.Add(text);
            help.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            help.ShowDialog(this);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (b_status == true)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count -2].DefaultCellStyle.BackColor = Color.Yellow;
                unsave_count++;
                dataGridView1[dataGridView1.Columns.Count - 1, dataGridView1.RowCount - 2].Value = "Не сохранено";
                dataGridView1[0, dataGridView1.RowCount - 2].Value = stroke_count;
                stroke_count++;
            }
        }

        private void Add_all_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[dataGridView1.ColumnCount - 1, i].Value == "Не сохранено")
                {
                    Add(i);
                }
            }
        }

        private void Update_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[dataGridView1.ColumnCount - 1, i].Value == "Изменено")
                {
                    Update(i);
                }
            }
        }
    }
}
