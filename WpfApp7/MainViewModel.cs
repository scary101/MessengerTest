using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Xml.Serialization;

namespace WpfApp7
{
    public class MainViewModel : HelpCommand
    {
        private TestTcp server;

        private ObservableCollection<User> _users;
        public ObservableCollection<User> users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(users));
            }
        }

        private ObservableCollection<Chat> _messages = new ObservableCollection<Chat>();

        public ObservableCollection<Chat> Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;
                OnPropertyChanged(nameof(Messages));
            }
        }

        private string _serverMes;
        public string Servermes
        {
            get { return _serverMes; }
            set
            {
                _serverMes = value;
                OnPropertyChanged(nameof(Servermes));
            }
        }

        public RelayCommand Send { get; set; }

        public MainViewModel()
        {
            server = new TestTcp();
            users = server.users;
            Messages = server.chat; 
            server.StartServer();
            Send = new RelayCommand(_ => SendServerMessage());
        }


        private void SendServerMessage()
        {
            server.SendMessageServer(Servermes);
        }
    }


}
