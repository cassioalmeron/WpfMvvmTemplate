using System.Windows.Input;

namespace WpfExample.MVVM
{
    public class MainViewModel : ViewModelBase
    {
        //public MainViewModel()
        //{
        //    SelectFileCommand = new RelayCommand(SelectFile);
        //}

        private string? _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value, () => Name); }
        }

        private string? _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { SetProperty(ref _fileName, value, () => FileName); }
        }

        //public ICommand SelectFileCommand { get; private set; }

        //private void SelectFile()
        //{

        //}
    }
}