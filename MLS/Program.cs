﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*MusicDatabase.MusicBrainz.MusicBrainzSyncronizer MBS = new MusicDatabase.MusicBrainz.MusicBrainzSyncronizer();
            await MBS.authorize();*/
        }
    }
}
