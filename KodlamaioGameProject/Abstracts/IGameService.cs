﻿using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstracts
{
    public interface IGameService
    {
        void Add( Game game );
        void Delete( Game game );


    }
}
