using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight; //For mvvmlight 
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;//for class Messenger
using CECS475_Nathanielwpfmvvm.Messages;

namespace wpfmvvm.ViewModel
{
    public class ReceiverViewModel : ViewModelBase
    {
        private string _contentText;

        public string ContentText
        {
            get { return _contentText; }
            set
            {
                _contentText = value;
                RaisePropertyChanged("ContentText");
            }
        }

        public ReceiverViewModel()
        {
            Messenger.Default.Register<NathanielViewModelMessage>(this, OnReceiveMessageAction);
        }

        private void OnReceiveMessageAction(NathanielViewModelMessage obj)
        {
            ContentText = obj.Text;
        }
    }
}
