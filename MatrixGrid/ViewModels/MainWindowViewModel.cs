using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace MatrixGrid.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            RowCount = 3;
            ColumnCount = 3;
            Matrix=new ObservableCollection<MatrixItemViewModel>();
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 0,
                RowIndex = 0,
                Value = "0:0"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 1,
                RowIndex = 0,
                Value = "1:0"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 2,
                RowIndex = 0,
                Value = "1:0"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 0,
                RowIndex = 1,
                Value = "0:1"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 1,
                RowIndex = 1,
                Value = "1:1"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 2,
                RowIndex = 1,
                Value = "1:1"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 0,
                RowIndex = 2,
                Value = "0:2"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 1,
                RowIndex = 2,
                Value = "1:2"
            });
            Matrix.Add(new MatrixItemViewModel()
            {
                ColumnIndex = 2,
                RowIndex = 2,
                Value = "1:2"
            });
        }

        private int _rowCount;

        public int RowCount
        {
            get { return _rowCount; }
            set { SetProperty(ref _rowCount, value); }
        }

        private int _columnCount;

        public int ColumnCount
        {
            get { return _columnCount; }
            set { SetProperty(ref _columnCount, value); }
        }

        private ObservableCollection<MatrixItemViewModel> _matrix;

        public ObservableCollection<MatrixItemViewModel> Matrix
        {
            get { return _matrix; }
            set { SetProperty(ref _matrix, value); }
        }


    }
}
