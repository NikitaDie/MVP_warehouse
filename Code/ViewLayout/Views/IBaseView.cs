﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface IBaseView : IView
    {
        public void LoadNewForm(IView newForm);
    }
}
