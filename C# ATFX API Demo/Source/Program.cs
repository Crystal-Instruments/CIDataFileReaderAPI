﻿/*------------------------------------------------------------------------
 * Copyright (C) 2022 by Crystal Instruments Corporation.
 * All rights reserved
 ------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATFXReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATFXReaderDemo());
        }
    }
}
