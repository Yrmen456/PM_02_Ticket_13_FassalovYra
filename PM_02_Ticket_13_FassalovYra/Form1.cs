﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace PM_02_Ticket_13_FassalovYra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddPerformance();
            AddTicketType();
            AddDiscount();
        }
        List<Performance> Performance = new List<Performance>();
        async void AddPerformance()
        {
            Performance = new List<Performance>
            {
                    new Performance { Name = "Красная шапочка",  Price =550 },
                    new Performance { Name = "Летучий корабль",  Price =700 },
                    new Performance { Name = "Лебединое озеро",  Price =1000 },
                    new Performance { Name = "Донкихот",  Price =1500 },
                    new Performance { Name = "Алые паруса",  Price =2000 },
                    new Performance { Name = "Щелкунчик",  Price =2500 },
            };
            ConclusionBoxCombo();
        }

        async void ConclusionBoxCombo()
        {

            comboBoxViews.DataSource = Performance;
            comboBoxViews.DisplayMember = "Name";
            comboBoxViews.ValueMember = "Price";
        }

        List<TicketType> TicketType = new List<TicketType>();
        TicketType ThisTicketTypes;

        async void AddTicketType()
        {
            
            TicketType = new List<TicketType>
            {
                    new TicketType { Name = "VIP", Percent =50 },
                    new TicketType { Name = "Партер", Percent =7 },
                    new TicketType { Name = "Балкон", Percent =20 },

            };
            ConclusionRadioButton();
        }

        async void ConclusionRadioButton()
        {
            сontainerContent.Visible = false;
            сontainerContent.Controls.Clear();
            await Task.Run(() => {
                for (int i = TicketType.Count-1; i >= 0; i--)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Dock = DockStyle.Top;
                    radioButton.Text = TicketType[i].Name;
                    radioButton.Tag = TicketType[i];
                    if (i==0)
                    {
                        ThisTicketTypes = TicketType[i];
                        radioButton.Checked = true;
                    }
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
                    сontainerContent.Controls.Add(radioButton);
                }
            });
            await Task.Delay(10);
            сontainerContent.Visible = true;
        }

        List<Discount> Discount = new List<Discount>();
        async void AddDiscount()
        {
            Discount = new List<Discount>
            {
                    new Discount { Quantity = 10,  CurrentDiscount =5 },
                    new Discount { Quantity = 15,  CurrentDiscount =7 },
                    new Discount { Quantity = 20, CurrentDiscount =10 },
                    new Discount { Quantity = 30, CurrentDiscount =25 },
            };
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            TicketType ticketTypes = (TicketType)radioButton.Tag;
            ThisTicketTypes = ticketTypes;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownQuantity.Controls[0].Hide();
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            DataVerification();
        }

        //Метод Проверки
        void DataVerification()
        {
            Performance ThisPerformance = new Performance();
            Discount ThisDiscount = new Discount();
            decimal Quantity = 0;
            if (TicketType.Count <= 0)
            {
                MessageBox.Show("Что-то пошло не так");
                return;
            }

            ThisPerformance = (Performance)comboBoxViews.SelectedItem;
            if (Performance.Count <= 0)
            {
                MessageBox.Show("Что-то пошло не так");
                return;
            }
            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Укажите количество");
                return;
            }
            Quantity = numericUpDownQuantity.Value;
            for (int i = 0; i < Discount.Count; i++)
            {
                if (Quantity > Discount[i].Quantity)
                {
                    ThisDiscount = Discount[i];
                }
            }
            decimal Result = CalculationPrice(ThisPerformance, ThisTicketTypes, ThisDiscount, Quantity);
            labelInformation.Text = $"Стоимость: {Result} руб.";
        }

        //Метод Расчета Стоимости
        decimal CalculationPrice(Performance ThisPerformancePrice, TicketType ThisIncreasePrice, Discount ThisDiscountPrice, decimal Quantity)
        {
            decimal Result = ((ThisPerformancePrice.Price + (ThisPerformancePrice.Price / 100  * ThisIncreasePrice.Percent)) * Quantity) - (((ThisPerformancePrice.Price + (ThisPerformancePrice.Price / 100 * ThisIncreasePrice.Percent)) * Quantity) /100 * ThisDiscountPrice.CurrentDiscount);
            return Math.Round(Result,2);
        }
        string startupPath = Environment.CurrentDirectory;
        //Метод Вывода в Word
        bool PrintWord()
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return false;
            labelViews.Text = "tr1";
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            Word.Document doc = null;
            try
            {
                labelViews.Text = "tr2";
                Word.Application app = new Word.Application();
                // Открываем
                //doc = app.Documents.Open(Properties.Resources.ResourceManager.GetObject("Pattern.docx"));
                doc = app.Documents.Open(Properties.Resources.ResourceManager.GetObject("Pattern.docx"));
                doc.Activate();
                // Делаем копию 
                doc.SaveAs2(startupPath +@"ChequeCopy.docx");
                doc.Close();
                doc = null;
            
            }
            catch
            {
                labelViews.Text = "F1";
                doc = null;
                return false;
                      
            }
            try
            {
                labelViews.Text = "tr3";
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = startupPath + @"\ChequeCopy.docx";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[4] { "","","","" };
                foreach (Word.Bookmark mark in wBookmarks)
                {

                    wRange = mark.Range;
                    wRange.Text = data[i];
                    var d = wRange.InlineShapes;
                    i++;
                    if (i >= data.Length)
                    {
                        break;
                    }
                }
                Random random = new Random();
                string Name = DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss" + random.Next(1, 10000));
                doc.SaveAs2( $@"{filename}.docx");
                doc.Close();
                doc = null;
                return true;
            }
            catch (Exception ex)
            {
                labelViews.Text = "F2";
                doc.Close();
                doc = null;
                MessageBox.Show("Во время выполнения произошла ошибка! \n" + ex);
                Console.ReadLine();
                return false;
            }
            return true;
        }

        private void buttonIssue_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenImg_Click(object sender, EventArgs e)
        {
            pictureBoxImg.Image = Properties.Resources.Teatr;
            return;
            PrintWord();
        }
    }

    //Класс с данными о Представлениях
    class Performance
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    //Класс с Типами билетов
    class TicketType
    {
        public string Name { get; set; }
        public decimal Percent { get; set; }
    }

    //Класс с данными о Скидках
    class Discount
    {
        public Discount()
        {
            CurrentDiscount = 0;
            CurrentDiscount = 0;
        }
        public int Quantity { get; set; }
        public decimal CurrentDiscount { get; set; }
    }
}
