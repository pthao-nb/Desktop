using System.Collections.ObjectModel;

namespace Data_Binding
{
    public class NumberOfPlayers : ObservableCollection<int>
    {
        public NumberOfPlayers()
        {
            Add(2);
            Add(3);
            Add(4);
        }
    }
}
