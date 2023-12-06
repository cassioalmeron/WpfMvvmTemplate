namespace WpfExample.MVVM
{
    public class MainViewModel : ViewModelBase
    {
        private string? _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value, () => Name); }
        }
    }
}