using opgave1;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace opgave
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Agent> Agents = new ObservableCollection<Agent>();

        public MainWindowViewModel()
        {
            Agents.Add(new Agent("0022", "Kusken", "KBU", "Herning"));
            Agents.Add(new Agent("0028", "Fisken", "Studere", "Aarhus"));

            //DataContext = Agents;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}