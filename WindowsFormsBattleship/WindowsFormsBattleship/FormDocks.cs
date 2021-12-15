using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;


namespace WindowsFormsBattleship
{
    public partial class FormDocks : Form
    {
		private readonly DocksCollection docksCollection;
		private Stack<Vehicle> shipInStack;

		/// Логгер
		private readonly Logger logger;
		public FormDocks()
		{
			InitializeComponent();
			docksCollection = new DocksCollection(pictureBox_doc.Width, pictureBox_doc.Height);
			shipInStack = new Stack<Vehicle>();
			logger = LogManager.GetCurrentClassLogger();
			Draw();
		}

		/// Заполнение listBoxLevels
		private void ReloadLevels()
		{
			int index = listBox_listDoc.SelectedIndex;
			listBox_listDoc.Items.Clear();
			for (int i = 0; i < docksCollection.Keys.Count; i++)
			{
				listBox_listDoc.Items.Add(docksCollection.Keys[i]);
			}
			if (listBox_listDoc.Items.Count > 0 && (index == -1 || index >=
		   listBox_listDoc.Items.Count))
			{
				listBox_listDoc.SelectedIndex = 0;
			}
			else if (listBox_listDoc.Items.Count > 0 && index > -1 && index <
		   listBox_listDoc.Items.Count)
			{
				listBox_listDoc.SelectedIndex = index;
			}
		}
		private void Draw()
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBox_doc.Width, pictureBox_doc.Height);
				Graphics gr = Graphics.FromImage(bmp);
				docksCollection[listBox_listDoc.SelectedItem.ToString()].Draw(gr);
				pictureBox_doc.Image = bmp;
			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox_parkName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			logger.Info($"Добавили доки {textBox_parkName.Text}");
			docksCollection.AddParking(textBox_parkName.Text);
			ReloadLevels();
		}
		private void button_AddShip_Click(object sender, EventArgs e)
		{
			var formShipConfig = new FormShipConfig();
			formShipConfig.AddEvent(AddShip);
			formShipConfig.Show();
		}
		private void AddShip(Vehicle ship)
		{
			if (ship != null && listBox_listDoc.SelectedIndex > -1)
			{
				try
				{
					if ((docksCollection[listBox_listDoc.SelectedItem.ToString()]) + ship)
					{
						Draw();
						logger.Info($"Добавлен корабль {ship}");
					}
					else
					{
						logger.Warn("Корабль не удалось поставить");
					}
					Draw();
				}
				catch (DocksOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Переполнение");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Fatal($"{ex.Message} Неизвестная ошибка");
				}
			}
		}

		private void button_parkBShip_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var ship = new Battleship(100, 1000, dialog.Color, dialogDop.Color,
					   true, true, 2, 3);
						if (docksCollection[listBox_listDoc.SelectedItem.ToString()] + ship)
						{
							Draw();
						}
						else
						{
							MessageBox.Show("Доки переполнены");
						}
					}
				}
			}
		}

		private void button_extract_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1 && maskedTextBox_place.Text != "")
			{
				try
				{
					var ship = docksCollection[listBox_listDoc.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox_place.Text);
					if (ship != null)
					{
						shipInStack.Push(ship);
						logger.Info($"Изъят корабль {ship} с места {maskedTextBox_place.Text}");
					}
					Draw();
					maskedTextBox_place.Text = "";
				}
				catch (DocksNotFoundException ex)
				{
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Error($"{ex.Message} Не найдено");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Fatal($"{ex.Message} Неизвестная ошибка");
				}
			}
		}


		private void button_del_Click(object sender, EventArgs e)
		{
			if (listBox_listDoc.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку { listBox_listDoc.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					logger.Info($"Удалили парковку {listBox_listDoc.SelectedItem.ToString()}");
					docksCollection.DelParking(listBox_listDoc.Text);
					ReloadLevels();
				}
			}
		}

		private void listBox_listDoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на доки {listBox_listDoc.SelectedItem.ToString()}");
			Draw();
		}

		private void button_checking_Click(object sender, EventArgs e)
        {
			double index;
			if (maskedTextBox_numPlace.Text != "")
			{
				index = Convert.ToInt32(maskedTextBox_numPlace.Text);
			}
			else { return; }

			if (docksCollection[listBox_listDoc.SelectedItem.ToString()] > index)
			{
				MessageBox.Show("До " + index + " места свободных доков нет");
			}
			else if (docksCollection[listBox_listDoc.SelectedItem.ToString()] < index)
			{
				MessageBox.Show("До " + index + " места есть свободные доки");
			}
		}

        private void buttonAddFromStack_Click(object sender, EventArgs e)
        {
			if (shipInStack.Count() > 0)
			{
				var ship = shipInStack.Pop();
				if (ship != null)
				{
					FormBattleship form = new FormBattleship();
					Random rnd = new Random();
					ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), form.Size.Width, form.Size.Height);
					form.SetShip(ship);
					form.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show("Стек пустой");
				logger.Info($"Стек пустой");
			}
			Draw();
		}

		private void сохранитьвсеПарковкиToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (saveFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				try 
				{
					docksCollection.SaveData(saveFileDialog_ship.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат",
				   MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog_ship.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Fatal($"{ex.Message} Неизвестная ошибка при сохранении");
				}
			}
		}

		private void загрузитьвсеПарковкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				try
				{
					docksCollection.LoadData(openFileDialog_ship.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
				    MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog_ship.FileName);
					ReloadLevels();
					Draw();
				}
				catch (DocksOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Warn($"{ex.Message} Занятое место");
				}
				catch (Exception ex)
				{
					logger.Fatal("Вызвана неизвестная ошибка при сохранении");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void загрузитьоднуПарковкуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog_ship.ShowDialog() == DialogResult.OK)
			{
				try 
				{
					docksCollection.LoadDataOne(openFileDialog_ship.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
				   MessageBoxIcon.Information); 
					logger.Info("Загружено из файла " + openFileDialog_ship.FileName);
					ReloadLevels();
					Draw();
				}
				catch (NullReferenceException ex)
				{
					logger.Error("Вызвана ошибка NullReferenceException");
					MessageBox.Show(ex.Message, "Место занято", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				catch (FormatException ex)
				{
					logger.Error(ex.Message);
					MessageBox.Show(ex.Message, "Ошибка загрузки",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Fatal("Неизвестная ошибка при загрузке");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void сохранитьвыбраннуюПарковкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
				if (saveFileDialog_ship.ShowDialog() == DialogResult.OK)
				{
				try
				{
					docksCollection.SaveDataOne(saveFileDialog_ship.FileName, listBox_listDoc.SelectedItem.ToString());
					MessageBox.Show("Сохранение прошло успешно", "Результат",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog_ship.FileName);
				}
				catch (FormatException ex)
				{
					logger.Error(ex.Message);
					MessageBox.Show(ex.Message, "Ошибка при загрузке",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Fatal("Неизвестная ошибка при сохранении");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
    }
}
