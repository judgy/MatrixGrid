using Prism.Mvvm;

namespace MatrixGrid.ViewModels
{
    public class MatrixItemViewModel: BindableBase
    {
        private int _rowIndex;

        public int RowIndex
        {
            get { return _rowIndex; }
            set { SetProperty(ref _rowIndex, value); }
        }

        private int _columnIndex;

        public int ColumnIndex
        {
            get { return _columnIndex; }
            set { SetProperty(ref _columnIndex, value); }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }



    }
}