using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TrueFalse
{

	// Класс для вопроса
	[Serializable]
	public class Question
	{
		private string text; // Текст вопроса
		private bool trueFalse; // Правда или нет
						// Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы
						// реализовать через открытые свойства, но для упрощения примера оставим так
						// Вам же предлагается сделать поля закрытыми и реализовать открытые
						// свойства Text и TrueFalse
						// Для сериализации должен быть пустой конструктор.
		public string Text { get; set; }
		public bool TrueFalse { get; set; }

		public Question()
		{
		}
		public Question(string text, bool trueFalse) // Конструктор класса
		{
			this.text = text;
			this.trueFalse = trueFalse;
		}

	}

	 class TFclass
	{
		string fileName;
		List<Question> list;

		public string FileName
		{
			set { fileName = value; }
		}

		public TFclass(string fileName) //Конструктор класса
		{
			this.fileName = fileName;
			list = new List<Question>();
		}

		public void Add(string text, bool trueFalse) //Метод  добавляющий вопрос в список list
		{
			list.Add(new Question(text, trueFalse));
		}

		public void Remove(int index) //Метод убирающий вопрос из списка вопросов
		{
			if (list != null && index < list.Count && index >= 0)// Если список не пуст И index меньше длинны списка И index больще или равен 0
				list.RemoveAt(index);// убираем этот вопрос
		}

		// Индексатор - свойство для доступа к закрытому объекту
		public Question this[int index]//Индексатор 
		{
			get { return list[index]; }
		}

		public void Save()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Create,
			FileAccess.Write);
			xmlFormat.Serialize(fStream, list);
			fStream.Close();
		}

		public void Load()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Open,
			FileAccess.Read);
			try
			{
				list = (List<Question>)xmlFormat.Deserialize(fStream);
				fStream.Close();
			}
			catch (OutOfMemoryException)
			{
				throw;
			}
			
		}

		public int Count
		{
			get { return list.Count; }
		}
	}
} 