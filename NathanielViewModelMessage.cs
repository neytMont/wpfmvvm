﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace wpfmvvm.Messages
{
    class NathanielViewModelMessage: MessageBase
    {
        public string Text { get; set; }
    }
}
