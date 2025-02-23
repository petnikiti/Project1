﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections( bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - set up SQL connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO - create the text file connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
