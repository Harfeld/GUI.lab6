using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave1
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Agent> Agents = new ObservableCollection<Agent>();
        Agents.Add(new Agent("0022","Kusken","KBU","Herning"));
            Agents.Add(new Agent("0028", "Fisken", "Studere", "Aarhus"));
        DataContext = Agents;
    }
}
