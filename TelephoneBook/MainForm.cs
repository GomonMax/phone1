using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telephone.DAL.DBFiles;
using Telephone.DAL.Helper;
using TelephoneBook.Models;
using TelephoneBook.Services;

namespace TelephoneBook
{
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Номер сторінки DataGriedView
        /// </summary>
        private int _page { get; set; } = 1;
        /// <summary>
        ///     Номер сторінки кнопок GroupBox
        /// </summary>
        private int _groupBoxPage { get; set; } = 1;
        /// <summary>
        ///     Сумарна кількість сторінок, що можна відобразати у DataGriedView
        /// </summary>
        private int _totalPages { get; set; }
        /// <summary>
        ///     Клас, який здійснює зв'язок з БД
        /// </summary>
        private MyContext context { get; set; } = new MyContext();
        public MainForm()
        {
            InitializeComponent();
            this.toolStripTextBoxName.TextBox.PlaceholderText = "П.І.Б";
            this.toolStripTextBoxTel.TextBox.PlaceholderText = "Номер телефону";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DbSeeder.SeedTelBook(context);

            comboBoxCount.Items.AddRange(new ComboBoxView[]
            {
                new ComboBoxView { Id = 1, ViewStr = "10" },
                new ComboBoxView { Id = 2, ViewStr = "20" },
                new ComboBoxView { Id = 3, ViewStr = "30" },
                new ComboBoxView { Id = 4, ViewStr = "50" }
            });
            comboBoxCount.SelectedIndex = 0;            
            SearchPerson();
        }


        /// <summary>
        ///     Пошук елеменів за моделею пошуку
        /// </summary>
        /// <param name="model">Модель пошуку</param>
        private void SearchPerson(SearchModel model = null) 
        {
            model ??= new SearchModel();
            model.page = this._page;
            this.dataPerson.Rows.Clear();
            AbonentDataCollection coll = BookService.Search(context, model);
            
            foreach (AbonentData item in coll)
            {
                object[] arr =
                {
                    item.Id,
                    item.FullName,
                    item.telNummer,
                    item.Gender == true ? "Жіноча" : "Чоловіча"
                };

                this.dataPerson.Rows.Add(arr);
            }

            lblCount.Text = "Всього: " + coll.Count.ToString();

            //
            this._totalPages = (int)Math.Ceiling((decimal)coll.Count / model.countOnePage);
            ShowGroupBox(_totalPages);
        }


        /// <summary>
        ///     Метод, що формує дані моделі пошуку
        /// </summary>
        /// <returns>Повертає модель пошуку</returns>
        private SearchModel GetData() 
        {
            SearchModel model = new SearchModel();
            model.Name = this.toolStripTextBoxName.Text;
            model.telNum = this.toolStripTextBoxTel.Text;
            model.page = this._page;
            if (this.toolStripComboBoxState.SelectedItem != null)
            {
                model.State = this.toolStripComboBoxState.SelectedIndex == 0 ? false : true;
            }
            model.countOnePage = int.Parse((this.comboBoxCount.SelectedItem as ComboBoxView).ViewStr);
            
            return model;
        }


        /// <summary>
        ///     Метод, що відображає кнопки у groupBox (використовується для пагінації)
        /// </summary>
        /// <param name="totalPages">Приймає кількість сторінок</param>
        private void ShowGroupBox(int totalPages) 
        {
            this.groupBoxButtons.Controls.Clear();
            for (int i = ((_groupBoxPage - 1) * 14) + 1; i <= totalPages; i++)
            {
                if (this.groupBoxButtons.Controls.Count < 14)
                {
                    this.groupBoxButtons.Controls.Add(GetElementButton(i, (i - 1)- ((_groupBoxPage - 1) * 14)));
                }
            }
        }


        /// <summary>
        ///     Метод клік кнопки пошуку по елементам з фільтра
        /// </summary>
        /// <param name="sender">Об'єкт кнопки "Фільтрація"</param>
        /// <param name="e">Параметри події</param>
        private void toolStripMenuButton_Click(object sender, EventArgs e)
        {
            this._page = 1;
            this._groupBoxPage = 1;
            SearchPerson(GetData());
        }
        /// <summary>
        ///     Метод клік кнопки виходу з програми
        /// </summary>
        /// <param name="sender">Об'єкт кнопки "Вихід"</param>
        /// <param name="e">Параметри події</param>
        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        ///     Метод, що формує кнопку по вказаним параметрам
        /// </summary>
        /// <param name="id">Номер кнопки</param>
        /// <param name="startPos">Стартова позиція</param>
        /// <param name="dx">Відстань між лівими краями кнопки (Задана по замовчанню)</param>
        /// <returns></returns>
        private Button GetElementButton(int id, int startPos, int dx = 50) 
        {
            Button btn = new Button();
            btn.Font = new Font("Times New Roman", 15);
            btn.Name = "btn" + id;
            btn.Text = id.ToString();
            btn.Size = new Size(45, 45);
            btn.Location = new Point(10 + startPos * dx, 10);
            btn.Click += new EventHandler(groupBtnBox_Click);
            return btn;
        }


        /// <summary>
        ///     Метод клік кнопки, що відповідає за пагінацію
        /// </summary>
        /// <param name="sender">Об'єкт кнопки із меню GroupBox</param>
        /// <param name="e">Параметри події</param>
        private void groupBtnBox_Click(object sender, EventArgs e) 
        {
            Button btn = (sender as Button);
            this._page = int.Parse(btn.Text);
            SearchPerson(GetData());
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (this._groupBoxPage*14 < this._totalPages) 
            {
                this._groupBoxPage++;
                ShowGroupBox(this._totalPages);
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (this._groupBoxPage > 1) 
            {
                this._groupBoxPage--;
                ShowGroupBox(this._totalPages);
            }
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxButtons_Enter(object sender, EventArgs e)
        {

        }
    }
}
