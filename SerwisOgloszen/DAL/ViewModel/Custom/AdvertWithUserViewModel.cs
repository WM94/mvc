﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel.Custom
{
    public class AdvertWithUserViewModel
    {

        public OgloszenieModelView ogloszenie { set; get; }
        public UserViewModel user { set; get; }

    }
}
