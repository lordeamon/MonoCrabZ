﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoCrab
{
    interface IOnCollisionEnter
    {
        void OnCollisionEnter(CCollider other);
    }
}
