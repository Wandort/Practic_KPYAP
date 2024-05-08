/// <summary>
/// Класс, представляющий запись с информацией о человеке.
/// </summary>
class Record
{
    /// <summary>
    /// Фамилия человека.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Имя человека.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Дата рождения человека в формате "день/месяц/год".
    /// </summary>
    public string BirthDate { get; set; }

    /// <summary>
    /// Номер телефона человека.
    /// </summary>
    public string PhoneNumber { get; set; }
}

/// <summary>
/// Класс, представляющий записную книжку с записями о людях.
/// </summary>
class Notebook
{
    private List<Record> records;

    /// <summary>
    /// Конструктор класса Notebook, инициализирует новый экземпляр записной книжки.
    /// </summary>
    public Notebook()
    {
        records = new List<Record>();
    }

    /// <summary>
    /// Добавляет новую запись в записную книжку.
    /// </summary>
    public void AddRecord(Record record)
    {
        records.Add(record);
    }

    /// <summary>
    /// Удаляет запись из записной книжки по указанному индексу.
    /// </summary>
    public void RemoveRecord(int index)
    {
        records.RemoveAt(index);
    }

    /// <summary>
    /// Находит запись в записной книжке по фамилии.
    /// </summary>
    public Record FindRecordByLastName(string lastName)
    {
        return records.Find(record => record.LastName == lastName);
    }

    /// <summary>
    /// Сортирует записи в записной книжке по фамилии.
    /// </summary>
    public void SortByLastName()
    {
        records.Sort((x, y) => x.LastName.CompareTo(y.LastName));
    }

    /// <summary>
    /// Возвращает запись из записной книжки по указанному индексу.
    /// </summary>
    public Record GetRecordByIndex(int index)
    {
        return records[index];
    }

    /// <summary>
    /// Предоставляет перечислитель для перебора записей в записной книжке.
    /// </summary>
    public IEnumerator<Record> GetEnumerator()
    {
        foreach (Record record in records)
        {
            yield return record;
        }
    }
}