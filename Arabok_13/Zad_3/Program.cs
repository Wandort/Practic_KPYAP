namespace MyInfoApp
{
    public class MyInfo
    {
        private string _name;

        public event EventHandler NameChanged;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnNameChanged();
                }
            }
        }

        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main()
        {
            MyInfo myInfo = new MyInfo();
            myInfo.NameChanged += (sender, e) =>
            {
                Console.WriteLine($"Имя изменено на: {((MyInfo)sender).Name}");
            };

            myInfo.Name = "Евгений";

            myInfo.Name = "Жендос";
        }
    }
}