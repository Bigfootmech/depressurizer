/*
This file is part of Depressurizer.
Copyright 2011, 2012, 2013 Steve Labbe.

Depressurizer is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Depressurizer is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Depressurizer.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.IO;
using Microsoft.Win32;

namespace Depressurizer
{
    public class LinuxHelper : IPlatformHelper
    {

        public LinuxHelper ()
        {
        }

        public string GetSteamPath(){

            string steamDefaultPathLinux =  
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) 
                + "/.local/share/Steam";
            
            if (Directory.Exists(steamDefaultPathLinux)) {
                return steamDefaultPathLinux;
            }

            string steamDefaultPathLinuxNew =  
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) 
                + "/.steam/root";
            
            if (Directory.Exists(steamDefaultPathLinuxNew)) {
                return steamDefaultPathLinuxNew;
            }

            return string.Empty;
        }
    }
}

